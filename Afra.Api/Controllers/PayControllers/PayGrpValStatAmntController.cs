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

namespace Afra.Api.Controllers.PayGrpValStatAmntControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayGrpValStatAmntController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayGrpValStatAmntController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayGrpValStatAmntCommand command)
        {
            command.Validate();

            var PayGrpValStatAmnts = await _unitOfWork.PayGrpValStatAmntRepository.FindAsync(c => c.Id == command.Id);

            if (PayGrpValStatAmnts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayGrpValStatAmnt = Mapper.Map(command);
            await _unitOfWork.PayGrpValStatAmntRepository.AddAsync(newPayGrpValStatAmnt);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayGrpValStatAmntCommand command)
        {

            command.Validate();

            var PayGrpValStatAmnt = await _unitOfWork.PayGrpValStatAmntRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayGrpValStatAmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayGrpValStatAmnt = Mapper.Map(PayGrpValStatAmnt, command);
            PayGrpValStatAmnt.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayGrpValStatAmnt = await _unitOfWork.PayGrpValStatAmntRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayGrpValStatAmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayGrpValStatAmnt.IsActive = false;
            PayGrpValStatAmnt.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayGrpValStatAmnts = await _unitOfWork.PayGrpValStatAmntRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayGrpValStatAmntsDto = Mapper.Map(PayGrpValStatAmnts);

            return OkResult(CustomMessage.DefaultMessage, PayGrpValStatAmntsDto.ToPagingAndSorting(query), PayGrpValStatAmntsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayGrpValStatAmnt = await _unitOfWork.PayGrpValStatAmntRepository.GetByIdAsync(id);

            if (PayGrpValStatAmnt is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayGrpValStatAmntDto = Mapper.Map(PayGrpValStatAmnt);

            return OkResult( CustomMessage.DefaultMessage , PayGrpValStatAmntDto);

        }
    }
}
