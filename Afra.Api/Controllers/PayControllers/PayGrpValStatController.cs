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

namespace Afra.Api.Controllers.PayGrpValStatControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayGrpValStatController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayGrpValStatController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayGrpValStatCommand command)
        {
            command.Validate();

            var PayGrpValStats = await _unitOfWork.PayGrpValStatRepository.FindAsync(c => c.Id == command.Id);

            if (PayGrpValStats.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayGrpValStat = Mapper.Map(command);
            await _unitOfWork.PayGrpValStatRepository.AddAsync(newPayGrpValStat);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayGrpValStatCommand command)
        {

            command.Validate();

            var PayGrpValStat = await _unitOfWork.PayGrpValStatRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayGrpValStat == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayGrpValStat = Mapper.Map(PayGrpValStat, command);
            PayGrpValStat.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayGrpValStat = await _unitOfWork.PayGrpValStatRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayGrpValStat == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayGrpValStat.IsActive = false;
            PayGrpValStat.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayGrpValStats = await _unitOfWork.PayGrpValStatRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayGrpValStatsDto = Mapper.Map(PayGrpValStats);

            return OkResult(CustomMessage.DefaultMessage, PayGrpValStatsDto.ToPagingAndSorting(query), PayGrpValStatsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayGrpValStat = await _unitOfWork.PayGrpValStatRepository.GetByIdAsync(id);

            if (PayGrpValStat is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayGrpValStatDto = Mapper.Map(PayGrpValStat);

            return OkResult( CustomMessage.DefaultMessage , PayGrpValStatDto);

        }
    }
}
