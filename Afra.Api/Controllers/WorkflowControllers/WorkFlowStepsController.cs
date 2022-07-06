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

namespace Afra.Api.Controllers.WorkFlowStepsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class WorkFlowStepsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public WorkFlowStepsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddWorkFlowStepsCommand command)
        {
            command.Validate();

            var WorkFlowStepss = await _unitOfWork.WorkFlowStepsRepository.FindAsync(c => c.Id == command.Id);

            if (WorkFlowStepss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newWorkFlowSteps = Mapper.Map(command);
            await _unitOfWork.WorkFlowStepsRepository.AddAsync(newWorkFlowSteps);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditWorkFlowStepsCommand command)
        {

            command.Validate();

            var WorkFlowSteps = await _unitOfWork.WorkFlowStepsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (WorkFlowSteps == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WorkFlowSteps = Mapper.Map(WorkFlowSteps, command);
            WorkFlowSteps.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var WorkFlowSteps = await _unitOfWork.WorkFlowStepsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (WorkFlowSteps == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WorkFlowSteps.IsActive = false;
            WorkFlowSteps.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var WorkFlowStepss = await _unitOfWork.WorkFlowStepsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var WorkFlowStepssDto = Mapper.Map(WorkFlowStepss);

            return OkResult(CustomMessage.DefaultMessage, WorkFlowStepssDto.ToPagingAndSorting(query), WorkFlowStepssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var WorkFlowSteps = await _unitOfWork.WorkFlowStepsRepository.GetByIdAsync(id);

            if (WorkFlowSteps is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var WorkFlowStepsDto = Mapper.Map(WorkFlowSteps);

            return OkResult( CustomMessage.DefaultMessage , WorkFlowStepsDto);

        }
    }
}
