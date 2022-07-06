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

namespace Afra.Api.Controllers.PayBdgValsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayBdgValsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayBdgValsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayBdgValsCommand command)
        {
            command.Validate();

            var PayBdgValss = await _unitOfWork.PayBdgValsRepository.FindAsync(c => c.Id == command.Id);

            if (PayBdgValss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayBdgVals = Mapper.Map(command);
            await _unitOfWork.PayBdgValsRepository.AddAsync(newPayBdgVals);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayBdgValsCommand command)
        {

            command.Validate();

            var PayBdgVals = await _unitOfWork.PayBdgValsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayBdgVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayBdgVals = Mapper.Map(PayBdgVals, command);
            PayBdgVals.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayBdgVals = await _unitOfWork.PayBdgValsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayBdgVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayBdgVals.IsActive = false;
            PayBdgVals.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayBdgValss = await _unitOfWork.PayBdgValsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayBdgValssDto = Mapper.Map(PayBdgValss);

            return OkResult(CustomMessage.DefaultMessage, PayBdgValssDto.ToPagingAndSorting(query), PayBdgValssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayBdgVals = await _unitOfWork.PayBdgValsRepository.GetByIdAsync(id);

            if (PayBdgVals is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayBdgValsDto = Mapper.Map(PayBdgVals);

            return OkResult( CustomMessage.DefaultMessage , PayBdgValsDto);

        }
    }
}
