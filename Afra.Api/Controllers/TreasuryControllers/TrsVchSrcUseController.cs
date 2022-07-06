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

namespace Afra.Api.Controllers.TrsVchSrcUseControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsVchSrcUseController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsVchSrcUseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsVchSrcUseCommand command)
        {
            command.Validate();

            var TrsVchSrcUses = await _unitOfWork.TrsVchSrcUseRepository.FindAsync(c => c.Id == command.Id);

            if (TrsVchSrcUses.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsVchSrcUse = Mapper.Map(command);
            await _unitOfWork.TrsVchSrcUseRepository.AddAsync(newTrsVchSrcUse);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsVchSrcUseCommand command)
        {

            command.Validate();

            var TrsVchSrcUse = await _unitOfWork.TrsVchSrcUseRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsVchSrcUse == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsVchSrcUse = Mapper.Map(TrsVchSrcUse, command);
            TrsVchSrcUse.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsVchSrcUse = await _unitOfWork.TrsVchSrcUseRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsVchSrcUse == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsVchSrcUse.IsActive = false;
            TrsVchSrcUse.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsVchSrcUses = await _unitOfWork.TrsVchSrcUseRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsVchSrcUsesDto = Mapper.Map(TrsVchSrcUses);

            return OkResult(CustomMessage.DefaultMessage, TrsVchSrcUsesDto.ToPagingAndSorting(query), TrsVchSrcUsesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsVchSrcUse = await _unitOfWork.TrsVchSrcUseRepository.GetByIdAsync(id);

            if (TrsVchSrcUse is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsVchSrcUseDto = Mapper.Map(TrsVchSrcUse);

            return OkResult( CustomMessage.DefaultMessage , TrsVchSrcUseDto);

        }
    }
}
