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

namespace Afra.Api.Controllers.AstRatioDocsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AstRatioDocsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AstRatioDocsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAstRatioDocsCommand command)
        {
            command.Validate();

            var AstRatioDocss = await _unitOfWork.AstRatioDocsRepository.FindAsync(c => c.Id == command.Id);

            if (AstRatioDocss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAstRatioDocs = Mapper.Map(command);
            await _unitOfWork.AstRatioDocsRepository.AddAsync(newAstRatioDocs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAstRatioDocsCommand command)
        {

            command.Validate();

            var AstRatioDocs = await _unitOfWork.AstRatioDocsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AstRatioDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstRatioDocs = Mapper.Map(AstRatioDocs, command);
            AstRatioDocs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AstRatioDocs = await _unitOfWork.AstRatioDocsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AstRatioDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstRatioDocs.IsActive = false;
            AstRatioDocs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AstRatioDocss = await _unitOfWork.AstRatioDocsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AstRatioDocssDto = Mapper.Map(AstRatioDocss);

            return OkResult(CustomMessage.DefaultMessage, AstRatioDocssDto.ToPagingAndSorting(query), AstRatioDocssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AstRatioDocs = await _unitOfWork.AstRatioDocsRepository.GetByIdAsync(id);

            if (AstRatioDocs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AstRatioDocsDto = Mapper.Map(AstRatioDocs);

            return OkResult( CustomMessage.DefaultMessage , AstRatioDocsDto);

        }
    }
}
