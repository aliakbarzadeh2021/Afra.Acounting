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

namespace Afra.Api.Controllers.GnrAlarmTypesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrAlarmTypesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrAlarmTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrAlarmTypesCommand command)
        {
            command.Validate();

            var GnrAlarmTypess = await _unitOfWork.GnrAlarmTypesRepository.FindAsync(c => c.Id == command.Id);

            if (GnrAlarmTypess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrAlarmTypes = Mapper.Map(command);
            await _unitOfWork.GnrAlarmTypesRepository.AddAsync(newGnrAlarmTypes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrAlarmTypesCommand command)
        {

            command.Validate();

            var GnrAlarmTypes = await _unitOfWork.GnrAlarmTypesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrAlarmTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrAlarmTypes = Mapper.Map(GnrAlarmTypes, command);
            GnrAlarmTypes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrAlarmTypes = await _unitOfWork.GnrAlarmTypesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrAlarmTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrAlarmTypes.IsActive = false;
            GnrAlarmTypes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrAlarmTypess = await _unitOfWork.GnrAlarmTypesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrAlarmTypessDto = Mapper.Map(GnrAlarmTypess);

            return OkResult(CustomMessage.DefaultMessage, GnrAlarmTypessDto.ToPagingAndSorting(query), GnrAlarmTypessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrAlarmTypes = await _unitOfWork.GnrAlarmTypesRepository.GetByIdAsync(id);

            if (GnrAlarmTypes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrAlarmTypesDto = Mapper.Map(GnrAlarmTypes);

            return OkResult( CustomMessage.DefaultMessage , GnrAlarmTypesDto);

        }
    }
}
