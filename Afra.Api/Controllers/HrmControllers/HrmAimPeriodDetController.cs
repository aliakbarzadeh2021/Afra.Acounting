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

namespace Afra.Api.Controllers.HrmAimPeriodDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmAimPeriodDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmAimPeriodDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmAimPeriodDetCommand command)
        {
            command.Validate();

            var HrmAimPeriodDets = await _unitOfWork.HrmAimPeriodDetRepository.FindAsync(c => c.Id == command.Id);

            if (HrmAimPeriodDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmAimPeriodDet = Mapper.Map(command);
            await _unitOfWork.HrmAimPeriodDetRepository.AddAsync(newHrmAimPeriodDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmAimPeriodDetCommand command)
        {

            command.Validate();

            var HrmAimPeriodDet = await _unitOfWork.HrmAimPeriodDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmAimPeriodDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmAimPeriodDet = Mapper.Map(HrmAimPeriodDet, command);
            HrmAimPeriodDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmAimPeriodDet = await _unitOfWork.HrmAimPeriodDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmAimPeriodDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmAimPeriodDet.IsActive = false;
            HrmAimPeriodDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmAimPeriodDets = await _unitOfWork.HrmAimPeriodDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmAimPeriodDetsDto = Mapper.Map(HrmAimPeriodDets);

            return OkResult(CustomMessage.DefaultMessage, HrmAimPeriodDetsDto.ToPagingAndSorting(query), HrmAimPeriodDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmAimPeriodDet = await _unitOfWork.HrmAimPeriodDetRepository.GetByIdAsync(id);

            if (HrmAimPeriodDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmAimPeriodDetDto = Mapper.Map(HrmAimPeriodDet);

            return OkResult( CustomMessage.DefaultMessage , HrmAimPeriodDetDto);

        }
    }
}
