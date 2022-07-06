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

namespace Afra.Api.Controllers.AstCostDocsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AstCostDocsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AstCostDocsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAstCostDocsCommand command)
        {
            command.Validate();

            var AstCostDocss = await _unitOfWork.AstCostDocsRepository.FindAsync(c => c.Id == command.Id);

            if (AstCostDocss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAstCostDocs = Mapper.Map(command);
            await _unitOfWork.AstCostDocsRepository.AddAsync(newAstCostDocs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAstCostDocsCommand command)
        {

            command.Validate();

            var AstCostDocs = await _unitOfWork.AstCostDocsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AstCostDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstCostDocs = Mapper.Map(AstCostDocs, command);
            AstCostDocs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AstCostDocs = await _unitOfWork.AstCostDocsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AstCostDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstCostDocs.IsActive = false;
            AstCostDocs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AstCostDocss = await _unitOfWork.AstCostDocsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AstCostDocssDto = Mapper.Map(AstCostDocss);

            return OkResult(CustomMessage.DefaultMessage, AstCostDocssDto.ToPagingAndSorting(query), AstCostDocssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AstCostDocs = await _unitOfWork.AstCostDocsRepository.GetByIdAsync(id);

            if (AstCostDocs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AstCostDocsDto = Mapper.Map(AstCostDocs);

            return OkResult( CustomMessage.DefaultMessage , AstCostDocsDto);

        }
    }
}
