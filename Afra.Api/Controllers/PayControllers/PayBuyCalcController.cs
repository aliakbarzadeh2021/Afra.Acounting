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

namespace Afra.Api.Controllers.PayBuyCalcControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayBuyCalcController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayBuyCalcController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayBuyCalcCommand command)
        {
            command.Validate();

            var PayBuyCalcs = await _unitOfWork.PayBuyCalcRepository.FindAsync(c => c.Id == command.Id);

            if (PayBuyCalcs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayBuyCalc = Mapper.Map(command);
            await _unitOfWork.PayBuyCalcRepository.AddAsync(newPayBuyCalc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayBuyCalcCommand command)
        {

            command.Validate();

            var PayBuyCalc = await _unitOfWork.PayBuyCalcRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayBuyCalc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayBuyCalc = Mapper.Map(PayBuyCalc, command);
            PayBuyCalc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayBuyCalc = await _unitOfWork.PayBuyCalcRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayBuyCalc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayBuyCalc.IsActive = false;
            PayBuyCalc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayBuyCalcs = await _unitOfWork.PayBuyCalcRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayBuyCalcsDto = Mapper.Map(PayBuyCalcs);

            return OkResult(CustomMessage.DefaultMessage, PayBuyCalcsDto.ToPagingAndSorting(query), PayBuyCalcsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayBuyCalc = await _unitOfWork.PayBuyCalcRepository.GetByIdAsync(id);

            if (PayBuyCalc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayBuyCalcDto = Mapper.Map(PayBuyCalc);

            return OkResult( CustomMessage.DefaultMessage , PayBuyCalcDto);

        }
    }
}
