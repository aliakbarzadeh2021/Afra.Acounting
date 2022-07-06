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

namespace Afra.Api.Controllers.CntCrsDocumentControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntCrsDocumentController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntCrsDocumentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntCrsDocumentCommand command)
        {
            command.Validate();

            var CntCrsDocuments = await _unitOfWork.CntCrsDocumentRepository.FindAsync(c => c.Id == command.Id);

            if (CntCrsDocuments.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntCrsDocument = Mapper.Map(command);
            await _unitOfWork.CntCrsDocumentRepository.AddAsync(newCntCrsDocument);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntCrsDocumentCommand command)
        {

            command.Validate();

            var CntCrsDocument = await _unitOfWork.CntCrsDocumentRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntCrsDocument == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntCrsDocument = Mapper.Map(CntCrsDocument, command);
            CntCrsDocument.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntCrsDocument = await _unitOfWork.CntCrsDocumentRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntCrsDocument == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntCrsDocument.IsActive = false;
            CntCrsDocument.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntCrsDocuments = await _unitOfWork.CntCrsDocumentRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntCrsDocumentsDto = Mapper.Map(CntCrsDocuments);

            return OkResult(CustomMessage.DefaultMessage, CntCrsDocumentsDto.ToPagingAndSorting(query), CntCrsDocumentsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntCrsDocument = await _unitOfWork.CntCrsDocumentRepository.GetByIdAsync(id);

            if (CntCrsDocument is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntCrsDocumentDto = Mapper.Map(CntCrsDocument);

            return OkResult( CustomMessage.DefaultMessage , CntCrsDocumentDto);

        }
    }
}
