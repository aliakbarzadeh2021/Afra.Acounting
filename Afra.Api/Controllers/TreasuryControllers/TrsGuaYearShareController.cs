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

namespace Afra.Api.Controllers.TrsGuaYearShareControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsGuaYearShareController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsGuaYearShareController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsGuaYearShareCommand command)
        {
            command.Validate();

            var TrsGuaYearShares = await _unitOfWork.TrsGuaYearShareRepository.FindAsync(c => c.Id == command.Id);

            if (TrsGuaYearShares.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsGuaYearShare = Mapper.Map(command);
            await _unitOfWork.TrsGuaYearShareRepository.AddAsync(newTrsGuaYearShare);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsGuaYearShareCommand command)
        {

            command.Validate();

            var TrsGuaYearShare = await _unitOfWork.TrsGuaYearShareRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsGuaYearShare == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsGuaYearShare = Mapper.Map(TrsGuaYearShare, command);
            TrsGuaYearShare.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsGuaYearShare = await _unitOfWork.TrsGuaYearShareRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsGuaYearShare == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsGuaYearShare.IsActive = false;
            TrsGuaYearShare.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsGuaYearShares = await _unitOfWork.TrsGuaYearShareRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsGuaYearSharesDto = Mapper.Map(TrsGuaYearShares);

            return OkResult(CustomMessage.DefaultMessage, TrsGuaYearSharesDto.ToPagingAndSorting(query), TrsGuaYearSharesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsGuaYearShare = await _unitOfWork.TrsGuaYearShareRepository.GetByIdAsync(id);

            if (TrsGuaYearShare is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsGuaYearShareDto = Mapper.Map(TrsGuaYearShare);

            return OkResult( CustomMessage.DefaultMessage , TrsGuaYearShareDto);

        }
    }
}
