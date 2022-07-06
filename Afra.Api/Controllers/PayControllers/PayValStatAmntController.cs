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

namespace Afra.Api.Controllers.PayValStatAmntControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayValStatAmntController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayValStatAmntController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayValStatAmntCommand command)
        {
            command.Validate();

            var PayValStatAmnts = await _unitOfWork.PayValStatAmntRepository.FindAsync(c => c.Id == command.Id);

            if (PayValStatAmnts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayValStatAmnt = Mapper.Map(command);
            await _unitOfWork.PayValStatAmntRepository.AddAsync(newPayValStatAmnt);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayValStatAmntCommand command)
        {

            command.Validate();

            var PayValStatAmnt = await _unitOfWork.PayValStatAmntRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayValStatAmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayValStatAmnt = Mapper.Map(PayValStatAmnt, command);
            PayValStatAmnt.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayValStatAmnt = await _unitOfWork.PayValStatAmntRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayValStatAmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayValStatAmnt.IsActive = false;
            PayValStatAmnt.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayValStatAmnts = await _unitOfWork.PayValStatAmntRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayValStatAmntsDto = Mapper.Map(PayValStatAmnts);

            return OkResult(CustomMessage.DefaultMessage, PayValStatAmntsDto.ToPagingAndSorting(query), PayValStatAmntsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayValStatAmnt = await _unitOfWork.PayValStatAmntRepository.GetByIdAsync(id);

            if (PayValStatAmnt is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayValStatAmntDto = Mapper.Map(PayValStatAmnt);

            return OkResult( CustomMessage.DefaultMessage , PayValStatAmntDto);

        }
    }
}
