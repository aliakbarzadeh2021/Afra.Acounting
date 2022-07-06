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

namespace Afra.Api.Controllers.TrsDepositControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsDepositController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsDepositController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsDepositCommand command)
        {
            command.Validate();

            var TrsDeposits = await _unitOfWork.TrsDepositRepository.FindAsync(c => c.Id == command.Id);

            if (TrsDeposits.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsDeposit = Mapper.Map(command);
            await _unitOfWork.TrsDepositRepository.AddAsync(newTrsDeposit);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsDepositCommand command)
        {

            command.Validate();

            var TrsDeposit = await _unitOfWork.TrsDepositRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsDeposit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsDeposit = Mapper.Map(TrsDeposit, command);
            TrsDeposit.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsDeposit = await _unitOfWork.TrsDepositRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsDeposit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsDeposit.IsActive = false;
            TrsDeposit.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsDeposits = await _unitOfWork.TrsDepositRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsDepositsDto = Mapper.Map(TrsDeposits);

            return OkResult(CustomMessage.DefaultMessage, TrsDepositsDto.ToPagingAndSorting(query), TrsDepositsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsDeposit = await _unitOfWork.TrsDepositRepository.GetByIdAsync(id);

            if (TrsDeposit is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsDepositDto = Mapper.Map(TrsDeposit);

            return OkResult( CustomMessage.DefaultMessage , TrsDepositDto);

        }
    }
}
