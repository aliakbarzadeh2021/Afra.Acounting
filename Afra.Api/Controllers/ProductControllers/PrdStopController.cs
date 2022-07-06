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

namespace Afra.Api.Controllers.PrdStopControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdStopController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdStopController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdStopCommand command)
        {
            command.Validate();

            var PrdStops = await _unitOfWork.PrdStopRepository.FindAsync(c => c.Id == command.Id);

            if (PrdStops.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdStop = Mapper.Map(command);
            await _unitOfWork.PrdStopRepository.AddAsync(newPrdStop);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdStopCommand command)
        {

            command.Validate();

            var PrdStop = await _unitOfWork.PrdStopRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdStop == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdStop = Mapper.Map(PrdStop, command);
            PrdStop.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdStop = await _unitOfWork.PrdStopRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdStop == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdStop.IsActive = false;
            PrdStop.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdStops = await _unitOfWork.PrdStopRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdStopsDto = Mapper.Map(PrdStops);

            return OkResult(CustomMessage.DefaultMessage, PrdStopsDto.ToPagingAndSorting(query), PrdStopsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdStop = await _unitOfWork.PrdStopRepository.GetByIdAsync(id);

            if (PrdStop is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdStopDto = Mapper.Map(PrdStop);

            return OkResult( CustomMessage.DefaultMessage , PrdStopDto);

        }
    }
}
