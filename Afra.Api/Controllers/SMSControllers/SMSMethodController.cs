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

namespace Afra.Api.Controllers.SMSMethodControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SMSMethodController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SMSMethodController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSMSMethodCommand command)
        {
            command.Validate();

            var SMSMethods = await _unitOfWork.SMSMethodRepository.FindAsync(c => c.Id == command.Id);

            if (SMSMethods.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSMSMethod = Mapper.Map(command);
            await _unitOfWork.SMSMethodRepository.AddAsync(newSMSMethod);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSMSMethodCommand command)
        {

            command.Validate();

            var SMSMethod = await _unitOfWork.SMSMethodRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SMSMethod == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SMSMethod = Mapper.Map(SMSMethod, command);
            SMSMethod.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SMSMethod = await _unitOfWork.SMSMethodRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SMSMethod == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SMSMethod.IsActive = false;
            SMSMethod.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SMSMethods = await _unitOfWork.SMSMethodRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SMSMethodsDto = Mapper.Map(SMSMethods);

            return OkResult(CustomMessage.DefaultMessage, SMSMethodsDto.ToPagingAndSorting(query), SMSMethodsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SMSMethod = await _unitOfWork.SMSMethodRepository.GetByIdAsync(id);

            if (SMSMethod is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SMSMethodDto = Mapper.Map(SMSMethod);

            return OkResult( CustomMessage.DefaultMessage , SMSMethodDto);

        }
    }
}
