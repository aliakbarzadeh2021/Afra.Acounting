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

namespace Afra.Api.Controllers.TrsFacYearShareControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFacYearShareController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFacYearShareController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFacYearShareCommand command)
        {
            command.Validate();

            var TrsFacYearShares = await _unitOfWork.TrsFacYearShareRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFacYearShares.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFacYearShare = Mapper.Map(command);
            await _unitOfWork.TrsFacYearShareRepository.AddAsync(newTrsFacYearShare);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFacYearShareCommand command)
        {

            command.Validate();

            var TrsFacYearShare = await _unitOfWork.TrsFacYearShareRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFacYearShare == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacYearShare = Mapper.Map(TrsFacYearShare, command);
            TrsFacYearShare.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFacYearShare = await _unitOfWork.TrsFacYearShareRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFacYearShare == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacYearShare.IsActive = false;
            TrsFacYearShare.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFacYearShares = await _unitOfWork.TrsFacYearShareRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFacYearSharesDto = Mapper.Map(TrsFacYearShares);

            return OkResult(CustomMessage.DefaultMessage, TrsFacYearSharesDto.ToPagingAndSorting(query), TrsFacYearSharesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFacYearShare = await _unitOfWork.TrsFacYearShareRepository.GetByIdAsync(id);

            if (TrsFacYearShare is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFacYearShareDto = Mapper.Map(TrsFacYearShare);

            return OkResult( CustomMessage.DefaultMessage , TrsFacYearShareDto);

        }
    }
}
