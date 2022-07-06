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

namespace Afra.Api.Controllers.GnrReportsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrReportsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrReportsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrReportsCommand command)
        {
            command.Validate();

            var GnrReportss = await _unitOfWork.GnrReportsRepository.FindAsync(c => c.Id == command.Id);

            if (GnrReportss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrReports = Mapper.Map(command);
            await _unitOfWork.GnrReportsRepository.AddAsync(newGnrReports);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrReportsCommand command)
        {

            command.Validate();

            var GnrReports = await _unitOfWork.GnrReportsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrReports == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrReports = Mapper.Map(GnrReports, command);
            GnrReports.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrReports = await _unitOfWork.GnrReportsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrReports == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrReports.IsActive = false;
            GnrReports.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrReportss = await _unitOfWork.GnrReportsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrReportssDto = Mapper.Map(GnrReportss);

            return OkResult(CustomMessage.DefaultMessage, GnrReportssDto.ToPagingAndSorting(query), GnrReportssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrReports = await _unitOfWork.GnrReportsRepository.GetByIdAsync(id);

            if (GnrReports is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrReportsDto = Mapper.Map(GnrReports);

            return OkResult( CustomMessage.DefaultMessage , GnrReportsDto);

        }
    }
}
