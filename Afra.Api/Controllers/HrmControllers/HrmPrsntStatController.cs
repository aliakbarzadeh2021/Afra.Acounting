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

namespace Afra.Api.Controllers.HrmPrsntStatControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmPrsntStatController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmPrsntStatController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmPrsntStatCommand command)
        {
            command.Validate();

            var HrmPrsntStats = await _unitOfWork.HrmPrsntStatRepository.FindAsync(c => c.Id == command.Id);

            if (HrmPrsntStats.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmPrsntStat = Mapper.Map(command);
            await _unitOfWork.HrmPrsntStatRepository.AddAsync(newHrmPrsntStat);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmPrsntStatCommand command)
        {

            command.Validate();

            var HrmPrsntStat = await _unitOfWork.HrmPrsntStatRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmPrsntStat == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPrsntStat = Mapper.Map(HrmPrsntStat, command);
            HrmPrsntStat.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmPrsntStat = await _unitOfWork.HrmPrsntStatRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmPrsntStat == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPrsntStat.IsActive = false;
            HrmPrsntStat.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmPrsntStats = await _unitOfWork.HrmPrsntStatRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmPrsntStatsDto = Mapper.Map(HrmPrsntStats);

            return OkResult(CustomMessage.DefaultMessage, HrmPrsntStatsDto.ToPagingAndSorting(query), HrmPrsntStatsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmPrsntStat = await _unitOfWork.HrmPrsntStatRepository.GetByIdAsync(id);

            if (HrmPrsntStat is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmPrsntStatDto = Mapper.Map(HrmPrsntStat);

            return OkResult( CustomMessage.DefaultMessage , HrmPrsntStatDto);

        }
    }
}
