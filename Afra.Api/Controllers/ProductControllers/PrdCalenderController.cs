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

namespace Afra.Api.Controllers.PrdCalenderControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdCalenderController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdCalenderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdCalenderCommand command)
        {
            command.Validate();

            var PrdCalenders = await _unitOfWork.PrdCalenderRepository.FindAsync(c => c.Id == command.Id);

            if (PrdCalenders.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdCalender = Mapper.Map(command);
            await _unitOfWork.PrdCalenderRepository.AddAsync(newPrdCalender);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdCalenderCommand command)
        {

            command.Validate();

            var PrdCalender = await _unitOfWork.PrdCalenderRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdCalender == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdCalender = Mapper.Map(PrdCalender, command);
            PrdCalender.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdCalender = await _unitOfWork.PrdCalenderRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdCalender == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdCalender.IsActive = false;
            PrdCalender.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdCalenders = await _unitOfWork.PrdCalenderRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdCalendersDto = Mapper.Map(PrdCalenders);

            return OkResult(CustomMessage.DefaultMessage, PrdCalendersDto.ToPagingAndSorting(query), PrdCalendersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdCalender = await _unitOfWork.PrdCalenderRepository.GetByIdAsync(id);

            if (PrdCalender is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdCalenderDto = Mapper.Map(PrdCalender);

            return OkResult( CustomMessage.DefaultMessage , PrdCalenderDto);

        }
    }
}
