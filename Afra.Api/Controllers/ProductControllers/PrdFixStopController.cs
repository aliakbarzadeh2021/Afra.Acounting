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

namespace Afra.Api.Controllers.PrdFixStopControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdFixStopController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdFixStopController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdFixStopCommand command)
        {
            command.Validate();

            var PrdFixStops = await _unitOfWork.PrdFixStopRepository.FindAsync(c => c.Id == command.Id);

            if (PrdFixStops.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdFixStop = Mapper.Map(command);
            await _unitOfWork.PrdFixStopRepository.AddAsync(newPrdFixStop);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdFixStopCommand command)
        {

            command.Validate();

            var PrdFixStop = await _unitOfWork.PrdFixStopRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdFixStop == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdFixStop = Mapper.Map(PrdFixStop, command);
            PrdFixStop.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdFixStop = await _unitOfWork.PrdFixStopRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdFixStop == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdFixStop.IsActive = false;
            PrdFixStop.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdFixStops = await _unitOfWork.PrdFixStopRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdFixStopsDto = Mapper.Map(PrdFixStops);

            return OkResult(CustomMessage.DefaultMessage, PrdFixStopsDto.ToPagingAndSorting(query), PrdFixStopsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdFixStop = await _unitOfWork.PrdFixStopRepository.GetByIdAsync(id);

            if (PrdFixStop is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdFixStopDto = Mapper.Map(PrdFixStop);

            return OkResult( CustomMessage.DefaultMessage , PrdFixStopDto);

        }
    }
}
