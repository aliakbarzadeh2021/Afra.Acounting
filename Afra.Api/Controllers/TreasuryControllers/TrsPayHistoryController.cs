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

namespace Afra.Api.Controllers.TrsPayHistoryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsPayHistoryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsPayHistoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsPayHistoryCommand command)
        {
            command.Validate();

            var TrsPayHistorys = await _unitOfWork.TrsPayHistoryRepository.FindAsync(c => c.Id == command.Id);

            if (TrsPayHistorys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsPayHistory = Mapper.Map(command);
            await _unitOfWork.TrsPayHistoryRepository.AddAsync(newTrsPayHistory);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsPayHistoryCommand command)
        {

            command.Validate();

            var TrsPayHistory = await _unitOfWork.TrsPayHistoryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsPayHistory == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsPayHistory = Mapper.Map(TrsPayHistory, command);
            TrsPayHistory.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsPayHistory = await _unitOfWork.TrsPayHistoryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsPayHistory == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsPayHistory.IsActive = false;
            TrsPayHistory.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsPayHistorys = await _unitOfWork.TrsPayHistoryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsPayHistorysDto = Mapper.Map(TrsPayHistorys);

            return OkResult(CustomMessage.DefaultMessage, TrsPayHistorysDto.ToPagingAndSorting(query), TrsPayHistorysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsPayHistory = await _unitOfWork.TrsPayHistoryRepository.GetByIdAsync(id);

            if (TrsPayHistory is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsPayHistoryDto = Mapper.Map(TrsPayHistory);

            return OkResult( CustomMessage.DefaultMessage , TrsPayHistoryDto);

        }
    }
}
