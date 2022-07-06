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

namespace Afra.Api.Controllers.ShopGiftCardControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ShopGiftCardController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShopGiftCardController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddShopGiftCardCommand command)
        {
            command.Validate();

            var ShopGiftCards = await _unitOfWork.ShopGiftCardRepository.FindAsync(c => c.Id == command.Id);

            if (ShopGiftCards.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newShopGiftCard = Mapper.Map(command);
            await _unitOfWork.ShopGiftCardRepository.AddAsync(newShopGiftCard);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditShopGiftCardCommand command)
        {

            command.Validate();

            var ShopGiftCard = await _unitOfWork.ShopGiftCardRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ShopGiftCard == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ShopGiftCard = Mapper.Map(ShopGiftCard, command);
            ShopGiftCard.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ShopGiftCard = await _unitOfWork.ShopGiftCardRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ShopGiftCard == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ShopGiftCard.IsActive = false;
            ShopGiftCard.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ShopGiftCards = await _unitOfWork.ShopGiftCardRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ShopGiftCardsDto = Mapper.Map(ShopGiftCards);

            return OkResult(CustomMessage.DefaultMessage, ShopGiftCardsDto.ToPagingAndSorting(query), ShopGiftCardsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ShopGiftCard = await _unitOfWork.ShopGiftCardRepository.GetByIdAsync(id);

            if (ShopGiftCard is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ShopGiftCardDto = Mapper.Map(ShopGiftCard);

            return OkResult( CustomMessage.DefaultMessage , ShopGiftCardDto);

        }
    }
}
