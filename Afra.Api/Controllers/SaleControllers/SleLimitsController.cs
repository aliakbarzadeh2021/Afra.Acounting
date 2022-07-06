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

namespace Afra.Api.Controllers.SleLimitsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleLimitsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleLimitsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleLimitsCommand command)
        {
            command.Validate();

            var SleLimitss = await _unitOfWork.SleLimitsRepository.FindAsync(c => c.Id == command.Id);

            if (SleLimitss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleLimits = Mapper.Map(command);
            await _unitOfWork.SleLimitsRepository.AddAsync(newSleLimits);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleLimitsCommand command)
        {

            command.Validate();

            var SleLimits = await _unitOfWork.SleLimitsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleLimits == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleLimits = Mapper.Map(SleLimits, command);
            SleLimits.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleLimits = await _unitOfWork.SleLimitsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleLimits == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleLimits.IsActive = false;
            SleLimits.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleLimitss = await _unitOfWork.SleLimitsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleLimitssDto = Mapper.Map(SleLimitss);

            return OkResult(CustomMessage.DefaultMessage, SleLimitssDto.ToPagingAndSorting(query), SleLimitssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleLimits = await _unitOfWork.SleLimitsRepository.GetByIdAsync(id);

            if (SleLimits is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleLimitsDto = Mapper.Map(SleLimits);

            return OkResult( CustomMessage.DefaultMessage , SleLimitsDto);

        }
    }
}
