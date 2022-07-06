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

namespace Afra.Api.Controllers.TrsFContractControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFContractController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFContractController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFContractCommand command)
        {
            command.Validate();

            var TrsFContracts = await _unitOfWork.TrsFContractRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFContracts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFContract = Mapper.Map(command);
            await _unitOfWork.TrsFContractRepository.AddAsync(newTrsFContract);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFContractCommand command)
        {

            command.Validate();

            var TrsFContract = await _unitOfWork.TrsFContractRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFContract == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFContract = Mapper.Map(TrsFContract, command);
            TrsFContract.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFContract = await _unitOfWork.TrsFContractRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFContract == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFContract.IsActive = false;
            TrsFContract.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFContracts = await _unitOfWork.TrsFContractRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFContractsDto = Mapper.Map(TrsFContracts);

            return OkResult(CustomMessage.DefaultMessage, TrsFContractsDto.ToPagingAndSorting(query), TrsFContractsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFContract = await _unitOfWork.TrsFContractRepository.GetByIdAsync(id);

            if (TrsFContract is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFContractDto = Mapper.Map(TrsFContract);

            return OkResult( CustomMessage.DefaultMessage , TrsFContractDto);

        }
    }
}
