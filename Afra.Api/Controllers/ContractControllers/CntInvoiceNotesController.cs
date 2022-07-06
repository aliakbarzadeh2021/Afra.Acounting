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

namespace Afra.Api.Controllers.CntInvoiceNotesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntInvoiceNotesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntInvoiceNotesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntInvoiceNotesCommand command)
        {
            command.Validate();

            var CntInvoiceNotess = await _unitOfWork.CntInvoiceNotesRepository.FindAsync(c => c.Id == command.Id);

            if (CntInvoiceNotess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntInvoiceNotes = Mapper.Map(command);
            await _unitOfWork.CntInvoiceNotesRepository.AddAsync(newCntInvoiceNotes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntInvoiceNotesCommand command)
        {

            command.Validate();

            var CntInvoiceNotes = await _unitOfWork.CntInvoiceNotesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntInvoiceNotes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntInvoiceNotes = Mapper.Map(CntInvoiceNotes, command);
            CntInvoiceNotes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntInvoiceNotes = await _unitOfWork.CntInvoiceNotesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntInvoiceNotes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntInvoiceNotes.IsActive = false;
            CntInvoiceNotes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntInvoiceNotess = await _unitOfWork.CntInvoiceNotesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntInvoiceNotessDto = Mapper.Map(CntInvoiceNotess);

            return OkResult(CustomMessage.DefaultMessage, CntInvoiceNotessDto.ToPagingAndSorting(query), CntInvoiceNotessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntInvoiceNotes = await _unitOfWork.CntInvoiceNotesRepository.GetByIdAsync(id);

            if (CntInvoiceNotes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntInvoiceNotesDto = Mapper.Map(CntInvoiceNotes);

            return OkResult( CustomMessage.DefaultMessage , CntInvoiceNotesDto);

        }
    }
}
