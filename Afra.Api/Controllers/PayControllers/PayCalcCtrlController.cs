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

namespace Afra.Api.Controllers.PayCalcCtrlControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayCalcCtrlController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayCalcCtrlController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayCalcCtrlCommand command)
        {
            command.Validate();

            var PayCalcCtrls = await _unitOfWork.PayCalcCtrlRepository.FindAsync(c => c.Id == command.Id);

            if (PayCalcCtrls.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayCalcCtrl = Mapper.Map(command);
            await _unitOfWork.PayCalcCtrlRepository.AddAsync(newPayCalcCtrl);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayCalcCtrlCommand command)
        {

            command.Validate();

            var PayCalcCtrl = await _unitOfWork.PayCalcCtrlRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayCalcCtrl == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayCalcCtrl = Mapper.Map(PayCalcCtrl, command);
            PayCalcCtrl.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayCalcCtrl = await _unitOfWork.PayCalcCtrlRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayCalcCtrl == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayCalcCtrl.IsActive = false;
            PayCalcCtrl.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayCalcCtrls = await _unitOfWork.PayCalcCtrlRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayCalcCtrlsDto = Mapper.Map(PayCalcCtrls);

            return OkResult(CustomMessage.DefaultMessage, PayCalcCtrlsDto.ToPagingAndSorting(query), PayCalcCtrlsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayCalcCtrl = await _unitOfWork.PayCalcCtrlRepository.GetByIdAsync(id);

            if (PayCalcCtrl is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayCalcCtrlDto = Mapper.Map(PayCalcCtrl);

            return OkResult( CustomMessage.DefaultMessage , PayCalcCtrlDto);

        }
    }
}
