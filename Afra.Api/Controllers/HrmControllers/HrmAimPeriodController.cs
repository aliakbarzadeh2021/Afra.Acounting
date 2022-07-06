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

namespace Afra.Api.Controllers.HrmAimPeriodControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmAimPeriodController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmAimPeriodController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmAimPeriodCommand command)
        {
            command.Validate();

            var HrmAimPeriods = await _unitOfWork.HrmAimPeriodRepository.FindAsync(c => c.Id == command.Id);

            if (HrmAimPeriods.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmAimPeriod = Mapper.Map(command);
            await _unitOfWork.HrmAimPeriodRepository.AddAsync(newHrmAimPeriod);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmAimPeriodCommand command)
        {

            command.Validate();

            var HrmAimPeriod = await _unitOfWork.HrmAimPeriodRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmAimPeriod == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmAimPeriod = Mapper.Map(HrmAimPeriod, command);
            HrmAimPeriod.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmAimPeriod = await _unitOfWork.HrmAimPeriodRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmAimPeriod == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmAimPeriod.IsActive = false;
            HrmAimPeriod.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmAimPeriods = await _unitOfWork.HrmAimPeriodRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmAimPeriodsDto = Mapper.Map(HrmAimPeriods);

            return OkResult(CustomMessage.DefaultMessage, HrmAimPeriodsDto.ToPagingAndSorting(query), HrmAimPeriodsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmAimPeriod = await _unitOfWork.HrmAimPeriodRepository.GetByIdAsync(id);

            if (HrmAimPeriod is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmAimPeriodDto = Mapper.Map(HrmAimPeriod);

            return OkResult( CustomMessage.DefaultMessage , HrmAimPeriodDto);

        }
    }
}
