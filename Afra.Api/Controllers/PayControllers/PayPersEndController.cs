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

namespace Afra.Api.Controllers.PayPersEndControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayPersEndController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayPersEndController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayPersEndCommand command)
        {
            command.Validate();

            var PayPersEnds = await _unitOfWork.PayPersEndRepository.FindAsync(c => c.Id == command.Id);

            if (PayPersEnds.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayPersEnd = Mapper.Map(command);
            await _unitOfWork.PayPersEndRepository.AddAsync(newPayPersEnd);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayPersEndCommand command)
        {

            command.Validate();

            var PayPersEnd = await _unitOfWork.PayPersEndRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayPersEnd == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayPersEnd = Mapper.Map(PayPersEnd, command);
            PayPersEnd.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayPersEnd = await _unitOfWork.PayPersEndRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayPersEnd == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayPersEnd.IsActive = false;
            PayPersEnd.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayPersEnds = await _unitOfWork.PayPersEndRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayPersEndsDto = Mapper.Map(PayPersEnds);

            return OkResult(CustomMessage.DefaultMessage, PayPersEndsDto.ToPagingAndSorting(query), PayPersEndsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayPersEnd = await _unitOfWork.PayPersEndRepository.GetByIdAsync(id);

            if (PayPersEnd is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayPersEndDto = Mapper.Map(PayPersEnd);

            return OkResult( CustomMessage.DefaultMessage , PayPersEndDto);

        }
    }
}
