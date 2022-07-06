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

namespace Afra.Api.Controllers.SettingsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SettingsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SettingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSettingsCommand command)
        {
            command.Validate();

            var Settingss = await _unitOfWork.SettingsRepository.FindAsync(c => c.Id == command.Id);

            if (Settingss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSettings = Mapper.Map(command);
            await _unitOfWork.SettingsRepository.AddAsync(newSettings);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSettingsCommand command)
        {

            command.Validate();

            var Settings = await _unitOfWork.SettingsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Settings == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Settings = Mapper.Map(Settings, command);
            Settings.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Settings = await _unitOfWork.SettingsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Settings == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Settings.IsActive = false;
            Settings.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Settingss = await _unitOfWork.SettingsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SettingssDto = Mapper.Map(Settingss);

            return OkResult(CustomMessage.DefaultMessage, SettingssDto.ToPagingAndSorting(query), SettingssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Settings = await _unitOfWork.SettingsRepository.GetByIdAsync(id);

            if (Settings is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SettingsDto = Mapper.Map(Settings);

            return OkResult( CustomMessage.DefaultMessage , SettingsDto);

        }
    }
}
