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

namespace Afra.Api.Controllers.HrmWorkGroupsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmWorkGroupsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmWorkGroupsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmWorkGroupsCommand command)
        {
            command.Validate();

            var HrmWorkGroupss = await _unitOfWork.HrmWorkGroupsRepository.FindAsync(c => c.Id == command.Id);

            if (HrmWorkGroupss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmWorkGroups = Mapper.Map(command);
            await _unitOfWork.HrmWorkGroupsRepository.AddAsync(newHrmWorkGroups);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmWorkGroupsCommand command)
        {

            command.Validate();

            var HrmWorkGroups = await _unitOfWork.HrmWorkGroupsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmWorkGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmWorkGroups = Mapper.Map(HrmWorkGroups, command);
            HrmWorkGroups.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmWorkGroups = await _unitOfWork.HrmWorkGroupsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmWorkGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmWorkGroups.IsActive = false;
            HrmWorkGroups.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmWorkGroupss = await _unitOfWork.HrmWorkGroupsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmWorkGroupssDto = Mapper.Map(HrmWorkGroupss);

            return OkResult(CustomMessage.DefaultMessage, HrmWorkGroupssDto.ToPagingAndSorting(query), HrmWorkGroupssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmWorkGroups = await _unitOfWork.HrmWorkGroupsRepository.GetByIdAsync(id);

            if (HrmWorkGroups is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmWorkGroupsDto = Mapper.Map(HrmWorkGroups);

            return OkResult( CustomMessage.DefaultMessage , HrmWorkGroupsDto);

        }
    }
}
