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

namespace Afra.Api.Controllers.InvVchTransControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvVchTransController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvVchTransController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvVchTransCommand command)
        {
            command.Validate();

            var InvVchTranss = await _unitOfWork.InvVchTransRepository.FindAsync(c => c.Id == command.Id);

            if (InvVchTranss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvVchTrans = Mapper.Map(command);
            await _unitOfWork.InvVchTransRepository.AddAsync(newInvVchTrans);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvVchTransCommand command)
        {

            command.Validate();

            var InvVchTrans = await _unitOfWork.InvVchTransRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvVchTrans == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvVchTrans = Mapper.Map(InvVchTrans, command);
            InvVchTrans.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvVchTrans = await _unitOfWork.InvVchTransRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvVchTrans == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvVchTrans.IsActive = false;
            InvVchTrans.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvVchTranss = await _unitOfWork.InvVchTransRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvVchTranssDto = Mapper.Map(InvVchTranss);

            return OkResult(CustomMessage.DefaultMessage, InvVchTranssDto.ToPagingAndSorting(query), InvVchTranssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvVchTrans = await _unitOfWork.InvVchTransRepository.GetByIdAsync(id);

            if (InvVchTrans is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvVchTransDto = Mapper.Map(InvVchTrans);

            return OkResult( CustomMessage.DefaultMessage , InvVchTransDto);

        }
    }
}
