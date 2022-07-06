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

namespace Afra.Api.Controllers.BdgProjGroupControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgProjGroupController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgProjGroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgProjGroupCommand command)
        {
            command.Validate();

            var BdgProjGroups = await _unitOfWork.BdgProjGroupRepository.FindAsync(c => c.Id == command.Id);

            if (BdgProjGroups.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgProjGroup = Mapper.Map(command);
            await _unitOfWork.BdgProjGroupRepository.AddAsync(newBdgProjGroup);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgProjGroupCommand command)
        {

            command.Validate();

            var BdgProjGroup = await _unitOfWork.BdgProjGroupRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgProjGroup == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProjGroup = Mapper.Map(BdgProjGroup, command);
            BdgProjGroup.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgProjGroup = await _unitOfWork.BdgProjGroupRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgProjGroup == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProjGroup.IsActive = false;
            BdgProjGroup.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgProjGroups = await _unitOfWork.BdgProjGroupRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgProjGroupsDto = Mapper.Map(BdgProjGroups);

            return OkResult(CustomMessage.DefaultMessage, BdgProjGroupsDto.ToPagingAndSorting(query), BdgProjGroupsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgProjGroup = await _unitOfWork.BdgProjGroupRepository.GetByIdAsync(id);

            if (BdgProjGroup is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgProjGroupDto = Mapper.Map(BdgProjGroup);

            return OkResult( CustomMessage.DefaultMessage , BdgProjGroupDto);

        }
    }
}
