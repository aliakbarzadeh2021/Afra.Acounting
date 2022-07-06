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

namespace Afra.Api.Controllers.InvPartUnitsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvPartUnitsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvPartUnitsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvPartUnitsCommand command)
        {
            command.Validate();

            var InvPartUnitss = await _unitOfWork.InvPartUnitsRepository.FindAsync(c => c.Id == command.Id);

            if (InvPartUnitss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvPartUnits = Mapper.Map(command);
            await _unitOfWork.InvPartUnitsRepository.AddAsync(newInvPartUnits);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvPartUnitsCommand command)
        {

            command.Validate();

            var InvPartUnits = await _unitOfWork.InvPartUnitsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvPartUnits == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartUnits = Mapper.Map(InvPartUnits, command);
            InvPartUnits.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvPartUnits = await _unitOfWork.InvPartUnitsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvPartUnits == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartUnits.IsActive = false;
            InvPartUnits.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvPartUnitss = await _unitOfWork.InvPartUnitsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvPartUnitssDto = Mapper.Map(InvPartUnitss);

            return OkResult(CustomMessage.DefaultMessage, InvPartUnitssDto.ToPagingAndSorting(query), InvPartUnitssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvPartUnits = await _unitOfWork.InvPartUnitsRepository.GetByIdAsync(id);

            if (InvPartUnits is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvPartUnitsDto = Mapper.Map(InvPartUnits);

            return OkResult( CustomMessage.DefaultMessage , InvPartUnitsDto);

        }
    }
}
