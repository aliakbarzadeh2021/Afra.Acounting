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

namespace Afra.Api.Controllers.AccNoteHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccNoteHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccNoteHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccNoteHdrCommand command)
        {
            command.Validate();

            var AccNoteHdrs = await _unitOfWork.AccNoteHdrRepository.FindAsync(c => c.Id == command.Id);

            if (AccNoteHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccNoteHdr = Mapper.Map(command);
            await _unitOfWork.AccNoteHdrRepository.AddAsync(newAccNoteHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccNoteHdrCommand command)
        {

            command.Validate();

            var AccNoteHdr = await _unitOfWork.AccNoteHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccNoteHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccNoteHdr = Mapper.Map(AccNoteHdr, command);
            AccNoteHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccNoteHdr = await _unitOfWork.AccNoteHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccNoteHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccNoteHdr.IsActive = false;
            AccNoteHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccNoteHdrs = await _unitOfWork.AccNoteHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccNoteHdrsDto = Mapper.Map(AccNoteHdrs);

            return OkResult(CustomMessage.DefaultMessage, AccNoteHdrsDto.ToPagingAndSorting(query), AccNoteHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccNoteHdr = await _unitOfWork.AccNoteHdrRepository.GetByIdAsync(id);

            if (AccNoteHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccNoteHdrDto = Mapper.Map(AccNoteHdr);

            return OkResult( CustomMessage.DefaultMessage , AccNoteHdrDto);

        }
    }
}
