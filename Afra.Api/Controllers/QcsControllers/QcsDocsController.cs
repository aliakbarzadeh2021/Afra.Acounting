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

namespace Afra.Api.Controllers.QcsDocsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QcsDocsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QcsDocsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQcsDocsCommand command)
        {
            command.Validate();

            var QcsDocss = await _unitOfWork.QcsDocsRepository.FindAsync(c => c.Id == command.Id);

            if (QcsDocss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQcsDocs = Mapper.Map(command);
            await _unitOfWork.QcsDocsRepository.AddAsync(newQcsDocs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQcsDocsCommand command)
        {

            command.Validate();

            var QcsDocs = await _unitOfWork.QcsDocsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (QcsDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsDocs = Mapper.Map(QcsDocs, command);
            QcsDocs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var QcsDocs = await _unitOfWork.QcsDocsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (QcsDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsDocs.IsActive = false;
            QcsDocs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var QcsDocss = await _unitOfWork.QcsDocsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QcsDocssDto = Mapper.Map(QcsDocss);

            return OkResult(CustomMessage.DefaultMessage, QcsDocssDto.ToPagingAndSorting(query), QcsDocssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var QcsDocs = await _unitOfWork.QcsDocsRepository.GetByIdAsync(id);

            if (QcsDocs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QcsDocsDto = Mapper.Map(QcsDocs);

            return OkResult( CustomMessage.DefaultMessage , QcsDocsDto);

        }
    }
}
