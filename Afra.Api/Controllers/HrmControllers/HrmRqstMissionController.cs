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

namespace Afra.Api.Controllers.HrmRqstMissionControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmRqstMissionController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmRqstMissionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmRqstMissionCommand command)
        {
            command.Validate();

            var HrmRqstMissions = await _unitOfWork.HrmRqstMissionRepository.FindAsync(c => c.Id == command.Id);

            if (HrmRqstMissions.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmRqstMission = Mapper.Map(command);
            await _unitOfWork.HrmRqstMissionRepository.AddAsync(newHrmRqstMission);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmRqstMissionCommand command)
        {

            command.Validate();

            var HrmRqstMission = await _unitOfWork.HrmRqstMissionRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmRqstMission == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmRqstMission = Mapper.Map(HrmRqstMission, command);
            HrmRqstMission.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmRqstMission = await _unitOfWork.HrmRqstMissionRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmRqstMission == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmRqstMission.IsActive = false;
            HrmRqstMission.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmRqstMissions = await _unitOfWork.HrmRqstMissionRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmRqstMissionsDto = Mapper.Map(HrmRqstMissions);

            return OkResult(CustomMessage.DefaultMessage, HrmRqstMissionsDto.ToPagingAndSorting(query), HrmRqstMissionsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmRqstMission = await _unitOfWork.HrmRqstMissionRepository.GetByIdAsync(id);

            if (HrmRqstMission is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmRqstMissionDto = Mapper.Map(HrmRqstMission);

            return OkResult( CustomMessage.DefaultMessage , HrmRqstMissionDto);

        }
    }
}
