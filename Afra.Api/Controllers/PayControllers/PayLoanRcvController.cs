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

namespace Afra.Api.Controllers.PayLoanRcvControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayLoanRcvController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayLoanRcvController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayLoanRcvCommand command)
        {
            command.Validate();

            var PayLoanRcvs = await _unitOfWork.PayLoanRcvRepository.FindAsync(c => c.Id == command.Id);

            if (PayLoanRcvs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayLoanRcv = Mapper.Map(command);
            await _unitOfWork.PayLoanRcvRepository.AddAsync(newPayLoanRcv);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayLoanRcvCommand command)
        {

            command.Validate();

            var PayLoanRcv = await _unitOfWork.PayLoanRcvRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayLoanRcv == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayLoanRcv = Mapper.Map(PayLoanRcv, command);
            PayLoanRcv.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayLoanRcv = await _unitOfWork.PayLoanRcvRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayLoanRcv == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayLoanRcv.IsActive = false;
            PayLoanRcv.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayLoanRcvs = await _unitOfWork.PayLoanRcvRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayLoanRcvsDto = Mapper.Map(PayLoanRcvs);

            return OkResult(CustomMessage.DefaultMessage, PayLoanRcvsDto.ToPagingAndSorting(query), PayLoanRcvsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayLoanRcv = await _unitOfWork.PayLoanRcvRepository.GetByIdAsync(id);

            if (PayLoanRcv is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayLoanRcvDto = Mapper.Map(PayLoanRcv);

            return OkResult( CustomMessage.DefaultMessage , PayLoanRcvDto);

        }
    }
}
