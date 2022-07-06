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

namespace Afra.Api.Controllers.HrmCalenderDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmCalenderDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmCalenderDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmCalenderDetCommand command)
        {
            command.Validate();

            var HrmCalenderDets = await _unitOfWork.HrmCalenderDetRepository.FindAsync(c => c.Id == command.Id);

            if (HrmCalenderDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmCalenderDet = Mapper.Map(command);
            await _unitOfWork.HrmCalenderDetRepository.AddAsync(newHrmCalenderDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmCalenderDetCommand command)
        {

            command.Validate();

            var HrmCalenderDet = await _unitOfWork.HrmCalenderDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmCalenderDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmCalenderDet = Mapper.Map(HrmCalenderDet, command);
            HrmCalenderDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmCalenderDet = await _unitOfWork.HrmCalenderDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmCalenderDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmCalenderDet.IsActive = false;
            HrmCalenderDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmCalenderDets = await _unitOfWork.HrmCalenderDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmCalenderDetsDto = Mapper.Map(HrmCalenderDets);

            return OkResult(CustomMessage.DefaultMessage, HrmCalenderDetsDto.ToPagingAndSorting(query), HrmCalenderDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmCalenderDet = await _unitOfWork.HrmCalenderDetRepository.GetByIdAsync(id);

            if (HrmCalenderDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmCalenderDetDto = Mapper.Map(HrmCalenderDet);

            return OkResult( CustomMessage.DefaultMessage , HrmCalenderDetDto);

        }
    }
}
