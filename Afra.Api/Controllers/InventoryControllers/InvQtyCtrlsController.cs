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

namespace Afra.Api.Controllers.InvQtyCtrlsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvQtyCtrlsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvQtyCtrlsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvQtyCtrlsCommand command)
        {
            command.Validate();

            var InvQtyCtrlss = await _unitOfWork.InvQtyCtrlsRepository.FindAsync(c => c.Id == command.Id);

            if (InvQtyCtrlss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvQtyCtrls = Mapper.Map(command);
            await _unitOfWork.InvQtyCtrlsRepository.AddAsync(newInvQtyCtrls);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvQtyCtrlsCommand command)
        {

            command.Validate();

            var InvQtyCtrls = await _unitOfWork.InvQtyCtrlsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvQtyCtrls == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvQtyCtrls = Mapper.Map(InvQtyCtrls, command);
            InvQtyCtrls.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvQtyCtrls = await _unitOfWork.InvQtyCtrlsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvQtyCtrls == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvQtyCtrls.IsActive = false;
            InvQtyCtrls.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvQtyCtrlss = await _unitOfWork.InvQtyCtrlsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvQtyCtrlssDto = Mapper.Map(InvQtyCtrlss);

            return OkResult(CustomMessage.DefaultMessage, InvQtyCtrlssDto.ToPagingAndSorting(query), InvQtyCtrlssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvQtyCtrls = await _unitOfWork.InvQtyCtrlsRepository.GetByIdAsync(id);

            if (InvQtyCtrls is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvQtyCtrlsDto = Mapper.Map(InvQtyCtrls);

            return OkResult( CustomMessage.DefaultMessage , InvQtyCtrlsDto);

        }
    }
}
