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

namespace Afra.Api.Controllers.HrmGroupsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmGroupsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmGroupsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmGroupsCommand command)
        {
            command.Validate();

            var HrmGroupss = await _unitOfWork.HrmGroupsRepository.FindAsync(c => c.Id == command.Id);

            if (HrmGroupss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmGroups = Mapper.Map(command);
            await _unitOfWork.HrmGroupsRepository.AddAsync(newHrmGroups);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmGroupsCommand command)
        {

            command.Validate();

            var HrmGroups = await _unitOfWork.HrmGroupsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmGroups = Mapper.Map(HrmGroups, command);
            HrmGroups.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmGroups = await _unitOfWork.HrmGroupsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmGroups.IsActive = false;
            HrmGroups.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmGroupss = await _unitOfWork.HrmGroupsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmGroupssDto = Mapper.Map(HrmGroupss);

            return OkResult(CustomMessage.DefaultMessage, HrmGroupssDto.ToPagingAndSorting(query), HrmGroupssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmGroups = await _unitOfWork.HrmGroupsRepository.GetByIdAsync(id);

            if (HrmGroups is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmGroupsDto = Mapper.Map(HrmGroups);

            return OkResult( CustomMessage.DefaultMessage , HrmGroupsDto);

        }
    }
}
