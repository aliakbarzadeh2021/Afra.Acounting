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

namespace Afra.Api.Controllers.GnrUserLogControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrUserLogController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrUserLogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrUserLogCommand command)
        {
            command.Validate();

            var GnrUserLogs = await _unitOfWork.GnrUserLogRepository.FindAsync(c => c.Id == command.Id);

            if (GnrUserLogs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrUserLog = Mapper.Map(command);
            await _unitOfWork.GnrUserLogRepository.AddAsync(newGnrUserLog);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrUserLogCommand command)
        {

            command.Validate();

            var GnrUserLog = await _unitOfWork.GnrUserLogRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrUserLog == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserLog = Mapper.Map(GnrUserLog, command);
            GnrUserLog.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrUserLog = await _unitOfWork.GnrUserLogRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrUserLog == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserLog.IsActive = false;
            GnrUserLog.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrUserLogs = await _unitOfWork.GnrUserLogRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrUserLogsDto = Mapper.Map(GnrUserLogs);

            return OkResult(CustomMessage.DefaultMessage, GnrUserLogsDto.ToPagingAndSorting(query), GnrUserLogsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrUserLog = await _unitOfWork.GnrUserLogRepository.GetByIdAsync(id);

            if (GnrUserLog is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrUserLogDto = Mapper.Map(GnrUserLog);

            return OkResult( CustomMessage.DefaultMessage , GnrUserLogDto);

        }
    }
}
