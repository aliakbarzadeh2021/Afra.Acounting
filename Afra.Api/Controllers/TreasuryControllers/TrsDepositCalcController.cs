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

namespace Afra.Api.Controllers.TrsDepositCalcControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsDepositCalcController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsDepositCalcController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsDepositCalcCommand command)
        {
            command.Validate();

            var TrsDepositCalcs = await _unitOfWork.TrsDepositCalcRepository.FindAsync(c => c.Id == command.Id);

            if (TrsDepositCalcs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsDepositCalc = Mapper.Map(command);
            await _unitOfWork.TrsDepositCalcRepository.AddAsync(newTrsDepositCalc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsDepositCalcCommand command)
        {

            command.Validate();

            var TrsDepositCalc = await _unitOfWork.TrsDepositCalcRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsDepositCalc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsDepositCalc = Mapper.Map(TrsDepositCalc, command);
            TrsDepositCalc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsDepositCalc = await _unitOfWork.TrsDepositCalcRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsDepositCalc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsDepositCalc.IsActive = false;
            TrsDepositCalc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsDepositCalcs = await _unitOfWork.TrsDepositCalcRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsDepositCalcsDto = Mapper.Map(TrsDepositCalcs);

            return OkResult(CustomMessage.DefaultMessage, TrsDepositCalcsDto.ToPagingAndSorting(query), TrsDepositCalcsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsDepositCalc = await _unitOfWork.TrsDepositCalcRepository.GetByIdAsync(id);

            if (TrsDepositCalc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsDepositCalcDto = Mapper.Map(TrsDepositCalc);

            return OkResult( CustomMessage.DefaultMessage , TrsDepositCalcDto);

        }
    }
}
