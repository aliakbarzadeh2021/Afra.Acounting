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

namespace Afra.Api.Controllers.PayWorkLimitControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayWorkLimitController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayWorkLimitController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayWorkLimitCommand command)
        {
            command.Validate();

            var PayWorkLimits = await _unitOfWork.PayWorkLimitRepository.FindAsync(c => c.Id == command.Id);

            if (PayWorkLimits.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayWorkLimit = Mapper.Map(command);
            await _unitOfWork.PayWorkLimitRepository.AddAsync(newPayWorkLimit);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayWorkLimitCommand command)
        {

            command.Validate();

            var PayWorkLimit = await _unitOfWork.PayWorkLimitRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayWorkLimit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayWorkLimit = Mapper.Map(PayWorkLimit, command);
            PayWorkLimit.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayWorkLimit = await _unitOfWork.PayWorkLimitRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayWorkLimit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayWorkLimit.IsActive = false;
            PayWorkLimit.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayWorkLimits = await _unitOfWork.PayWorkLimitRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayWorkLimitsDto = Mapper.Map(PayWorkLimits);

            return OkResult(CustomMessage.DefaultMessage, PayWorkLimitsDto.ToPagingAndSorting(query), PayWorkLimitsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayWorkLimit = await _unitOfWork.PayWorkLimitRepository.GetByIdAsync(id);

            if (PayWorkLimit is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayWorkLimitDto = Mapper.Map(PayWorkLimit);

            return OkResult( CustomMessage.DefaultMessage , PayWorkLimitDto);

        }
    }
}
