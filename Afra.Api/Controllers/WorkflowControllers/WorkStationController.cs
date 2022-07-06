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

namespace Afra.Api.Controllers.WorkStationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class WorkStationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public WorkStationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddWorkStationCommand command)
        {
            command.Validate();

            var WorkStations = await _unitOfWork.WorkStationRepository.FindAsync(c => c.Id == command.Id);

            if (WorkStations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newWorkStation = Mapper.Map(command);
            await _unitOfWork.WorkStationRepository.AddAsync(newWorkStation);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditWorkStationCommand command)
        {

            command.Validate();

            var WorkStation = await _unitOfWork.WorkStationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (WorkStation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WorkStation = Mapper.Map(WorkStation, command);
            WorkStation.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var WorkStation = await _unitOfWork.WorkStationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (WorkStation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WorkStation.IsActive = false;
            WorkStation.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var WorkStations = await _unitOfWork.WorkStationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var WorkStationsDto = Mapper.Map(WorkStations);

            return OkResult(CustomMessage.DefaultMessage, WorkStationsDto.ToPagingAndSorting(query), WorkStationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var WorkStation = await _unitOfWork.WorkStationRepository.GetByIdAsync(id);

            if (WorkStation is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var WorkStationDto = Mapper.Map(WorkStation);

            return OkResult( CustomMessage.DefaultMessage , WorkStationDto);

        }
    }
}
