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

namespace Afra.Api.Controllers.SleBrokerCalcControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleBrokerCalcController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleBrokerCalcController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleBrokerCalcCommand command)
        {
            command.Validate();

            var SleBrokerCalcs = await _unitOfWork.SleBrokerCalcRepository.FindAsync(c => c.Id == command.Id);

            if (SleBrokerCalcs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleBrokerCalc = Mapper.Map(command);
            await _unitOfWork.SleBrokerCalcRepository.AddAsync(newSleBrokerCalc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleBrokerCalcCommand command)
        {

            command.Validate();

            var SleBrokerCalc = await _unitOfWork.SleBrokerCalcRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleBrokerCalc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleBrokerCalc = Mapper.Map(SleBrokerCalc, command);
            SleBrokerCalc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleBrokerCalc = await _unitOfWork.SleBrokerCalcRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleBrokerCalc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleBrokerCalc.IsActive = false;
            SleBrokerCalc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleBrokerCalcs = await _unitOfWork.SleBrokerCalcRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleBrokerCalcsDto = Mapper.Map(SleBrokerCalcs);

            return OkResult(CustomMessage.DefaultMessage, SleBrokerCalcsDto.ToPagingAndSorting(query), SleBrokerCalcsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleBrokerCalc = await _unitOfWork.SleBrokerCalcRepository.GetByIdAsync(id);

            if (SleBrokerCalc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleBrokerCalcDto = Mapper.Map(SleBrokerCalc);

            return OkResult( CustomMessage.DefaultMessage , SleBrokerCalcDto);

        }
    }
}
