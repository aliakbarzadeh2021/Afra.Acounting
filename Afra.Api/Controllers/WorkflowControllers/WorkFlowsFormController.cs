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

namespace Afra.Api.Controllers.WorkFlowsFormControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class WorkFlowsFormController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public WorkFlowsFormController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddWorkFlowsFormCommand command)
        {
            command.Validate();

            var WorkFlowsForms = await _unitOfWork.WorkFlowsFormRepository.FindAsync(c => c.Id == command.Id);

            if (WorkFlowsForms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newWorkFlowsForm = Mapper.Map(command);
            await _unitOfWork.WorkFlowsFormRepository.AddAsync(newWorkFlowsForm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditWorkFlowsFormCommand command)
        {

            command.Validate();

            var WorkFlowsForm = await _unitOfWork.WorkFlowsFormRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (WorkFlowsForm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WorkFlowsForm = Mapper.Map(WorkFlowsForm, command);
            WorkFlowsForm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var WorkFlowsForm = await _unitOfWork.WorkFlowsFormRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (WorkFlowsForm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WorkFlowsForm.IsActive = false;
            WorkFlowsForm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var WorkFlowsForms = await _unitOfWork.WorkFlowsFormRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var WorkFlowsFormsDto = Mapper.Map(WorkFlowsForms);

            return OkResult(CustomMessage.DefaultMessage, WorkFlowsFormsDto.ToPagingAndSorting(query), WorkFlowsFormsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var WorkFlowsForm = await _unitOfWork.WorkFlowsFormRepository.GetByIdAsync(id);

            if (WorkFlowsForm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var WorkFlowsFormDto = Mapper.Map(WorkFlowsForm);

            return OkResult( CustomMessage.DefaultMessage , WorkFlowsFormDto);

        }
    }
}
