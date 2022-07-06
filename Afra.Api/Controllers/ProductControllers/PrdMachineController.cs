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

namespace Afra.Api.Controllers.PrdMachineControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdMachineController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdMachineController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdMachineCommand command)
        {
            command.Validate();

            var PrdMachines = await _unitOfWork.PrdMachineRepository.FindAsync(c => c.Id == command.Id);

            if (PrdMachines.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdMachine = Mapper.Map(command);
            await _unitOfWork.PrdMachineRepository.AddAsync(newPrdMachine);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdMachineCommand command)
        {

            command.Validate();

            var PrdMachine = await _unitOfWork.PrdMachineRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdMachine == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdMachine = Mapper.Map(PrdMachine, command);
            PrdMachine.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdMachine = await _unitOfWork.PrdMachineRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdMachine == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdMachine.IsActive = false;
            PrdMachine.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdMachines = await _unitOfWork.PrdMachineRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdMachinesDto = Mapper.Map(PrdMachines);

            return OkResult(CustomMessage.DefaultMessage, PrdMachinesDto.ToPagingAndSorting(query), PrdMachinesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdMachine = await _unitOfWork.PrdMachineRepository.GetByIdAsync(id);

            if (PrdMachine is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdMachineDto = Mapper.Map(PrdMachine);

            return OkResult( CustomMessage.DefaultMessage , PrdMachineDto);

        }
    }
}
