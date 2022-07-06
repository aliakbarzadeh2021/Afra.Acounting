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

namespace Afra.Api.Controllers.PrdOperationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdOperationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdOperationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdOperationCommand command)
        {
            command.Validate();

            var PrdOperations = await _unitOfWork.PrdOperationRepository.FindAsync(c => c.Id == command.Id);

            if (PrdOperations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdOperation = Mapper.Map(command);
            await _unitOfWork.PrdOperationRepository.AddAsync(newPrdOperation);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdOperationCommand command)
        {

            command.Validate();

            var PrdOperation = await _unitOfWork.PrdOperationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdOperation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdOperation = Mapper.Map(PrdOperation, command);
            PrdOperation.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdOperation = await _unitOfWork.PrdOperationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdOperation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdOperation.IsActive = false;
            PrdOperation.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdOperations = await _unitOfWork.PrdOperationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdOperationsDto = Mapper.Map(PrdOperations);

            return OkResult(CustomMessage.DefaultMessage, PrdOperationsDto.ToPagingAndSorting(query), PrdOperationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdOperation = await _unitOfWork.PrdOperationRepository.GetByIdAsync(id);

            if (PrdOperation is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdOperationDto = Mapper.Map(PrdOperation);

            return OkResult( CustomMessage.DefaultMessage , PrdOperationDto);

        }
    }
}
