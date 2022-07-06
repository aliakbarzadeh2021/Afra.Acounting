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

namespace Afra.Api.Controllers.TrsFacilitiesDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFacilitiesDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFacilitiesDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFacilitiesDetCommand command)
        {
            command.Validate();

            var TrsFacilitiesDets = await _unitOfWork.TrsFacilitiesDetRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFacilitiesDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFacilitiesDet = Mapper.Map(command);
            await _unitOfWork.TrsFacilitiesDetRepository.AddAsync(newTrsFacilitiesDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFacilitiesDetCommand command)
        {

            command.Validate();

            var TrsFacilitiesDet = await _unitOfWork.TrsFacilitiesDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFacilitiesDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacilitiesDet = Mapper.Map(TrsFacilitiesDet, command);
            TrsFacilitiesDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFacilitiesDet = await _unitOfWork.TrsFacilitiesDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFacilitiesDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacilitiesDet.IsActive = false;
            TrsFacilitiesDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFacilitiesDets = await _unitOfWork.TrsFacilitiesDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFacilitiesDetsDto = Mapper.Map(TrsFacilitiesDets);

            return OkResult(CustomMessage.DefaultMessage, TrsFacilitiesDetsDto.ToPagingAndSorting(query), TrsFacilitiesDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFacilitiesDet = await _unitOfWork.TrsFacilitiesDetRepository.GetByIdAsync(id);

            if (TrsFacilitiesDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFacilitiesDetDto = Mapper.Map(TrsFacilitiesDet);

            return OkResult( CustomMessage.DefaultMessage , TrsFacilitiesDetDto);

        }
    }
}
