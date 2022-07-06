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

namespace Afra.Api.Controllers.PayMonthlyValsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayMonthlyValsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayMonthlyValsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayMonthlyValsCommand command)
        {
            command.Validate();

            var PayMonthlyValss = await _unitOfWork.PayMonthlyValsRepository.FindAsync(c => c.Id == command.Id);

            if (PayMonthlyValss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayMonthlyVals = Mapper.Map(command);
            await _unitOfWork.PayMonthlyValsRepository.AddAsync(newPayMonthlyVals);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayMonthlyValsCommand command)
        {

            command.Validate();

            var PayMonthlyVals = await _unitOfWork.PayMonthlyValsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayMonthlyVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayMonthlyVals = Mapper.Map(PayMonthlyVals, command);
            PayMonthlyVals.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayMonthlyVals = await _unitOfWork.PayMonthlyValsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayMonthlyVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayMonthlyVals.IsActive = false;
            PayMonthlyVals.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayMonthlyValss = await _unitOfWork.PayMonthlyValsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayMonthlyValssDto = Mapper.Map(PayMonthlyValss);

            return OkResult(CustomMessage.DefaultMessage, PayMonthlyValssDto.ToPagingAndSorting(query), PayMonthlyValssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayMonthlyVals = await _unitOfWork.PayMonthlyValsRepository.GetByIdAsync(id);

            if (PayMonthlyVals is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayMonthlyValsDto = Mapper.Map(PayMonthlyVals);

            return OkResult( CustomMessage.DefaultMessage , PayMonthlyValsDto);

        }
    }
}
