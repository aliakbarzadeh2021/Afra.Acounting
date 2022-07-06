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

namespace Afra.Api.Controllers.PayCalcStateControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayCalcStateController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayCalcStateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayCalcStateCommand command)
        {
            command.Validate();

            var PayCalcStates = await _unitOfWork.PayCalcStateRepository.FindAsync(c => c.Id == command.Id);

            if (PayCalcStates.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayCalcState = Mapper.Map(command);
            await _unitOfWork.PayCalcStateRepository.AddAsync(newPayCalcState);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayCalcStateCommand command)
        {

            command.Validate();

            var PayCalcState = await _unitOfWork.PayCalcStateRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayCalcState == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayCalcState = Mapper.Map(PayCalcState, command);
            PayCalcState.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayCalcState = await _unitOfWork.PayCalcStateRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayCalcState == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayCalcState.IsActive = false;
            PayCalcState.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayCalcStates = await _unitOfWork.PayCalcStateRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayCalcStatesDto = Mapper.Map(PayCalcStates);

            return OkResult(CustomMessage.DefaultMessage, PayCalcStatesDto.ToPagingAndSorting(query), PayCalcStatesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayCalcState = await _unitOfWork.PayCalcStateRepository.GetByIdAsync(id);

            if (PayCalcState is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayCalcStateDto = Mapper.Map(PayCalcState);

            return OkResult( CustomMessage.DefaultMessage , PayCalcStateDto);

        }
    }
}
