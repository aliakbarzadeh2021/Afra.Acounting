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

namespace Afra.Api.Controllers.PayUserFieldControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayUserFieldController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayUserFieldController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayUserFieldCommand command)
        {
            command.Validate();

            var PayUserFields = await _unitOfWork.PayUserFieldRepository.FindAsync(c => c.Id == command.Id);

            if (PayUserFields.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayUserField = Mapper.Map(command);
            await _unitOfWork.PayUserFieldRepository.AddAsync(newPayUserField);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayUserFieldCommand command)
        {

            command.Validate();

            var PayUserField = await _unitOfWork.PayUserFieldRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayUserField == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayUserField = Mapper.Map(PayUserField, command);
            PayUserField.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayUserField = await _unitOfWork.PayUserFieldRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayUserField == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayUserField.IsActive = false;
            PayUserField.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayUserFields = await _unitOfWork.PayUserFieldRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayUserFieldsDto = Mapper.Map(PayUserFields);

            return OkResult(CustomMessage.DefaultMessage, PayUserFieldsDto.ToPagingAndSorting(query), PayUserFieldsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayUserField = await _unitOfWork.PayUserFieldRepository.GetByIdAsync(id);

            if (PayUserField is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayUserFieldDto = Mapper.Map(PayUserField);

            return OkResult( CustomMessage.DefaultMessage , PayUserFieldDto);

        }
    }
}
