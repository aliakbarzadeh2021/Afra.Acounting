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

namespace Afra.Api.Controllers.GnrSysLogsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrSysLogsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrSysLogsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrSysLogsCommand command)
        {
            command.Validate();

            var GnrSysLogss = await _unitOfWork.GnrSysLogsRepository.FindAsync(c => c.Id == command.Id);

            if (GnrSysLogss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrSysLogs = Mapper.Map(command);
            await _unitOfWork.GnrSysLogsRepository.AddAsync(newGnrSysLogs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrSysLogsCommand command)
        {

            command.Validate();

            var GnrSysLogs = await _unitOfWork.GnrSysLogsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrSysLogs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysLogs = Mapper.Map(GnrSysLogs, command);
            GnrSysLogs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrSysLogs = await _unitOfWork.GnrSysLogsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrSysLogs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysLogs.IsActive = false;
            GnrSysLogs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrSysLogss = await _unitOfWork.GnrSysLogsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrSysLogssDto = Mapper.Map(GnrSysLogss);

            return OkResult(CustomMessage.DefaultMessage, GnrSysLogssDto.ToPagingAndSorting(query), GnrSysLogssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrSysLogs = await _unitOfWork.GnrSysLogsRepository.GetByIdAsync(id);

            if (GnrSysLogs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrSysLogsDto = Mapper.Map(GnrSysLogs);

            return OkResult( CustomMessage.DefaultMessage , GnrSysLogsDto);

        }
    }
}
