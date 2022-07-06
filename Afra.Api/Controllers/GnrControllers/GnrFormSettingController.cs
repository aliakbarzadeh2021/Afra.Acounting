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

namespace Afra.Api.Controllers.GnrFormSettingControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrFormSettingController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrFormSettingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrFormSettingCommand command)
        {
            command.Validate();

            var GnrFormSettings = await _unitOfWork.GnrFormSettingRepository.FindAsync(c => c.Id == command.Id);

            if (GnrFormSettings.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrFormSetting = Mapper.Map(command);
            await _unitOfWork.GnrFormSettingRepository.AddAsync(newGnrFormSetting);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrFormSettingCommand command)
        {

            command.Validate();

            var GnrFormSetting = await _unitOfWork.GnrFormSettingRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrFormSetting == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrFormSetting = Mapper.Map(GnrFormSetting, command);
            GnrFormSetting.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrFormSetting = await _unitOfWork.GnrFormSettingRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrFormSetting == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrFormSetting.IsActive = false;
            GnrFormSetting.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrFormSettings = await _unitOfWork.GnrFormSettingRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrFormSettingsDto = Mapper.Map(GnrFormSettings);

            return OkResult(CustomMessage.DefaultMessage, GnrFormSettingsDto.ToPagingAndSorting(query), GnrFormSettingsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrFormSetting = await _unitOfWork.GnrFormSettingRepository.GetByIdAsync(id);

            if (GnrFormSetting is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrFormSettingDto = Mapper.Map(GnrFormSetting);

            return OkResult( CustomMessage.DefaultMessage , GnrFormSettingDto);

        }
    }
}
