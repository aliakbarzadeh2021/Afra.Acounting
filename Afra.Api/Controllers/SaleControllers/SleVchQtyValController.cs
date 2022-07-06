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

namespace Afra.Api.Controllers.SleVchQtyValControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleVchQtyValController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleVchQtyValController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleVchQtyValCommand command)
        {
            command.Validate();

            var SleVchQtyVals = await _unitOfWork.SleVchQtyValRepository.FindAsync(c => c.Id == command.Id);

            if (SleVchQtyVals.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleVchQtyVal = Mapper.Map(command);
            await _unitOfWork.SleVchQtyValRepository.AddAsync(newSleVchQtyVal);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleVchQtyValCommand command)
        {

            command.Validate();

            var SleVchQtyVal = await _unitOfWork.SleVchQtyValRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleVchQtyVal == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleVchQtyVal = Mapper.Map(SleVchQtyVal, command);
            SleVchQtyVal.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleVchQtyVal = await _unitOfWork.SleVchQtyValRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleVchQtyVal == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleVchQtyVal.IsActive = false;
            SleVchQtyVal.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleVchQtyVals = await _unitOfWork.SleVchQtyValRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleVchQtyValsDto = Mapper.Map(SleVchQtyVals);

            return OkResult(CustomMessage.DefaultMessage, SleVchQtyValsDto.ToPagingAndSorting(query), SleVchQtyValsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleVchQtyVal = await _unitOfWork.SleVchQtyValRepository.GetByIdAsync(id);

            if (SleVchQtyVal is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleVchQtyValDto = Mapper.Map(SleVchQtyVal);

            return OkResult( CustomMessage.DefaultMessage , SleVchQtyValDto);

        }
    }
}
