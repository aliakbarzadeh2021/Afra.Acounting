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

namespace Afra.Api.Controllers.OtoLttrDocControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoLttrDocController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoLttrDocController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoLttrDocCommand command)
        {
            command.Validate();

            var OtoLttrDocs = await _unitOfWork.OtoLttrDocRepository.FindAsync(c => c.Id == command.Id);

            if (OtoLttrDocs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoLttrDoc = Mapper.Map(command);
            await _unitOfWork.OtoLttrDocRepository.AddAsync(newOtoLttrDoc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoLttrDocCommand command)
        {

            command.Validate();

            var OtoLttrDoc = await _unitOfWork.OtoLttrDocRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoLttrDoc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoLttrDoc = Mapper.Map(OtoLttrDoc, command);
            OtoLttrDoc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoLttrDoc = await _unitOfWork.OtoLttrDocRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoLttrDoc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoLttrDoc.IsActive = false;
            OtoLttrDoc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoLttrDocs = await _unitOfWork.OtoLttrDocRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoLttrDocsDto = Mapper.Map(OtoLttrDocs);

            return OkResult(CustomMessage.DefaultMessage, OtoLttrDocsDto.ToPagingAndSorting(query), OtoLttrDocsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoLttrDoc = await _unitOfWork.OtoLttrDocRepository.GetByIdAsync(id);

            if (OtoLttrDoc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoLttrDocDto = Mapper.Map(OtoLttrDoc);

            return OkResult( CustomMessage.DefaultMessage , OtoLttrDocDto);

        }
    }
}
