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

namespace Afra.Api.Controllers.TrsChqFmtControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsChqFmtController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsChqFmtController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsChqFmtCommand command)
        {
            command.Validate();

            var TrsChqFmts = await _unitOfWork.TrsChqFmtRepository.FindAsync(c => c.Id == command.Id);

            if (TrsChqFmts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsChqFmt = Mapper.Map(command);
            await _unitOfWork.TrsChqFmtRepository.AddAsync(newTrsChqFmt);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsChqFmtCommand command)
        {

            command.Validate();

            var TrsChqFmt = await _unitOfWork.TrsChqFmtRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsChqFmt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsChqFmt = Mapper.Map(TrsChqFmt, command);
            TrsChqFmt.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsChqFmt = await _unitOfWork.TrsChqFmtRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsChqFmt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsChqFmt.IsActive = false;
            TrsChqFmt.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsChqFmts = await _unitOfWork.TrsChqFmtRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsChqFmtsDto = Mapper.Map(TrsChqFmts);

            return OkResult(CustomMessage.DefaultMessage, TrsChqFmtsDto.ToPagingAndSorting(query), TrsChqFmtsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsChqFmt = await _unitOfWork.TrsChqFmtRepository.GetByIdAsync(id);

            if (TrsChqFmt is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsChqFmtDto = Mapper.Map(TrsChqFmt);

            return OkResult( CustomMessage.DefaultMessage , TrsChqFmtDto);

        }
    }
}
