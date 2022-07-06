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

namespace Afra.Api.Controllers.AstAssetCostControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AstAssetCostController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AstAssetCostController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAstAssetCostCommand command)
        {
            command.Validate();

            var AstAssetCosts = await _unitOfWork.AstAssetCostRepository.FindAsync(c => c.Id == command.Id);

            if (AstAssetCosts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAstAssetCost = Mapper.Map(command);
            await _unitOfWork.AstAssetCostRepository.AddAsync(newAstAssetCost);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAstAssetCostCommand command)
        {

            command.Validate();

            var AstAssetCost = await _unitOfWork.AstAssetCostRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AstAssetCost == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstAssetCost = Mapper.Map(AstAssetCost, command);
            AstAssetCost.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AstAssetCost = await _unitOfWork.AstAssetCostRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AstAssetCost == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstAssetCost.IsActive = false;
            AstAssetCost.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AstAssetCosts = await _unitOfWork.AstAssetCostRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AstAssetCostsDto = Mapper.Map(AstAssetCosts);

            return OkResult(CustomMessage.DefaultMessage, AstAssetCostsDto.ToPagingAndSorting(query), AstAssetCostsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AstAssetCost = await _unitOfWork.AstAssetCostRepository.GetByIdAsync(id);

            if (AstAssetCost is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AstAssetCostDto = Mapper.Map(AstAssetCost);

            return OkResult( CustomMessage.DefaultMessage , AstAssetCostDto);

        }
    }
}
