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

namespace Afra.Api.Controllers.PayVacRemainControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayVacRemainController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayVacRemainController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayVacRemainCommand command)
        {
            command.Validate();

            var PayVacRemains = await _unitOfWork.PayVacRemainRepository.FindAsync(c => c.Id == command.Id);

            if (PayVacRemains.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayVacRemain = Mapper.Map(command);
            await _unitOfWork.PayVacRemainRepository.AddAsync(newPayVacRemain);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayVacRemainCommand command)
        {

            command.Validate();

            var PayVacRemain = await _unitOfWork.PayVacRemainRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayVacRemain == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayVacRemain = Mapper.Map(PayVacRemain, command);
            PayVacRemain.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayVacRemain = await _unitOfWork.PayVacRemainRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayVacRemain == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayVacRemain.IsActive = false;
            PayVacRemain.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayVacRemains = await _unitOfWork.PayVacRemainRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayVacRemainsDto = Mapper.Map(PayVacRemains);

            return OkResult(CustomMessage.DefaultMessage, PayVacRemainsDto.ToPagingAndSorting(query), PayVacRemainsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayVacRemain = await _unitOfWork.PayVacRemainRepository.GetByIdAsync(id);

            if (PayVacRemain is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayVacRemainDto = Mapper.Map(PayVacRemain);

            return OkResult( CustomMessage.DefaultMessage , PayVacRemainDto);

        }
    }
}
