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

namespace Afra.Api.Controllers.InvPartGroupsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvPartGroupsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvPartGroupsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvPartGroupsCommand command)
        {
            command.Validate();

            var InvPartGroupss = await _unitOfWork.InvPartGroupsRepository.FindAsync(c => c.Id == command.Id);

            if (InvPartGroupss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvPartGroups = Mapper.Map(command);
            await _unitOfWork.InvPartGroupsRepository.AddAsync(newInvPartGroups);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvPartGroupsCommand command)
        {

            command.Validate();

            var InvPartGroups = await _unitOfWork.InvPartGroupsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvPartGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartGroups = Mapper.Map(InvPartGroups, command);
            InvPartGroups.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvPartGroups = await _unitOfWork.InvPartGroupsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvPartGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartGroups.IsActive = false;
            InvPartGroups.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvPartGroupss = await _unitOfWork.InvPartGroupsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvPartGroupssDto = Mapper.Map(InvPartGroupss);

            return OkResult(CustomMessage.DefaultMessage, InvPartGroupssDto.ToPagingAndSorting(query), InvPartGroupssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvPartGroups = await _unitOfWork.InvPartGroupsRepository.GetByIdAsync(id);

            if (InvPartGroups is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvPartGroupsDto = Mapper.Map(InvPartGroups);

            return OkResult( CustomMessage.DefaultMessage , InvPartGroupsDto);

        }
    }
}
