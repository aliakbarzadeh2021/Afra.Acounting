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

namespace Afra.Api.Controllers.SleSrvGroupsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleSrvGroupsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleSrvGroupsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleSrvGroupsCommand command)
        {
            command.Validate();

            var SleSrvGroupss = await _unitOfWork.SleSrvGroupsRepository.FindAsync(c => c.Id == command.Id);

            if (SleSrvGroupss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleSrvGroups = Mapper.Map(command);
            await _unitOfWork.SleSrvGroupsRepository.AddAsync(newSleSrvGroups);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleSrvGroupsCommand command)
        {

            command.Validate();

            var SleSrvGroups = await _unitOfWork.SleSrvGroupsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleSrvGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleSrvGroups = Mapper.Map(SleSrvGroups, command);
            SleSrvGroups.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleSrvGroups = await _unitOfWork.SleSrvGroupsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleSrvGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleSrvGroups.IsActive = false;
            SleSrvGroups.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleSrvGroupss = await _unitOfWork.SleSrvGroupsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleSrvGroupssDto = Mapper.Map(SleSrvGroupss);

            return OkResult(CustomMessage.DefaultMessage, SleSrvGroupssDto.ToPagingAndSorting(query), SleSrvGroupssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleSrvGroups = await _unitOfWork.SleSrvGroupsRepository.GetByIdAsync(id);

            if (SleSrvGroups is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleSrvGroupsDto = Mapper.Map(SleSrvGroups);

            return OkResult( CustomMessage.DefaultMessage , SleSrvGroupsDto);

        }
    }
}
