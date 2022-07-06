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

namespace Afra.Api.Controllers.GnrFormFlowControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrFormFlowController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrFormFlowController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrFormFlowCommand command)
        {
            command.Validate();

            var GnrFormFlows = await _unitOfWork.GnrFormFlowRepository.FindAsync(c => c.Id == command.Id);

            if (GnrFormFlows.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrFormFlow = Mapper.Map(command);
            await _unitOfWork.GnrFormFlowRepository.AddAsync(newGnrFormFlow);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrFormFlowCommand command)
        {

            command.Validate();

            var GnrFormFlow = await _unitOfWork.GnrFormFlowRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrFormFlow == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrFormFlow = Mapper.Map(GnrFormFlow, command);
            GnrFormFlow.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrFormFlow = await _unitOfWork.GnrFormFlowRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrFormFlow == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrFormFlow.IsActive = false;
            GnrFormFlow.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrFormFlows = await _unitOfWork.GnrFormFlowRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrFormFlowsDto = Mapper.Map(GnrFormFlows);

            return OkResult(CustomMessage.DefaultMessage, GnrFormFlowsDto.ToPagingAndSorting(query), GnrFormFlowsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrFormFlow = await _unitOfWork.GnrFormFlowRepository.GetByIdAsync(id);

            if (GnrFormFlow is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrFormFlowDto = Mapper.Map(GnrFormFlow);

            return OkResult( CustomMessage.DefaultMessage , GnrFormFlowDto);

        }
    }
}
