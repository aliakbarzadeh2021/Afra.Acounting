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

namespace Afra.Api.Controllers.ShopPartPriceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ShopPartPriceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShopPartPriceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddShopPartPriceCommand command)
        {
            command.Validate();

            var ShopPartPrices = await _unitOfWork.ShopPartPriceRepository.FindAsync(c => c.Id == command.Id);

            if (ShopPartPrices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newShopPartPrice = Mapper.Map(command);
            await _unitOfWork.ShopPartPriceRepository.AddAsync(newShopPartPrice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditShopPartPriceCommand command)
        {

            command.Validate();

            var ShopPartPrice = await _unitOfWork.ShopPartPriceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ShopPartPrice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ShopPartPrice = Mapper.Map(ShopPartPrice, command);
            ShopPartPrice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ShopPartPrice = await _unitOfWork.ShopPartPriceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ShopPartPrice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ShopPartPrice.IsActive = false;
            ShopPartPrice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ShopPartPrices = await _unitOfWork.ShopPartPriceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ShopPartPricesDto = Mapper.Map(ShopPartPrices);

            return OkResult(CustomMessage.DefaultMessage, ShopPartPricesDto.ToPagingAndSorting(query), ShopPartPricesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ShopPartPrice = await _unitOfWork.ShopPartPriceRepository.GetByIdAsync(id);

            if (ShopPartPrice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ShopPartPriceDto = Mapper.Map(ShopPartPrice);

            return OkResult( CustomMessage.DefaultMessage , ShopPartPriceDto);

        }
    }
}
