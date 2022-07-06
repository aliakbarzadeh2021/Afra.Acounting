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

namespace Afra.Api.Controllers.GnrUserAlarmsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrUserAlarmsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrUserAlarmsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrUserAlarmsCommand command)
        {
            command.Validate();

            var GnrUserAlarmss = await _unitOfWork.GnrUserAlarmsRepository.FindAsync(c => c.Id == command.Id);

            if (GnrUserAlarmss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrUserAlarms = Mapper.Map(command);
            await _unitOfWork.GnrUserAlarmsRepository.AddAsync(newGnrUserAlarms);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrUserAlarmsCommand command)
        {

            command.Validate();

            var GnrUserAlarms = await _unitOfWork.GnrUserAlarmsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrUserAlarms == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserAlarms = Mapper.Map(GnrUserAlarms, command);
            GnrUserAlarms.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrUserAlarms = await _unitOfWork.GnrUserAlarmsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrUserAlarms == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserAlarms.IsActive = false;
            GnrUserAlarms.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrUserAlarmss = await _unitOfWork.GnrUserAlarmsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrUserAlarmssDto = Mapper.Map(GnrUserAlarmss);

            return OkResult(CustomMessage.DefaultMessage, GnrUserAlarmssDto.ToPagingAndSorting(query), GnrUserAlarmssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrUserAlarms = await _unitOfWork.GnrUserAlarmsRepository.GetByIdAsync(id);

            if (GnrUserAlarms is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrUserAlarmsDto = Mapper.Map(GnrUserAlarms);

            return OkResult( CustomMessage.DefaultMessage , GnrUserAlarmsDto);

        }
    }
}
