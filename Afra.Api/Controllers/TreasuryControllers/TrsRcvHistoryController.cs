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

namespace Afra.Api.Controllers.TrsRcvHistoryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsRcvHistoryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsRcvHistoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsRcvHistoryCommand command)
        {
            command.Validate();

            var TrsRcvHistorys = await _unitOfWork.TrsRcvHistoryRepository.FindAsync(c => c.Id == command.Id);

            if (TrsRcvHistorys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsRcvHistory = Mapper.Map(command);
            await _unitOfWork.TrsRcvHistoryRepository.AddAsync(newTrsRcvHistory);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsRcvHistoryCommand command)
        {

            command.Validate();

            var TrsRcvHistory = await _unitOfWork.TrsRcvHistoryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsRcvHistory == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsRcvHistory = Mapper.Map(TrsRcvHistory, command);
            TrsRcvHistory.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsRcvHistory = await _unitOfWork.TrsRcvHistoryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsRcvHistory == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsRcvHistory.IsActive = false;
            TrsRcvHistory.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsRcvHistorys = await _unitOfWork.TrsRcvHistoryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsRcvHistorysDto = Mapper.Map(TrsRcvHistorys);

            return OkResult(CustomMessage.DefaultMessage, TrsRcvHistorysDto.ToPagingAndSorting(query), TrsRcvHistorysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsRcvHistory = await _unitOfWork.TrsRcvHistoryRepository.GetByIdAsync(id);

            if (TrsRcvHistory is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsRcvHistoryDto = Mapper.Map(TrsRcvHistory);

            return OkResult( CustomMessage.DefaultMessage , TrsRcvHistoryDto);

        }
    }
}
