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

namespace Afra.Api.Controllers.PayCalcCtrlDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayCalcCtrlDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayCalcCtrlDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayCalcCtrlDetCommand command)
        {
            command.Validate();

            var PayCalcCtrlDets = await _unitOfWork.PayCalcCtrlDetRepository.FindAsync(c => c.Id == command.Id);

            if (PayCalcCtrlDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayCalcCtrlDet = Mapper.Map(command);
            await _unitOfWork.PayCalcCtrlDetRepository.AddAsync(newPayCalcCtrlDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayCalcCtrlDetCommand command)
        {

            command.Validate();

            var PayCalcCtrlDet = await _unitOfWork.PayCalcCtrlDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayCalcCtrlDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayCalcCtrlDet = Mapper.Map(PayCalcCtrlDet, command);
            PayCalcCtrlDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayCalcCtrlDet = await _unitOfWork.PayCalcCtrlDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayCalcCtrlDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayCalcCtrlDet.IsActive = false;
            PayCalcCtrlDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayCalcCtrlDets = await _unitOfWork.PayCalcCtrlDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayCalcCtrlDetsDto = Mapper.Map(PayCalcCtrlDets);

            return OkResult(CustomMessage.DefaultMessage, PayCalcCtrlDetsDto.ToPagingAndSorting(query), PayCalcCtrlDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayCalcCtrlDet = await _unitOfWork.PayCalcCtrlDetRepository.GetByIdAsync(id);

            if (PayCalcCtrlDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayCalcCtrlDetDto = Mapper.Map(PayCalcCtrlDet);

            return OkResult( CustomMessage.DefaultMessage , PayCalcCtrlDetDto);

        }
    }
}
