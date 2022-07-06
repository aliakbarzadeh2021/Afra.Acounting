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

namespace Afra.Api.Controllers.SMSOperateDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SMSOperateDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SMSOperateDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSMSOperateDetCommand command)
        {
            command.Validate();

            var SMSOperateDets = await _unitOfWork.SMSOperateDetRepository.FindAsync(c => c.Id == command.Id);

            if (SMSOperateDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSMSOperateDet = Mapper.Map(command);
            await _unitOfWork.SMSOperateDetRepository.AddAsync(newSMSOperateDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSMSOperateDetCommand command)
        {

            command.Validate();

            var SMSOperateDet = await _unitOfWork.SMSOperateDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SMSOperateDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SMSOperateDet = Mapper.Map(SMSOperateDet, command);
            SMSOperateDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SMSOperateDet = await _unitOfWork.SMSOperateDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SMSOperateDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SMSOperateDet.IsActive = false;
            SMSOperateDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SMSOperateDets = await _unitOfWork.SMSOperateDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SMSOperateDetsDto = Mapper.Map(SMSOperateDets);

            return OkResult(CustomMessage.DefaultMessage, SMSOperateDetsDto.ToPagingAndSorting(query), SMSOperateDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SMSOperateDet = await _unitOfWork.SMSOperateDetRepository.GetByIdAsync(id);

            if (SMSOperateDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SMSOperateDetDto = Mapper.Map(SMSOperateDet);

            return OkResult( CustomMessage.DefaultMessage , SMSOperateDetDto);

        }
    }
}
