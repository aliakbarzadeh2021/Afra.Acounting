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

namespace Afra.Api.Controllers.AstAssetGrpControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AstAssetGrpController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AstAssetGrpController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAstAssetGrpCommand command)
        {
            command.Validate();

            var AstAssetGrps = await _unitOfWork.AstAssetGrpRepository.FindAsync(c => c.Id == command.Id);

            if (AstAssetGrps.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAstAssetGrp = Mapper.Map(command);
            await _unitOfWork.AstAssetGrpRepository.AddAsync(newAstAssetGrp);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAstAssetGrpCommand command)
        {

            command.Validate();

            var AstAssetGrp = await _unitOfWork.AstAssetGrpRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AstAssetGrp == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstAssetGrp = Mapper.Map(AstAssetGrp, command);
            AstAssetGrp.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AstAssetGrp = await _unitOfWork.AstAssetGrpRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AstAssetGrp == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstAssetGrp.IsActive = false;
            AstAssetGrp.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AstAssetGrps = await _unitOfWork.AstAssetGrpRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AstAssetGrpsDto = Mapper.Map(AstAssetGrps);

            return OkResult(CustomMessage.DefaultMessage, AstAssetGrpsDto.ToPagingAndSorting(query), AstAssetGrpsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AstAssetGrp = await _unitOfWork.AstAssetGrpRepository.GetByIdAsync(id);

            if (AstAssetGrp is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AstAssetGrpDto = Mapper.Map(AstAssetGrp);

            return OkResult( CustomMessage.DefaultMessage , AstAssetGrpDto);

        }
    }
}
