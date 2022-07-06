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

namespace Afra.Api.Controllers.PayCalcValsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayCalcValsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayCalcValsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayCalcValsCommand command)
        {
            command.Validate();

            var PayCalcValss = await _unitOfWork.PayCalcValsRepository.FindAsync(c => c.Id == command.Id);

            if (PayCalcValss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayCalcVals = Mapper.Map(command);
            await _unitOfWork.PayCalcValsRepository.AddAsync(newPayCalcVals);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayCalcValsCommand command)
        {

            command.Validate();

            var PayCalcVals = await _unitOfWork.PayCalcValsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayCalcVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayCalcVals = Mapper.Map(PayCalcVals, command);
            PayCalcVals.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayCalcVals = await _unitOfWork.PayCalcValsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayCalcVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayCalcVals.IsActive = false;
            PayCalcVals.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayCalcValss = await _unitOfWork.PayCalcValsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayCalcValssDto = Mapper.Map(PayCalcValss);

            return OkResult(CustomMessage.DefaultMessage, PayCalcValssDto.ToPagingAndSorting(query), PayCalcValssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayCalcVals = await _unitOfWork.PayCalcValsRepository.GetByIdAsync(id);

            if (PayCalcVals is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayCalcValsDto = Mapper.Map(PayCalcVals);

            return OkResult( CustomMessage.DefaultMessage , PayCalcValsDto);

        }
    }
}
