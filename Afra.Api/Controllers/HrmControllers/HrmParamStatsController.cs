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

namespace Afra.Api.Controllers.HrmParamStatsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmParamStatsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmParamStatsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmParamStatsCommand command)
        {
            command.Validate();

            var HrmParamStatss = await _unitOfWork.HrmParamStatsRepository.FindAsync(c => c.Id == command.Id);

            if (HrmParamStatss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmParamStats = Mapper.Map(command);
            await _unitOfWork.HrmParamStatsRepository.AddAsync(newHrmParamStats);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmParamStatsCommand command)
        {

            command.Validate();

            var HrmParamStats = await _unitOfWork.HrmParamStatsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmParamStats == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmParamStats = Mapper.Map(HrmParamStats, command);
            HrmParamStats.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmParamStats = await _unitOfWork.HrmParamStatsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmParamStats == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmParamStats.IsActive = false;
            HrmParamStats.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmParamStatss = await _unitOfWork.HrmParamStatsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmParamStatssDto = Mapper.Map(HrmParamStatss);

            return OkResult(CustomMessage.DefaultMessage, HrmParamStatssDto.ToPagingAndSorting(query), HrmParamStatssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmParamStats = await _unitOfWork.HrmParamStatsRepository.GetByIdAsync(id);

            if (HrmParamStats is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmParamStatsDto = Mapper.Map(HrmParamStats);

            return OkResult( CustomMessage.DefaultMessage , HrmParamStatsDto);

        }
    }
}
