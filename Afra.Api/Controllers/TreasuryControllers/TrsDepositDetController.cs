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

namespace Afra.Api.Controllers.TrsDepositDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsDepositDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsDepositDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsDepositDetCommand command)
        {
            command.Validate();

            var TrsDepositDets = await _unitOfWork.TrsDepositDetRepository.FindAsync(c => c.Id == command.Id);

            if (TrsDepositDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsDepositDet = Mapper.Map(command);
            await _unitOfWork.TrsDepositDetRepository.AddAsync(newTrsDepositDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsDepositDetCommand command)
        {

            command.Validate();

            var TrsDepositDet = await _unitOfWork.TrsDepositDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsDepositDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsDepositDet = Mapper.Map(TrsDepositDet, command);
            TrsDepositDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsDepositDet = await _unitOfWork.TrsDepositDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsDepositDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsDepositDet.IsActive = false;
            TrsDepositDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsDepositDets = await _unitOfWork.TrsDepositDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsDepositDetsDto = Mapper.Map(TrsDepositDets);

            return OkResult(CustomMessage.DefaultMessage, TrsDepositDetsDto.ToPagingAndSorting(query), TrsDepositDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsDepositDet = await _unitOfWork.TrsDepositDetRepository.GetByIdAsync(id);

            if (TrsDepositDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsDepositDetDto = Mapper.Map(TrsDepositDet);

            return OkResult( CustomMessage.DefaultMessage , TrsDepositDetDto);

        }
    }
}
