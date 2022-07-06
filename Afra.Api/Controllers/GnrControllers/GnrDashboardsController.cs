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

namespace Afra.Api.Controllers.GnrDashboardsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrDashboardsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrDashboardsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrDashboardsCommand command)
        {
            command.Validate();

            var GnrDashboardss = await _unitOfWork.GnrDashboardsRepository.FindAsync(c => c.Id == command.Id);

            if (GnrDashboardss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrDashboards = Mapper.Map(command);
            await _unitOfWork.GnrDashboardsRepository.AddAsync(newGnrDashboards);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrDashboardsCommand command)
        {

            command.Validate();

            var GnrDashboards = await _unitOfWork.GnrDashboardsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrDashboards == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrDashboards = Mapper.Map(GnrDashboards, command);
            GnrDashboards.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrDashboards = await _unitOfWork.GnrDashboardsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrDashboards == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrDashboards.IsActive = false;
            GnrDashboards.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrDashboardss = await _unitOfWork.GnrDashboardsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrDashboardssDto = Mapper.Map(GnrDashboardss);

            return OkResult(CustomMessage.DefaultMessage, GnrDashboardssDto.ToPagingAndSorting(query), GnrDashboardssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrDashboards = await _unitOfWork.GnrDashboardsRepository.GetByIdAsync(id);

            if (GnrDashboards is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrDashboardsDto = Mapper.Map(GnrDashboards);

            return OkResult( CustomMessage.DefaultMessage , GnrDashboardsDto);

        }
    }
}
