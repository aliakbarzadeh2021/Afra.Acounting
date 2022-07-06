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

namespace Afra.Api.Controllers.AstAssetDeprControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AstAssetDeprController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AstAssetDeprController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAstAssetDeprCommand command)
        {
            command.Validate();

            var AstAssetDeprs = await _unitOfWork.AstAssetDeprRepository.FindAsync(c => c.Id == command.Id);

            if (AstAssetDeprs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAstAssetDepr = Mapper.Map(command);
            await _unitOfWork.AstAssetDeprRepository.AddAsync(newAstAssetDepr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAstAssetDeprCommand command)
        {

            command.Validate();

            var AstAssetDepr = await _unitOfWork.AstAssetDeprRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AstAssetDepr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstAssetDepr = Mapper.Map(AstAssetDepr, command);
            AstAssetDepr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AstAssetDepr = await _unitOfWork.AstAssetDeprRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AstAssetDepr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstAssetDepr.IsActive = false;
            AstAssetDepr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AstAssetDeprs = await _unitOfWork.AstAssetDeprRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AstAssetDeprsDto = Mapper.Map(AstAssetDeprs);

            return OkResult(CustomMessage.DefaultMessage, AstAssetDeprsDto.ToPagingAndSorting(query), AstAssetDeprsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AstAssetDepr = await _unitOfWork.AstAssetDeprRepository.GetByIdAsync(id);

            if (AstAssetDepr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AstAssetDeprDto = Mapper.Map(AstAssetDepr);

            return OkResult( CustomMessage.DefaultMessage , AstAssetDeprDto);

        }
    }
}
