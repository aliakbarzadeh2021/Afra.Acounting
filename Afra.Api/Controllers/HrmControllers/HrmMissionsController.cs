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

namespace Afra.Api.Controllers.HrmMissionsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmMissionsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmMissionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmMissionsCommand command)
        {
            command.Validate();

            var HrmMissionss = await _unitOfWork.HrmMissionsRepository.FindAsync(c => c.Id == command.Id);

            if (HrmMissionss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmMissions = Mapper.Map(command);
            await _unitOfWork.HrmMissionsRepository.AddAsync(newHrmMissions);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmMissionsCommand command)
        {

            command.Validate();

            var HrmMissions = await _unitOfWork.HrmMissionsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmMissions == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmMissions = Mapper.Map(HrmMissions, command);
            HrmMissions.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmMissions = await _unitOfWork.HrmMissionsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmMissions == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmMissions.IsActive = false;
            HrmMissions.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmMissionss = await _unitOfWork.HrmMissionsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmMissionssDto = Mapper.Map(HrmMissionss);

            return OkResult(CustomMessage.DefaultMessage, HrmMissionssDto.ToPagingAndSorting(query), HrmMissionssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmMissions = await _unitOfWork.HrmMissionsRepository.GetByIdAsync(id);

            if (HrmMissions is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmMissionsDto = Mapper.Map(HrmMissions);

            return OkResult( CustomMessage.DefaultMessage , HrmMissionsDto);

        }
    }
}
