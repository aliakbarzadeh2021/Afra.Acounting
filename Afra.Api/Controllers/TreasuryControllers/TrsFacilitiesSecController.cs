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

namespace Afra.Api.Controllers.TrsFacilitiesSecControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFacilitiesSecController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFacilitiesSecController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFacilitiesSecCommand command)
        {
            command.Validate();

            var TrsFacilitiesSecs = await _unitOfWork.TrsFacilitiesSecRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFacilitiesSecs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFacilitiesSec = Mapper.Map(command);
            await _unitOfWork.TrsFacilitiesSecRepository.AddAsync(newTrsFacilitiesSec);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFacilitiesSecCommand command)
        {

            command.Validate();

            var TrsFacilitiesSec = await _unitOfWork.TrsFacilitiesSecRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFacilitiesSec == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacilitiesSec = Mapper.Map(TrsFacilitiesSec, command);
            TrsFacilitiesSec.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFacilitiesSec = await _unitOfWork.TrsFacilitiesSecRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFacilitiesSec == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacilitiesSec.IsActive = false;
            TrsFacilitiesSec.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFacilitiesSecs = await _unitOfWork.TrsFacilitiesSecRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFacilitiesSecsDto = Mapper.Map(TrsFacilitiesSecs);

            return OkResult(CustomMessage.DefaultMessage, TrsFacilitiesSecsDto.ToPagingAndSorting(query), TrsFacilitiesSecsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFacilitiesSec = await _unitOfWork.TrsFacilitiesSecRepository.GetByIdAsync(id);

            if (TrsFacilitiesSec is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFacilitiesSecDto = Mapper.Map(TrsFacilitiesSec);

            return OkResult( CustomMessage.DefaultMessage , TrsFacilitiesSecDto);

        }
    }
}
