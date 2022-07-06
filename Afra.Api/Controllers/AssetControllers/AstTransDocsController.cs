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

namespace Afra.Api.Controllers.AstTransDocsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AstTransDocsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AstTransDocsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAstTransDocsCommand command)
        {
            command.Validate();

            var AstTransDocss = await _unitOfWork.AstTransDocsRepository.FindAsync(c => c.Id == command.Id);

            if (AstTransDocss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAstTransDocs = Mapper.Map(command);
            await _unitOfWork.AstTransDocsRepository.AddAsync(newAstTransDocs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAstTransDocsCommand command)
        {

            command.Validate();

            var AstTransDocs = await _unitOfWork.AstTransDocsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AstTransDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstTransDocs = Mapper.Map(AstTransDocs, command);
            AstTransDocs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AstTransDocs = await _unitOfWork.AstTransDocsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AstTransDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstTransDocs.IsActive = false;
            AstTransDocs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AstTransDocss = await _unitOfWork.AstTransDocsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AstTransDocssDto = Mapper.Map(AstTransDocss);

            return OkResult(CustomMessage.DefaultMessage, AstTransDocssDto.ToPagingAndSorting(query), AstTransDocssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AstTransDocs = await _unitOfWork.AstTransDocsRepository.GetByIdAsync(id);

            if (AstTransDocs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AstTransDocsDto = Mapper.Map(AstTransDocs);

            return OkResult( CustomMessage.DefaultMessage , AstTransDocsDto);

        }
    }
}
