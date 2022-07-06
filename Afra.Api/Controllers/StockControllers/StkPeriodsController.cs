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

namespace Afra.Api.Controllers.StkPeriodsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class StkPeriodsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StkPeriodsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddStkPeriodsCommand command)
        {
            command.Validate();

            var StkPeriodss = await _unitOfWork.StkPeriodsRepository.FindAsync(c => c.Id == command.Id);

            if (StkPeriodss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newStkPeriods = Mapper.Map(command);
            await _unitOfWork.StkPeriodsRepository.AddAsync(newStkPeriods);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditStkPeriodsCommand command)
        {

            command.Validate();

            var StkPeriods = await _unitOfWork.StkPeriodsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (StkPeriods == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StkPeriods = Mapper.Map(StkPeriods, command);
            StkPeriods.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var StkPeriods = await _unitOfWork.StkPeriodsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (StkPeriods == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StkPeriods.IsActive = false;
            StkPeriods.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var StkPeriodss = await _unitOfWork.StkPeriodsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var StkPeriodssDto = Mapper.Map(StkPeriodss);

            return OkResult(CustomMessage.DefaultMessage, StkPeriodssDto.ToPagingAndSorting(query), StkPeriodssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var StkPeriods = await _unitOfWork.StkPeriodsRepository.GetByIdAsync(id);

            if (StkPeriods is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var StkPeriodsDto = Mapper.Map(StkPeriods);

            return OkResult( CustomMessage.DefaultMessage , StkPeriodsDto);

        }
    }
}
