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

namespace Afra.Api.Controllers.GnrRptGroupsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrRptGroupsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrRptGroupsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrRptGroupsCommand command)
        {
            command.Validate();

            var GnrRptGroupss = await _unitOfWork.GnrRptGroupsRepository.FindAsync(c => c.Id == command.Id);

            if (GnrRptGroupss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrRptGroups = Mapper.Map(command);
            await _unitOfWork.GnrRptGroupsRepository.AddAsync(newGnrRptGroups);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrRptGroupsCommand command)
        {

            command.Validate();

            var GnrRptGroups = await _unitOfWork.GnrRptGroupsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrRptGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrRptGroups = Mapper.Map(GnrRptGroups, command);
            GnrRptGroups.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrRptGroups = await _unitOfWork.GnrRptGroupsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrRptGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrRptGroups.IsActive = false;
            GnrRptGroups.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrRptGroupss = await _unitOfWork.GnrRptGroupsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrRptGroupssDto = Mapper.Map(GnrRptGroupss);

            return OkResult(CustomMessage.DefaultMessage, GnrRptGroupssDto.ToPagingAndSorting(query), GnrRptGroupssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrRptGroups = await _unitOfWork.GnrRptGroupsRepository.GetByIdAsync(id);

            if (GnrRptGroups is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrRptGroupsDto = Mapper.Map(GnrRptGroups);

            return OkResult( CustomMessage.DefaultMessage , GnrRptGroupsDto);

        }
    }
}
