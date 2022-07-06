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

namespace Afra.Api.Controllers.SleBranchsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleBranchsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleBranchsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleBranchsCommand command)
        {
            command.Validate();

            var SleBranchss = await _unitOfWork.SleBranchsRepository.FindAsync(c => c.Id == command.Id);

            if (SleBranchss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleBranchs = Mapper.Map(command);
            await _unitOfWork.SleBranchsRepository.AddAsync(newSleBranchs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleBranchsCommand command)
        {

            command.Validate();

            var SleBranchs = await _unitOfWork.SleBranchsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleBranchs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleBranchs = Mapper.Map(SleBranchs, command);
            SleBranchs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleBranchs = await _unitOfWork.SleBranchsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleBranchs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleBranchs.IsActive = false;
            SleBranchs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleBranchss = await _unitOfWork.SleBranchsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleBranchssDto = Mapper.Map(SleBranchss);

            return OkResult(CustomMessage.DefaultMessage, SleBranchssDto.ToPagingAndSorting(query), SleBranchssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleBranchs = await _unitOfWork.SleBranchsRepository.GetByIdAsync(id);

            if (SleBranchs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleBranchsDto = Mapper.Map(SleBranchs);

            return OkResult( CustomMessage.DefaultMessage , SleBranchsDto);

        }
    }
}
