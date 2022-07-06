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

namespace Afra.Api.Controllers.PayBdgStateControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayBdgStateController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayBdgStateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayBdgStateCommand command)
        {
            command.Validate();

            var PayBdgStates = await _unitOfWork.PayBdgStateRepository.FindAsync(c => c.Id == command.Id);

            if (PayBdgStates.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayBdgState = Mapper.Map(command);
            await _unitOfWork.PayBdgStateRepository.AddAsync(newPayBdgState);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayBdgStateCommand command)
        {

            command.Validate();

            var PayBdgState = await _unitOfWork.PayBdgStateRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayBdgState == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayBdgState = Mapper.Map(PayBdgState, command);
            PayBdgState.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayBdgState = await _unitOfWork.PayBdgStateRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayBdgState == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayBdgState.IsActive = false;
            PayBdgState.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayBdgStates = await _unitOfWork.PayBdgStateRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayBdgStatesDto = Mapper.Map(PayBdgStates);

            return OkResult(CustomMessage.DefaultMessage, PayBdgStatesDto.ToPagingAndSorting(query), PayBdgStatesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayBdgState = await _unitOfWork.PayBdgStateRepository.GetByIdAsync(id);

            if (PayBdgState is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayBdgStateDto = Mapper.Map(PayBdgState);

            return OkResult( CustomMessage.DefaultMessage , PayBdgStateDto);

        }
    }
}
