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

namespace Afra.Api.Controllers.OtoFlowRightControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoFlowRightController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoFlowRightController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoFlowRightCommand command)
        {
            command.Validate();

            var OtoFlowRights = await _unitOfWork.OtoFlowRightRepository.FindAsync(c => c.Id == command.Id);

            if (OtoFlowRights.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoFlowRight = Mapper.Map(command);
            await _unitOfWork.OtoFlowRightRepository.AddAsync(newOtoFlowRight);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoFlowRightCommand command)
        {

            command.Validate();

            var OtoFlowRight = await _unitOfWork.OtoFlowRightRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoFlowRight == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoFlowRight = Mapper.Map(OtoFlowRight, command);
            OtoFlowRight.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoFlowRight = await _unitOfWork.OtoFlowRightRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoFlowRight == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoFlowRight.IsActive = false;
            OtoFlowRight.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoFlowRights = await _unitOfWork.OtoFlowRightRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoFlowRightsDto = Mapper.Map(OtoFlowRights);

            return OkResult(CustomMessage.DefaultMessage, OtoFlowRightsDto.ToPagingAndSorting(query), OtoFlowRightsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoFlowRight = await _unitOfWork.OtoFlowRightRepository.GetByIdAsync(id);

            if (OtoFlowRight is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoFlowRightDto = Mapper.Map(OtoFlowRight);

            return OkResult( CustomMessage.DefaultMessage , OtoFlowRightDto);

        }
    }
}
