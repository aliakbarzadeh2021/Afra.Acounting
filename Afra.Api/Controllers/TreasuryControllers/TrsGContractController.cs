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

namespace Afra.Api.Controllers.TrsGContractControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsGContractController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsGContractController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsGContractCommand command)
        {
            command.Validate();

            var TrsGContracts = await _unitOfWork.TrsGContractRepository.FindAsync(c => c.Id == command.Id);

            if (TrsGContracts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsGContract = Mapper.Map(command);
            await _unitOfWork.TrsGContractRepository.AddAsync(newTrsGContract);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsGContractCommand command)
        {

            command.Validate();

            var TrsGContract = await _unitOfWork.TrsGContractRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsGContract == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsGContract = Mapper.Map(TrsGContract, command);
            TrsGContract.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsGContract = await _unitOfWork.TrsGContractRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsGContract == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsGContract.IsActive = false;
            TrsGContract.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsGContracts = await _unitOfWork.TrsGContractRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsGContractsDto = Mapper.Map(TrsGContracts);

            return OkResult(CustomMessage.DefaultMessage, TrsGContractsDto.ToPagingAndSorting(query), TrsGContractsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsGContract = await _unitOfWork.TrsGContractRepository.GetByIdAsync(id);

            if (TrsGContract is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsGContractDto = Mapper.Map(TrsGContract);

            return OkResult( CustomMessage.DefaultMessage , TrsGContractDto);

        }
    }
}
