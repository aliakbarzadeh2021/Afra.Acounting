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

namespace Afra.Api.Controllers.InvFormItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvFormItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvFormItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvFormItmCommand command)
        {
            command.Validate();

            var InvFormItms = await _unitOfWork.InvFormItmRepository.FindAsync(c => c.Id == command.Id);

            if (InvFormItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvFormItm = Mapper.Map(command);
            await _unitOfWork.InvFormItmRepository.AddAsync(newInvFormItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvFormItmCommand command)
        {

            command.Validate();

            var InvFormItm = await _unitOfWork.InvFormItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvFormItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvFormItm = Mapper.Map(InvFormItm, command);
            InvFormItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvFormItm = await _unitOfWork.InvFormItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvFormItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvFormItm.IsActive = false;
            InvFormItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvFormItms = await _unitOfWork.InvFormItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvFormItmsDto = Mapper.Map(InvFormItms);

            return OkResult(CustomMessage.DefaultMessage, InvFormItmsDto.ToPagingAndSorting(query), InvFormItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvFormItm = await _unitOfWork.InvFormItmRepository.GetByIdAsync(id);

            if (InvFormItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvFormItmDto = Mapper.Map(InvFormItm);

            return OkResult( CustomMessage.DefaultMessage , InvFormItmDto);

        }
    }
}
