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

namespace Afra.Api.Controllers.TrsSourceUseControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsSourceUseController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsSourceUseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsSourceUseCommand command)
        {
            command.Validate();

            var TrsSourceUses = await _unitOfWork.TrsSourceUseRepository.FindAsync(c => c.Id == command.Id);

            if (TrsSourceUses.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsSourceUse = Mapper.Map(command);
            await _unitOfWork.TrsSourceUseRepository.AddAsync(newTrsSourceUse);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsSourceUseCommand command)
        {

            command.Validate();

            var TrsSourceUse = await _unitOfWork.TrsSourceUseRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsSourceUse == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsSourceUse = Mapper.Map(TrsSourceUse, command);
            TrsSourceUse.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsSourceUse = await _unitOfWork.TrsSourceUseRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsSourceUse == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsSourceUse.IsActive = false;
            TrsSourceUse.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsSourceUses = await _unitOfWork.TrsSourceUseRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsSourceUsesDto = Mapper.Map(TrsSourceUses);

            return OkResult(CustomMessage.DefaultMessage, TrsSourceUsesDto.ToPagingAndSorting(query), TrsSourceUsesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsSourceUse = await _unitOfWork.TrsSourceUseRepository.GetByIdAsync(id);

            if (TrsSourceUse is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsSourceUseDto = Mapper.Map(TrsSourceUse);

            return OkResult( CustomMessage.DefaultMessage , TrsSourceUseDto);

        }
    }
}
