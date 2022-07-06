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

namespace Afra.Api.Controllers.AstAssetSaleControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AstAssetSaleController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AstAssetSaleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAstAssetSaleCommand command)
        {
            command.Validate();

            var AstAssetSales = await _unitOfWork.AstAssetSaleRepository.FindAsync(c => c.Id == command.Id);

            if (AstAssetSales.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAstAssetSale = Mapper.Map(command);
            await _unitOfWork.AstAssetSaleRepository.AddAsync(newAstAssetSale);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAstAssetSaleCommand command)
        {

            command.Validate();

            var AstAssetSale = await _unitOfWork.AstAssetSaleRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AstAssetSale == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstAssetSale = Mapper.Map(AstAssetSale, command);
            AstAssetSale.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AstAssetSale = await _unitOfWork.AstAssetSaleRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AstAssetSale == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstAssetSale.IsActive = false;
            AstAssetSale.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AstAssetSales = await _unitOfWork.AstAssetSaleRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AstAssetSalesDto = Mapper.Map(AstAssetSales);

            return OkResult(CustomMessage.DefaultMessage, AstAssetSalesDto.ToPagingAndSorting(query), AstAssetSalesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AstAssetSale = await _unitOfWork.AstAssetSaleRepository.GetByIdAsync(id);

            if (AstAssetSale is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AstAssetSaleDto = Mapper.Map(AstAssetSale);

            return OkResult( CustomMessage.DefaultMessage , AstAssetSaleDto);

        }
    }
}
