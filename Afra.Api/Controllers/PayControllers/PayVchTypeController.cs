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

namespace Afra.Api.Controllers.PayVchTypeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayVchTypeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayVchTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayVchTypeCommand command)
        {
            command.Validate();

            var PayVchTypes = await _unitOfWork.PayVchTypeRepository.FindAsync(c => c.Id == command.Id);

            if (PayVchTypes.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayVchType = Mapper.Map(command);
            await _unitOfWork.PayVchTypeRepository.AddAsync(newPayVchType);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayVchTypeCommand command)
        {

            command.Validate();

            var PayVchType = await _unitOfWork.PayVchTypeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayVchType == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayVchType = Mapper.Map(PayVchType, command);
            PayVchType.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayVchType = await _unitOfWork.PayVchTypeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayVchType == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayVchType.IsActive = false;
            PayVchType.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayVchTypes = await _unitOfWork.PayVchTypeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayVchTypesDto = Mapper.Map(PayVchTypes);

            return OkResult(CustomMessage.DefaultMessage, PayVchTypesDto.ToPagingAndSorting(query), PayVchTypesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayVchType = await _unitOfWork.PayVchTypeRepository.GetByIdAsync(id);

            if (PayVchType is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayVchTypeDto = Mapper.Map(PayVchType);

            return OkResult( CustomMessage.DefaultMessage , PayVchTypeDto);

        }
    }
}
