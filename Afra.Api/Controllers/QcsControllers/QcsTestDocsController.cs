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

namespace Afra.Api.Controllers.QcsTestDocsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QcsTestDocsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QcsTestDocsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQcsTestDocsCommand command)
        {
            command.Validate();

            var QcsTestDocss = await _unitOfWork.QcsTestDocsRepository.FindAsync(c => c.Id == command.Id);

            if (QcsTestDocss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQcsTestDocs = Mapper.Map(command);
            await _unitOfWork.QcsTestDocsRepository.AddAsync(newQcsTestDocs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQcsTestDocsCommand command)
        {

            command.Validate();

            var QcsTestDocs = await _unitOfWork.QcsTestDocsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (QcsTestDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsTestDocs = Mapper.Map(QcsTestDocs, command);
            QcsTestDocs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var QcsTestDocs = await _unitOfWork.QcsTestDocsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (QcsTestDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsTestDocs.IsActive = false;
            QcsTestDocs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var QcsTestDocss = await _unitOfWork.QcsTestDocsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QcsTestDocssDto = Mapper.Map(QcsTestDocss);

            return OkResult(CustomMessage.DefaultMessage, QcsTestDocssDto.ToPagingAndSorting(query), QcsTestDocssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var QcsTestDocs = await _unitOfWork.QcsTestDocsRepository.GetByIdAsync(id);

            if (QcsTestDocs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QcsTestDocsDto = Mapper.Map(QcsTestDocs);

            return OkResult( CustomMessage.DefaultMessage , QcsTestDocsDto);

        }
    }
}
