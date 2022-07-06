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

namespace Afra.Api.Controllers.PrdSchStopControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdSchStopController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdSchStopController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdSchStopCommand command)
        {
            command.Validate();

            var PrdSchStops = await _unitOfWork.PrdSchStopRepository.FindAsync(c => c.Id == command.Id);

            if (PrdSchStops.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdSchStop = Mapper.Map(command);
            await _unitOfWork.PrdSchStopRepository.AddAsync(newPrdSchStop);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdSchStopCommand command)
        {

            command.Validate();

            var PrdSchStop = await _unitOfWork.PrdSchStopRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdSchStop == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdSchStop = Mapper.Map(PrdSchStop, command);
            PrdSchStop.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdSchStop = await _unitOfWork.PrdSchStopRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdSchStop == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdSchStop.IsActive = false;
            PrdSchStop.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdSchStops = await _unitOfWork.PrdSchStopRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdSchStopsDto = Mapper.Map(PrdSchStops);

            return OkResult(CustomMessage.DefaultMessage, PrdSchStopsDto.ToPagingAndSorting(query), PrdSchStopsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdSchStop = await _unitOfWork.PrdSchStopRepository.GetByIdAsync(id);

            if (PrdSchStop is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdSchStopDto = Mapper.Map(PrdSchStop);

            return OkResult( CustomMessage.DefaultMessage , PrdSchStopDto);

        }
    }
}
