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

namespace Afra.Api.Controllers.PayImpDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayImpDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayImpDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayImpDetCommand command)
        {
            command.Validate();

            var PayImpDets = await _unitOfWork.PayImpDetRepository.FindAsync(c => c.Id == command.Id);

            if (PayImpDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayImpDet = Mapper.Map(command);
            await _unitOfWork.PayImpDetRepository.AddAsync(newPayImpDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayImpDetCommand command)
        {

            command.Validate();

            var PayImpDet = await _unitOfWork.PayImpDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayImpDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayImpDet = Mapper.Map(PayImpDet, command);
            PayImpDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayImpDet = await _unitOfWork.PayImpDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayImpDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayImpDet.IsActive = false;
            PayImpDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayImpDets = await _unitOfWork.PayImpDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayImpDetsDto = Mapper.Map(PayImpDets);

            return OkResult(CustomMessage.DefaultMessage, PayImpDetsDto.ToPagingAndSorting(query), PayImpDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayImpDet = await _unitOfWork.PayImpDetRepository.GetByIdAsync(id);

            if (PayImpDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayImpDetDto = Mapper.Map(PayImpDet);

            return OkResult( CustomMessage.DefaultMessage , PayImpDetDto);

        }
    }
}
