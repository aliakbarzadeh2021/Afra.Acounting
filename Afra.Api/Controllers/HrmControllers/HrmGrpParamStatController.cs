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

namespace Afra.Api.Controllers.HrmGrpParamStatControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmGrpParamStatController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmGrpParamStatController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmGrpParamStatCommand command)
        {
            command.Validate();

            var HrmGrpParamStats = await _unitOfWork.HrmGrpParamStatRepository.FindAsync(c => c.Id == command.Id);

            if (HrmGrpParamStats.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmGrpParamStat = Mapper.Map(command);
            await _unitOfWork.HrmGrpParamStatRepository.AddAsync(newHrmGrpParamStat);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmGrpParamStatCommand command)
        {

            command.Validate();

            var HrmGrpParamStat = await _unitOfWork.HrmGrpParamStatRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmGrpParamStat == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmGrpParamStat = Mapper.Map(HrmGrpParamStat, command);
            HrmGrpParamStat.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmGrpParamStat = await _unitOfWork.HrmGrpParamStatRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmGrpParamStat == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmGrpParamStat.IsActive = false;
            HrmGrpParamStat.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmGrpParamStats = await _unitOfWork.HrmGrpParamStatRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmGrpParamStatsDto = Mapper.Map(HrmGrpParamStats);

            return OkResult(CustomMessage.DefaultMessage, HrmGrpParamStatsDto.ToPagingAndSorting(query), HrmGrpParamStatsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmGrpParamStat = await _unitOfWork.HrmGrpParamStatRepository.GetByIdAsync(id);

            if (HrmGrpParamStat is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmGrpParamStatDto = Mapper.Map(HrmGrpParamStat);

            return OkResult( CustomMessage.DefaultMessage , HrmGrpParamStatDto);

        }
    }
}
