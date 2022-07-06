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

namespace Afra.Api.Controllers.TrsBankReconcileDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsBankReconcileDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsBankReconcileDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsBankReconcileDetCommand command)
        {
            command.Validate();

            var TrsBankReconcileDets = await _unitOfWork.TrsBankReconcileDetRepository.FindAsync(c => c.Id == command.Id);

            if (TrsBankReconcileDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsBankReconcileDet = Mapper.Map(command);
            await _unitOfWork.TrsBankReconcileDetRepository.AddAsync(newTrsBankReconcileDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsBankReconcileDetCommand command)
        {

            command.Validate();

            var TrsBankReconcileDet = await _unitOfWork.TrsBankReconcileDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsBankReconcileDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankReconcileDet = Mapper.Map(TrsBankReconcileDet, command);
            TrsBankReconcileDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsBankReconcileDet = await _unitOfWork.TrsBankReconcileDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsBankReconcileDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankReconcileDet.IsActive = false;
            TrsBankReconcileDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsBankReconcileDets = await _unitOfWork.TrsBankReconcileDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsBankReconcileDetsDto = Mapper.Map(TrsBankReconcileDets);

            return OkResult(CustomMessage.DefaultMessage, TrsBankReconcileDetsDto.ToPagingAndSorting(query), TrsBankReconcileDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsBankReconcileDet = await _unitOfWork.TrsBankReconcileDetRepository.GetByIdAsync(id);

            if (TrsBankReconcileDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsBankReconcileDetDto = Mapper.Map(TrsBankReconcileDet);

            return OkResult( CustomMessage.DefaultMessage , TrsBankReconcileDetDto);

        }
    }
}
