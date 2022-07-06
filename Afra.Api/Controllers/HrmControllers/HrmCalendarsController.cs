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

namespace Afra.Api.Controllers.HrmCalendarsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmCalendarsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmCalendarsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmCalendarsCommand command)
        {
            command.Validate();

            var HrmCalendarss = await _unitOfWork.HrmCalendarsRepository.FindAsync(c => c.Id == command.Id);

            if (HrmCalendarss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmCalendars = Mapper.Map(command);
            await _unitOfWork.HrmCalendarsRepository.AddAsync(newHrmCalendars);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmCalendarsCommand command)
        {

            command.Validate();

            var HrmCalendars = await _unitOfWork.HrmCalendarsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmCalendars == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmCalendars = Mapper.Map(HrmCalendars, command);
            HrmCalendars.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmCalendars = await _unitOfWork.HrmCalendarsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmCalendars == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmCalendars.IsActive = false;
            HrmCalendars.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmCalendarss = await _unitOfWork.HrmCalendarsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmCalendarssDto = Mapper.Map(HrmCalendarss);

            return OkResult(CustomMessage.DefaultMessage, HrmCalendarssDto.ToPagingAndSorting(query), HrmCalendarssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmCalendars = await _unitOfWork.HrmCalendarsRepository.GetByIdAsync(id);

            if (HrmCalendars is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmCalendarsDto = Mapper.Map(HrmCalendars);

            return OkResult( CustomMessage.DefaultMessage , HrmCalendarsDto);

        }
    }
}
