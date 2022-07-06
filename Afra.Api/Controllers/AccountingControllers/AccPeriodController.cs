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

namespace Afra.Api.Controllers.AccPeriodControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccPeriodController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccPeriodController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccPeriodCommand command)
        {
            command.Validate();

            var AccPeriods = await _unitOfWork.AccPeriodRepository.FindAsync(c => c.Id == command.Id);

            if (AccPeriods.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccPeriod = Mapper.Map(command);
            await _unitOfWork.AccPeriodRepository.AddAsync(newAccPeriod);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccPeriodCommand command)
        {

            command.Validate();

            var AccPeriod = await _unitOfWork.AccPeriodRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccPeriod == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccPeriod = Mapper.Map(AccPeriod, command);
            AccPeriod.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccPeriod = await _unitOfWork.AccPeriodRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccPeriod == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccPeriod.IsActive = false;
            AccPeriod.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccPeriods = await _unitOfWork.AccPeriodRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccPeriodsDto = Mapper.Map(AccPeriods);

            return OkResult(CustomMessage.DefaultMessage, AccPeriodsDto.ToPagingAndSorting(query), AccPeriodsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccPeriod = await _unitOfWork.AccPeriodRepository.GetByIdAsync(id);

            if (AccPeriod is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccPeriodDto = Mapper.Map(AccPeriod);

            return OkResult( CustomMessage.DefaultMessage , AccPeriodDto);

        }
    }
}
