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

namespace Afra.Api.Controllers.InvStckTagControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvStckTagController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvStckTagController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvStckTagCommand command)
        {
            command.Validate();

            var InvStckTags = await _unitOfWork.InvStckTagRepository.FindAsync(c => c.Id == command.Id);

            if (InvStckTags.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvStckTag = Mapper.Map(command);
            await _unitOfWork.InvStckTagRepository.AddAsync(newInvStckTag);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvStckTagCommand command)
        {

            command.Validate();

            var InvStckTag = await _unitOfWork.InvStckTagRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvStckTag == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvStckTag = Mapper.Map(InvStckTag, command);
            InvStckTag.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvStckTag = await _unitOfWork.InvStckTagRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvStckTag == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvStckTag.IsActive = false;
            InvStckTag.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvStckTags = await _unitOfWork.InvStckTagRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvStckTagsDto = Mapper.Map(InvStckTags);

            return OkResult(CustomMessage.DefaultMessage, InvStckTagsDto.ToPagingAndSorting(query), InvStckTagsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvStckTag = await _unitOfWork.InvStckTagRepository.GetByIdAsync(id);

            if (InvStckTag is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvStckTagDto = Mapper.Map(InvStckTag);

            return OkResult( CustomMessage.DefaultMessage , InvStckTagDto);

        }
    }
}
