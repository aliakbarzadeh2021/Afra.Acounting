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

namespace Afra.Api.Controllers.AstDocsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AstDocsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AstDocsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAstDocsCommand command)
        {
            command.Validate();

            var AstDocss = await _unitOfWork.AstDocsRepository.FindAsync(c => c.Id == command.Id);

            if (AstDocss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAstDocs = Mapper.Map(command);
            await _unitOfWork.AstDocsRepository.AddAsync(newAstDocs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAstDocsCommand command)
        {

            command.Validate();

            var AstDocs = await _unitOfWork.AstDocsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AstDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstDocs = Mapper.Map(AstDocs, command);
            AstDocs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AstDocs = await _unitOfWork.AstDocsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AstDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstDocs.IsActive = false;
            AstDocs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AstDocss = await _unitOfWork.AstDocsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AstDocssDto = Mapper.Map(AstDocss);

            return OkResult(CustomMessage.DefaultMessage, AstDocssDto.ToPagingAndSorting(query), AstDocssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AstDocs = await _unitOfWork.AstDocsRepository.GetByIdAsync(id);

            if (AstDocs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AstDocsDto = Mapper.Map(AstDocs);

            return OkResult( CustomMessage.DefaultMessage , AstDocsDto);

        }
    }
}
