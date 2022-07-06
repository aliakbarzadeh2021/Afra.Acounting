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

namespace Afra.Api.Controllers.SleCstmrGroupsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleCstmrGroupsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleCstmrGroupsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleCstmrGroupsCommand command)
        {
            command.Validate();

            var SleCstmrGroupss = await _unitOfWork.SleCstmrGroupsRepository.FindAsync(c => c.Id == command.Id);

            if (SleCstmrGroupss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleCstmrGroups = Mapper.Map(command);
            await _unitOfWork.SleCstmrGroupsRepository.AddAsync(newSleCstmrGroups);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleCstmrGroupsCommand command)
        {

            command.Validate();

            var SleCstmrGroups = await _unitOfWork.SleCstmrGroupsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleCstmrGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleCstmrGroups = Mapper.Map(SleCstmrGroups, command);
            SleCstmrGroups.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleCstmrGroups = await _unitOfWork.SleCstmrGroupsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleCstmrGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleCstmrGroups.IsActive = false;
            SleCstmrGroups.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleCstmrGroupss = await _unitOfWork.SleCstmrGroupsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleCstmrGroupssDto = Mapper.Map(SleCstmrGroupss);

            return OkResult(CustomMessage.DefaultMessage, SleCstmrGroupssDto.ToPagingAndSorting(query), SleCstmrGroupssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleCstmrGroups = await _unitOfWork.SleCstmrGroupsRepository.GetByIdAsync(id);

            if (SleCstmrGroups is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleCstmrGroupsDto = Mapper.Map(SleCstmrGroups);

            return OkResult( CustomMessage.DefaultMessage , SleCstmrGroupsDto);

        }
    }
}
