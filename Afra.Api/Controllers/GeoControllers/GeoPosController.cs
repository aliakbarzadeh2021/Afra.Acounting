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

namespace Afra.Api.Controllers.GeoPosControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GeoPosController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GeoPosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGeoPosCommand command)
        {
            command.Validate();

            var GeoPoss = await _unitOfWork.GeoPosRepository.FindAsync(c => c.Id == command.Id);

            if (GeoPoss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGeoPos = Mapper.Map(command);
            await _unitOfWork.GeoPosRepository.AddAsync(newGeoPos);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGeoPosCommand command)
        {

            command.Validate();

            var GeoPos = await _unitOfWork.GeoPosRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GeoPos == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GeoPos = Mapper.Map(GeoPos, command);
            GeoPos.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GeoPos = await _unitOfWork.GeoPosRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GeoPos == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GeoPos.IsActive = false;
            GeoPos.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GeoPoss = await _unitOfWork.GeoPosRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GeoPossDto = Mapper.Map(GeoPoss);

            return OkResult(CustomMessage.DefaultMessage, GeoPossDto.ToPagingAndSorting(query), GeoPossDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GeoPos = await _unitOfWork.GeoPosRepository.GetByIdAsync(id);

            if (GeoPos is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GeoPosDto = Mapper.Map(GeoPos);

            return OkResult( CustomMessage.DefaultMessage , GeoPosDto);

        }
    }
}
