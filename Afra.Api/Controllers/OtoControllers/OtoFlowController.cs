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

namespace Afra.Api.Controllers.OtoFlowControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoFlowController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoFlowController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoFlowCommand command)
        {
            command.Validate();

            var OtoFlows = await _unitOfWork.OtoFlowRepository.FindAsync(c => c.Id == command.Id);

            if (OtoFlows.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoFlow = Mapper.Map(command);
            await _unitOfWork.OtoFlowRepository.AddAsync(newOtoFlow);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoFlowCommand command)
        {

            command.Validate();

            var OtoFlow = await _unitOfWork.OtoFlowRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoFlow == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoFlow = Mapper.Map(OtoFlow, command);
            OtoFlow.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoFlow = await _unitOfWork.OtoFlowRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoFlow == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoFlow.IsActive = false;
            OtoFlow.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoFlows = await _unitOfWork.OtoFlowRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoFlowsDto = Mapper.Map(OtoFlows);

            return OkResult(CustomMessage.DefaultMessage, OtoFlowsDto.ToPagingAndSorting(query), OtoFlowsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoFlow = await _unitOfWork.OtoFlowRepository.GetByIdAsync(id);

            if (OtoFlow is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoFlowDto = Mapper.Map(OtoFlow);

            return OkResult( CustomMessage.DefaultMessage , OtoFlowDto);

        }
    }
}
