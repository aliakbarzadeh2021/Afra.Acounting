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

namespace Afra.Api.Controllers.OtoQuickNoteControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoQuickNoteController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoQuickNoteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoQuickNoteCommand command)
        {
            command.Validate();

            var OtoQuickNotes = await _unitOfWork.OtoQuickNoteRepository.FindAsync(c => c.Id == command.Id);

            if (OtoQuickNotes.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoQuickNote = Mapper.Map(command);
            await _unitOfWork.OtoQuickNoteRepository.AddAsync(newOtoQuickNote);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoQuickNoteCommand command)
        {

            command.Validate();

            var OtoQuickNote = await _unitOfWork.OtoQuickNoteRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoQuickNote == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoQuickNote = Mapper.Map(OtoQuickNote, command);
            OtoQuickNote.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoQuickNote = await _unitOfWork.OtoQuickNoteRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoQuickNote == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoQuickNote.IsActive = false;
            OtoQuickNote.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoQuickNotes = await _unitOfWork.OtoQuickNoteRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoQuickNotesDto = Mapper.Map(OtoQuickNotes);

            return OkResult(CustomMessage.DefaultMessage, OtoQuickNotesDto.ToPagingAndSorting(query), OtoQuickNotesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoQuickNote = await _unitOfWork.OtoQuickNoteRepository.GetByIdAsync(id);

            if (OtoQuickNote is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoQuickNoteDto = Mapper.Map(OtoQuickNote);

            return OkResult( CustomMessage.DefaultMessage , OtoQuickNoteDto);

        }
    }
}
