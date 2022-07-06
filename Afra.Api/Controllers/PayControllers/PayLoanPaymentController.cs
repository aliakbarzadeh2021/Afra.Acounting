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

namespace Afra.Api.Controllers.PayLoanPaymentControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayLoanPaymentController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayLoanPaymentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayLoanPaymentCommand command)
        {
            command.Validate();

            var PayLoanPayments = await _unitOfWork.PayLoanPaymentRepository.FindAsync(c => c.Id == command.Id);

            if (PayLoanPayments.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayLoanPayment = Mapper.Map(command);
            await _unitOfWork.PayLoanPaymentRepository.AddAsync(newPayLoanPayment);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayLoanPaymentCommand command)
        {

            command.Validate();

            var PayLoanPayment = await _unitOfWork.PayLoanPaymentRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayLoanPayment == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayLoanPayment = Mapper.Map(PayLoanPayment, command);
            PayLoanPayment.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayLoanPayment = await _unitOfWork.PayLoanPaymentRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayLoanPayment == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayLoanPayment.IsActive = false;
            PayLoanPayment.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayLoanPayments = await _unitOfWork.PayLoanPaymentRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayLoanPaymentsDto = Mapper.Map(PayLoanPayments);

            return OkResult(CustomMessage.DefaultMessage, PayLoanPaymentsDto.ToPagingAndSorting(query), PayLoanPaymentsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayLoanPayment = await _unitOfWork.PayLoanPaymentRepository.GetByIdAsync(id);

            if (PayLoanPayment is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayLoanPaymentDto = Mapper.Map(PayLoanPayment);

            return OkResult( CustomMessage.DefaultMessage , PayLoanPaymentDto);

        }
    }
}
