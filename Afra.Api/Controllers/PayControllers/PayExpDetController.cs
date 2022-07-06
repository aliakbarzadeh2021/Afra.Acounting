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

namespace Afra.Api.Controllers.PayExpDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayExpDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayExpDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayExpDetCommand command)
        {
            command.Validate();

            var PayExpDets = await _unitOfWork.PayExpDetRepository.FindAsync(c => c.Id == command.Id);

            if (PayExpDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayExpDet = Mapper.Map(command);
            await _unitOfWork.PayExpDetRepository.AddAsync(newPayExpDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayExpDetCommand command)
        {

            command.Validate();

            var PayExpDet = await _unitOfWork.PayExpDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayExpDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayExpDet = Mapper.Map(PayExpDet, command);
            PayExpDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayExpDet = await _unitOfWork.PayExpDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayExpDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayExpDet.IsActive = false;
            PayExpDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayExpDets = await _unitOfWork.PayExpDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayExpDetsDto = Mapper.Map(PayExpDets);

            return OkResult(CustomMessage.DefaultMessage, PayExpDetsDto.ToPagingAndSorting(query), PayExpDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayExpDet = await _unitOfWork.PayExpDetRepository.GetByIdAsync(id);

            if (PayExpDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayExpDetDto = Mapper.Map(PayExpDet);

            return OkResult( CustomMessage.DefaultMessage , PayExpDetDto);

        }
    }
}
