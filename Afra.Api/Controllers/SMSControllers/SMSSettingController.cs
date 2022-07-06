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

namespace Afra.Api.Controllers.SMSSettingControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SMSSettingController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SMSSettingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSMSSettingCommand command)
        {
            command.Validate();

            var SMSSettings = await _unitOfWork.SMSSettingRepository.FindAsync(c => c.Id == command.Id);

            if (SMSSettings.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSMSSetting = Mapper.Map(command);
            await _unitOfWork.SMSSettingRepository.AddAsync(newSMSSetting);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSMSSettingCommand command)
        {

            command.Validate();

            var SMSSetting = await _unitOfWork.SMSSettingRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SMSSetting == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SMSSetting = Mapper.Map(SMSSetting, command);
            SMSSetting.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SMSSetting = await _unitOfWork.SMSSettingRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SMSSetting == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SMSSetting.IsActive = false;
            SMSSetting.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SMSSettings = await _unitOfWork.SMSSettingRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SMSSettingsDto = Mapper.Map(SMSSettings);

            return OkResult(CustomMessage.DefaultMessage, SMSSettingsDto.ToPagingAndSorting(query), SMSSettingsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SMSSetting = await _unitOfWork.SMSSettingRepository.GetByIdAsync(id);

            if (SMSSetting is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SMSSettingDto = Mapper.Map(SMSSetting);

            return OkResult( CustomMessage.DefaultMessage , SMSSettingDto);

        }
    }
}
