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

namespace Afra.Api.Controllers.UsGroupsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsGroupsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsGroupsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsGroupsCommand command)
        {
            command.Validate();

            var UsGroupss = await _unitOfWork.UsGroupsRepository.FindAsync(c => c.Id == command.Id);

            if (UsGroupss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsGroups = Mapper.Map(command);
            await _unitOfWork.UsGroupsRepository.AddAsync(newUsGroups);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsGroupsCommand command)
        {

            command.Validate();

            var UsGroups = await _unitOfWork.UsGroupsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsGroups = Mapper.Map(UsGroups, command);
            UsGroups.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsGroups = await _unitOfWork.UsGroupsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsGroups.IsActive = false;
            UsGroups.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsGroupss = await _unitOfWork.UsGroupsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsGroupssDto = Mapper.Map(UsGroupss);

            return OkResult(CustomMessage.DefaultMessage, UsGroupssDto.ToPagingAndSorting(query), UsGroupssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsGroups = await _unitOfWork.UsGroupsRepository.GetByIdAsync(id);

            if (UsGroups is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsGroupsDto = Mapper.Map(UsGroups);

            return OkResult( CustomMessage.DefaultMessage , UsGroupsDto);

        }
    }
}
