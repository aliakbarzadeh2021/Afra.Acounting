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

namespace Afra.Api.Controllers.UnitsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UnitsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UnitsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUnitsCommand command)
        {
            command.Validate();

            var Unitss = await _unitOfWork.UnitsRepository.FindAsync(c => c.Id == command.Id);

            if (Unitss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUnits = Mapper.Map(command);
            await _unitOfWork.UnitsRepository.AddAsync(newUnits);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUnitsCommand command)
        {

            command.Validate();

            var Units = await _unitOfWork.UnitsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Units == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Units = Mapper.Map(Units, command);
            Units.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Units = await _unitOfWork.UnitsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Units == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Units.IsActive = false;
            Units.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Unitss = await _unitOfWork.UnitsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UnitssDto = Mapper.Map(Unitss);

            return OkResult(CustomMessage.DefaultMessage, UnitssDto.ToPagingAndSorting(query), UnitssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Units = await _unitOfWork.UnitsRepository.GetByIdAsync(id);

            if (Units is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UnitsDto = Mapper.Map(Units);

            return OkResult( CustomMessage.DefaultMessage , UnitsDto);

        }
    }
}
