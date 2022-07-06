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

namespace Afra.Api.Controllers.PayGrpLoanControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayGrpLoanController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayGrpLoanController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayGrpLoanCommand command)
        {
            command.Validate();

            var PayGrpLoans = await _unitOfWork.PayGrpLoanRepository.FindAsync(c => c.Id == command.Id);

            if (PayGrpLoans.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayGrpLoan = Mapper.Map(command);
            await _unitOfWork.PayGrpLoanRepository.AddAsync(newPayGrpLoan);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayGrpLoanCommand command)
        {

            command.Validate();

            var PayGrpLoan = await _unitOfWork.PayGrpLoanRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayGrpLoan == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayGrpLoan = Mapper.Map(PayGrpLoan, command);
            PayGrpLoan.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayGrpLoan = await _unitOfWork.PayGrpLoanRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayGrpLoan == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayGrpLoan.IsActive = false;
            PayGrpLoan.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayGrpLoans = await _unitOfWork.PayGrpLoanRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayGrpLoansDto = Mapper.Map(PayGrpLoans);

            return OkResult(CustomMessage.DefaultMessage, PayGrpLoansDto.ToPagingAndSorting(query), PayGrpLoansDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayGrpLoan = await _unitOfWork.PayGrpLoanRepository.GetByIdAsync(id);

            if (PayGrpLoan is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayGrpLoanDto = Mapper.Map(PayGrpLoan);

            return OkResult( CustomMessage.DefaultMessage , PayGrpLoanDto);

        }
    }
}
