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

namespace Afra.Api.Controllers.PayCtrlControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayCtrlController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayCtrlController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayCtrlCommand command)
        {
            command.Validate();

            var PayCtrls = await _unitOfWork.PayCtrlRepository.FindAsync(c => c.Id == command.Id);

            if (PayCtrls.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayCtrl = Mapper.Map(command);
            await _unitOfWork.PayCtrlRepository.AddAsync(newPayCtrl);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayCtrlCommand command)
        {

            command.Validate();

            var PayCtrl = await _unitOfWork.PayCtrlRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayCtrl == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayCtrl = Mapper.Map(PayCtrl, command);
            PayCtrl.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayCtrl = await _unitOfWork.PayCtrlRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayCtrl == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayCtrl.IsActive = false;
            PayCtrl.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayCtrls = await _unitOfWork.PayCtrlRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayCtrlsDto = Mapper.Map(PayCtrls);

            return OkResult(CustomMessage.DefaultMessage, PayCtrlsDto.ToPagingAndSorting(query), PayCtrlsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayCtrl = await _unitOfWork.PayCtrlRepository.GetByIdAsync(id);

            if (PayCtrl is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayCtrlDto = Mapper.Map(PayCtrl);

            return OkResult( CustomMessage.DefaultMessage , PayCtrlDto);

        }
    }
}
