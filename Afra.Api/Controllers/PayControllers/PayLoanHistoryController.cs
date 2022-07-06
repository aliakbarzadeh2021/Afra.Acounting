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

namespace Afra.Api.Controllers.PayLoanHistoryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayLoanHistoryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayLoanHistoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayLoanHistoryCommand command)
        {
            command.Validate();

            var PayLoanHistorys = await _unitOfWork.PayLoanHistoryRepository.FindAsync(c => c.Id == command.Id);

            if (PayLoanHistorys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayLoanHistory = Mapper.Map(command);
            await _unitOfWork.PayLoanHistoryRepository.AddAsync(newPayLoanHistory);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayLoanHistoryCommand command)
        {

            command.Validate();

            var PayLoanHistory = await _unitOfWork.PayLoanHistoryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayLoanHistory == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayLoanHistory = Mapper.Map(PayLoanHistory, command);
            PayLoanHistory.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayLoanHistory = await _unitOfWork.PayLoanHistoryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayLoanHistory == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayLoanHistory.IsActive = false;
            PayLoanHistory.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayLoanHistorys = await _unitOfWork.PayLoanHistoryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayLoanHistorysDto = Mapper.Map(PayLoanHistorys);

            return OkResult(CustomMessage.DefaultMessage, PayLoanHistorysDto.ToPagingAndSorting(query), PayLoanHistorysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayLoanHistory = await _unitOfWork.PayLoanHistoryRepository.GetByIdAsync(id);

            if (PayLoanHistory is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayLoanHistoryDto = Mapper.Map(PayLoanHistory);

            return OkResult( CustomMessage.DefaultMessage , PayLoanHistoryDto);

        }
    }
}
