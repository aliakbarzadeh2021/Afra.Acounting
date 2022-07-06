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

namespace Afra.Api.Controllers.PrdShiftsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdShiftsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdShiftsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdShiftsCommand command)
        {
            command.Validate();

            var PrdShiftss = await _unitOfWork.PrdShiftsRepository.FindAsync(c => c.Id == command.Id);

            if (PrdShiftss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdShifts = Mapper.Map(command);
            await _unitOfWork.PrdShiftsRepository.AddAsync(newPrdShifts);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdShiftsCommand command)
        {

            command.Validate();

            var PrdShifts = await _unitOfWork.PrdShiftsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdShifts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdShifts = Mapper.Map(PrdShifts, command);
            PrdShifts.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdShifts = await _unitOfWork.PrdShiftsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdShifts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdShifts.IsActive = false;
            PrdShifts.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdShiftss = await _unitOfWork.PrdShiftsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdShiftssDto = Mapper.Map(PrdShiftss);

            return OkResult(CustomMessage.DefaultMessage, PrdShiftssDto.ToPagingAndSorting(query), PrdShiftssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdShifts = await _unitOfWork.PrdShiftsRepository.GetByIdAsync(id);

            if (PrdShifts is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdShiftsDto = Mapper.Map(PrdShifts);

            return OkResult( CustomMessage.DefaultMessage , PrdShiftsDto);

        }
    }
}
