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

namespace Afra.Api.Controllers.WorkFlowsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class WorkFlowsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public WorkFlowsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddWorkFlowsCommand command)
        {
            command.Validate();

            var WorkFlowss = await _unitOfWork.WorkFlowsRepository.FindAsync(c => c.Id == command.Id);

            if (WorkFlowss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newWorkFlows = Mapper.Map(command);
            await _unitOfWork.WorkFlowsRepository.AddAsync(newWorkFlows);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditWorkFlowsCommand command)
        {

            command.Validate();

            var WorkFlows = await _unitOfWork.WorkFlowsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (WorkFlows == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WorkFlows = Mapper.Map(WorkFlows, command);
            WorkFlows.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var WorkFlows = await _unitOfWork.WorkFlowsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (WorkFlows == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WorkFlows.IsActive = false;
            WorkFlows.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var WorkFlowss = await _unitOfWork.WorkFlowsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var WorkFlowssDto = Mapper.Map(WorkFlowss);

            return OkResult(CustomMessage.DefaultMessage, WorkFlowssDto.ToPagingAndSorting(query), WorkFlowssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var WorkFlows = await _unitOfWork.WorkFlowsRepository.GetByIdAsync(id);

            if (WorkFlows is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var WorkFlowsDto = Mapper.Map(WorkFlows);

            return OkResult( CustomMessage.DefaultMessage , WorkFlowsDto);

        }
    }
}
