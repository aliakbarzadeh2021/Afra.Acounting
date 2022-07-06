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

namespace Afra.Api.Controllers.TrsBankReconcileControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsBankReconcileController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsBankReconcileController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsBankReconcileCommand command)
        {
            command.Validate();

            var TrsBankReconciles = await _unitOfWork.TrsBankReconcileRepository.FindAsync(c => c.Id == command.Id);

            if (TrsBankReconciles.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsBankReconcile = Mapper.Map(command);
            await _unitOfWork.TrsBankReconcileRepository.AddAsync(newTrsBankReconcile);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsBankReconcileCommand command)
        {

            command.Validate();

            var TrsBankReconcile = await _unitOfWork.TrsBankReconcileRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsBankReconcile == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankReconcile = Mapper.Map(TrsBankReconcile, command);
            TrsBankReconcile.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsBankReconcile = await _unitOfWork.TrsBankReconcileRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsBankReconcile == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankReconcile.IsActive = false;
            TrsBankReconcile.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsBankReconciles = await _unitOfWork.TrsBankReconcileRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsBankReconcilesDto = Mapper.Map(TrsBankReconciles);

            return OkResult(CustomMessage.DefaultMessage, TrsBankReconcilesDto.ToPagingAndSorting(query), TrsBankReconcilesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsBankReconcile = await _unitOfWork.TrsBankReconcileRepository.GetByIdAsync(id);

            if (TrsBankReconcile is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsBankReconcileDto = Mapper.Map(TrsBankReconcile);

            return OkResult( CustomMessage.DefaultMessage , TrsBankReconcileDto);

        }
    }
}
