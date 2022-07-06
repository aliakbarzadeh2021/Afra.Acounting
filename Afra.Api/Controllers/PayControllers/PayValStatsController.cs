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

namespace Afra.Api.Controllers.PayValStatsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayValStatsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayValStatsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayValStatsCommand command)
        {
            command.Validate();

            var PayValStatss = await _unitOfWork.PayValStatsRepository.FindAsync(c => c.Id == command.Id);

            if (PayValStatss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayValStats = Mapper.Map(command);
            await _unitOfWork.PayValStatsRepository.AddAsync(newPayValStats);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayValStatsCommand command)
        {

            command.Validate();

            var PayValStats = await _unitOfWork.PayValStatsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayValStats == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayValStats = Mapper.Map(PayValStats, command);
            PayValStats.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayValStats = await _unitOfWork.PayValStatsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayValStats == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayValStats.IsActive = false;
            PayValStats.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayValStatss = await _unitOfWork.PayValStatsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayValStatssDto = Mapper.Map(PayValStatss);

            return OkResult(CustomMessage.DefaultMessage, PayValStatssDto.ToPagingAndSorting(query), PayValStatssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayValStats = await _unitOfWork.PayValStatsRepository.GetByIdAsync(id);

            if (PayValStats is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayValStatsDto = Mapper.Map(PayValStats);

            return OkResult( CustomMessage.DefaultMessage , PayValStatsDto);

        }
    }
}
