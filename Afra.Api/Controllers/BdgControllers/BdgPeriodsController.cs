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

namespace Afra.Api.Controllers.BdgPeriodsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgPeriodsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgPeriodsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgPeriodsCommand command)
        {
            command.Validate();

            var BdgPeriodss = await _unitOfWork.BdgPeriodsRepository.FindAsync(c => c.Id == command.Id);

            if (BdgPeriodss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgPeriods = Mapper.Map(command);
            await _unitOfWork.BdgPeriodsRepository.AddAsync(newBdgPeriods);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgPeriodsCommand command)
        {

            command.Validate();

            var BdgPeriods = await _unitOfWork.BdgPeriodsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgPeriods == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgPeriods = Mapper.Map(BdgPeriods, command);
            BdgPeriods.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgPeriods = await _unitOfWork.BdgPeriodsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgPeriods == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgPeriods.IsActive = false;
            BdgPeriods.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgPeriodss = await _unitOfWork.BdgPeriodsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgPeriodssDto = Mapper.Map(BdgPeriodss);

            return OkResult(CustomMessage.DefaultMessage, BdgPeriodssDto.ToPagingAndSorting(query), BdgPeriodssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgPeriods = await _unitOfWork.BdgPeriodsRepository.GetByIdAsync(id);

            if (BdgPeriods is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgPeriodsDto = Mapper.Map(BdgPeriods);

            return OkResult( CustomMessage.DefaultMessage , BdgPeriodsDto);

        }
    }
}
