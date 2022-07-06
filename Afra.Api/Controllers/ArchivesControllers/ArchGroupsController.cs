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

namespace Afra.Api.Controllers.ArchGroupsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ArchGroupsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ArchGroupsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddArchGroupsCommand command)
        {
            command.Validate();

            var ArchGroupss = await _unitOfWork.ArchGroupsRepository.FindAsync(c => c.Id == command.Id);

            if (ArchGroupss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newArchGroups = Mapper.Map(command);
            await _unitOfWork.ArchGroupsRepository.AddAsync(newArchGroups);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditArchGroupsCommand command)
        {

            command.Validate();

            var ArchGroups = await _unitOfWork.ArchGroupsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ArchGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ArchGroups = Mapper.Map(ArchGroups, command);
            ArchGroups.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ArchGroups = await _unitOfWork.ArchGroupsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ArchGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ArchGroups.IsActive = false;
            ArchGroups.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ArchGroupss = await _unitOfWork.ArchGroupsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ArchGroupssDto = Mapper.Map(ArchGroupss);

            return OkResult(CustomMessage.DefaultMessage, ArchGroupssDto.ToPagingAndSorting(query), ArchGroupssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ArchGroups = await _unitOfWork.ArchGroupsRepository.GetByIdAsync(id);

            if (ArchGroups is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ArchGroupsDto = Mapper.Map(ArchGroups);

            return OkResult( CustomMessage.DefaultMessage , ArchGroupsDto);

        }
    }
}
