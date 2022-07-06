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

namespace Afra.Api.Controllers.UsrPersHrmRelsDocControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrPersHrmRelsDocController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrPersHrmRelsDocController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrPersHrmRelsDocCommand command)
        {
            command.Validate();

            var UsrPersHrmRelsDocs = await _unitOfWork.UsrPersHrmRelsDocRepository.FindAsync(c => c.Id == command.Id);

            if (UsrPersHrmRelsDocs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrPersHrmRelsDoc = Mapper.Map(command);
            await _unitOfWork.UsrPersHrmRelsDocRepository.AddAsync(newUsrPersHrmRelsDoc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrPersHrmRelsDocCommand command)
        {

            command.Validate();

            var UsrPersHrmRelsDoc = await _unitOfWork.UsrPersHrmRelsDocRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrPersHrmRelsDoc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrPersHrmRelsDoc = Mapper.Map(UsrPersHrmRelsDoc, command);
            UsrPersHrmRelsDoc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrPersHrmRelsDoc = await _unitOfWork.UsrPersHrmRelsDocRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrPersHrmRelsDoc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrPersHrmRelsDoc.IsActive = false;
            UsrPersHrmRelsDoc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrPersHrmRelsDocs = await _unitOfWork.UsrPersHrmRelsDocRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrPersHrmRelsDocsDto = Mapper.Map(UsrPersHrmRelsDocs);

            return OkResult(CustomMessage.DefaultMessage, UsrPersHrmRelsDocsDto.ToPagingAndSorting(query), UsrPersHrmRelsDocsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrPersHrmRelsDoc = await _unitOfWork.UsrPersHrmRelsDocRepository.GetByIdAsync(id);

            if (UsrPersHrmRelsDoc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrPersHrmRelsDocDto = Mapper.Map(UsrPersHrmRelsDoc);

            return OkResult( CustomMessage.DefaultMessage , UsrPersHrmRelsDocDto);

        }
    }
}
