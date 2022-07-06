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

namespace Afra.Api.Controllers.OtoIndicatorControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoIndicatorController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoIndicatorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoIndicatorCommand command)
        {
            command.Validate();

            var OtoIndicators = await _unitOfWork.OtoIndicatorRepository.FindAsync(c => c.Id == command.Id);

            if (OtoIndicators.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoIndicator = Mapper.Map(command);
            await _unitOfWork.OtoIndicatorRepository.AddAsync(newOtoIndicator);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoIndicatorCommand command)
        {

            command.Validate();

            var OtoIndicator = await _unitOfWork.OtoIndicatorRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoIndicator == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoIndicator = Mapper.Map(OtoIndicator, command);
            OtoIndicator.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoIndicator = await _unitOfWork.OtoIndicatorRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoIndicator == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoIndicator.IsActive = false;
            OtoIndicator.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoIndicators = await _unitOfWork.OtoIndicatorRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoIndicatorsDto = Mapper.Map(OtoIndicators);

            return OkResult(CustomMessage.DefaultMessage, OtoIndicatorsDto.ToPagingAndSorting(query), OtoIndicatorsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoIndicator = await _unitOfWork.OtoIndicatorRepository.GetByIdAsync(id);

            if (OtoIndicator is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoIndicatorDto = Mapper.Map(OtoIndicator);

            return OkResult( CustomMessage.DefaultMessage , OtoIndicatorDto);

        }
    }
}
