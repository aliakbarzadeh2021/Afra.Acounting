using Microsoft.AspNetCore.Mvc;
using Afra.api.Base;
using Afra.Domain.Entities;
using Afra.Repository;
using Afra.Message.Base;
using Afra.Message.Commands;
using Afra.Message.Dtos;
using Afra.Message;
using System;
using System.Linq;
using System.Threading.Tasks;
using Afra.Infrastructure.Base;

namespace Afra.Api.Controllers.InvQtPartRelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvQtPartRelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvQtPartRelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvQtPartRelsCommand command)
        {
            command.Validate();

            var InvQtPartRelss = await _unitOfWork.InvQtPartRelsRepository.FindAsync(c => c.Id == command.Id);

            if (InvQtPartRelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvQtPartRels = Mapper.Map(command);
            await _unitOfWork.InvQtPartRelsRepository.AddAsync(newInvQtPartRels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvQtPartRelsCommand command)
        {

            command.Validate();

            var InvQtPartRels = await _unitOfWork.InvQtPartRelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvQtPartRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvQtPartRels = Mapper.Map(InvQtPartRels, command);
            InvQtPartRels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvQtPartRels = await _unitOfWork.InvQtPartRelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvQtPartRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvQtPartRels.IsActive = false;
            InvQtPartRels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvQtPartRelss = await _unitOfWork.InvQtPartRelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvQtPartRelssDto = Mapper.Map(InvQtPartRelss);

            return OkResult(CustomMessage.DefaultMessage, InvQtPartRelssDto.ToPagingAndSorting(query), InvQtPartRelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvQtPartRels = await _unitOfWork.InvQtPartRelsRepository.GetByIdAsync(id);

            if (InvQtPartRels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvQtPartRelsDto = Mapper.Map(InvQtPartRels);

            return OkResult( CustomMessage.DefaultMessage , InvQtPartRelsDto);

        }
    }
}
