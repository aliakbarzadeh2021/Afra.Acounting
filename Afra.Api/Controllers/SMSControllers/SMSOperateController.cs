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

namespace Afra.Api.Controllers.SMSOperateControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SMSOperateController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SMSOperateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSMSOperateCommand command)
        {
            command.Validate();

            var SMSOperates = await _unitOfWork.SMSOperateRepository.FindAsync(c => c.Id == command.Id);

            if (SMSOperates.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSMSOperate = Mapper.Map(command);
            await _unitOfWork.SMSOperateRepository.AddAsync(newSMSOperate);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSMSOperateCommand command)
        {

            command.Validate();

            var SMSOperate = await _unitOfWork.SMSOperateRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SMSOperate == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SMSOperate = Mapper.Map(SMSOperate, command);
            SMSOperate.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SMSOperate = await _unitOfWork.SMSOperateRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SMSOperate == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SMSOperate.IsActive = false;
            SMSOperate.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SMSOperates = await _unitOfWork.SMSOperateRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SMSOperatesDto = Mapper.Map(SMSOperates);

            return OkResult(CustomMessage.DefaultMessage, SMSOperatesDto.ToPagingAndSorting(query), SMSOperatesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SMSOperate = await _unitOfWork.SMSOperateRepository.GetByIdAsync(id);

            if (SMSOperate is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SMSOperateDto = Mapper.Map(SMSOperate);

            return OkResult( CustomMessage.DefaultMessage , SMSOperateDto);

        }
    }
}
