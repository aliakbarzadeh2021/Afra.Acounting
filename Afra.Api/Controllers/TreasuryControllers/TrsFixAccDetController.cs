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

namespace Afra.Api.Controllers.TrsFixAccDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFixAccDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFixAccDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFixAccDetCommand command)
        {
            command.Validate();

            var TrsFixAccDets = await _unitOfWork.TrsFixAccDetRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFixAccDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFixAccDet = Mapper.Map(command);
            await _unitOfWork.TrsFixAccDetRepository.AddAsync(newTrsFixAccDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFixAccDetCommand command)
        {

            command.Validate();

            var TrsFixAccDet = await _unitOfWork.TrsFixAccDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFixAccDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFixAccDet = Mapper.Map(TrsFixAccDet, command);
            TrsFixAccDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFixAccDet = await _unitOfWork.TrsFixAccDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFixAccDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFixAccDet.IsActive = false;
            TrsFixAccDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFixAccDets = await _unitOfWork.TrsFixAccDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFixAccDetsDto = Mapper.Map(TrsFixAccDets);

            return OkResult(CustomMessage.DefaultMessage, TrsFixAccDetsDto.ToPagingAndSorting(query), TrsFixAccDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFixAccDet = await _unitOfWork.TrsFixAccDetRepository.GetByIdAsync(id);

            if (TrsFixAccDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFixAccDetDto = Mapper.Map(TrsFixAccDet);

            return OkResult( CustomMessage.DefaultMessage , TrsFixAccDetDto);

        }
    }
}
