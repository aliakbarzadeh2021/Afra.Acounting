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

namespace Afra.Api.Controllers.GnrAlarmDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrAlarmDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrAlarmDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrAlarmDetCommand command)
        {
            command.Validate();

            var GnrAlarmDets = await _unitOfWork.GnrAlarmDetRepository.FindAsync(c => c.Id == command.Id);

            if (GnrAlarmDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrAlarmDet = Mapper.Map(command);
            await _unitOfWork.GnrAlarmDetRepository.AddAsync(newGnrAlarmDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrAlarmDetCommand command)
        {

            command.Validate();

            var GnrAlarmDet = await _unitOfWork.GnrAlarmDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrAlarmDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrAlarmDet = Mapper.Map(GnrAlarmDet, command);
            GnrAlarmDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrAlarmDet = await _unitOfWork.GnrAlarmDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrAlarmDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrAlarmDet.IsActive = false;
            GnrAlarmDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrAlarmDets = await _unitOfWork.GnrAlarmDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrAlarmDetsDto = Mapper.Map(GnrAlarmDets);

            return OkResult(CustomMessage.DefaultMessage, GnrAlarmDetsDto.ToPagingAndSorting(query), GnrAlarmDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrAlarmDet = await _unitOfWork.GnrAlarmDetRepository.GetByIdAsync(id);

            if (GnrAlarmDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrAlarmDetDto = Mapper.Map(GnrAlarmDet);

            return OkResult( CustomMessage.DefaultMessage , GnrAlarmDetDto);

        }
    }
}
