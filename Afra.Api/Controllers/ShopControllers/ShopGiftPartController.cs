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

namespace Afra.Api.Controllers.ShopGiftPartControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ShopGiftPartController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShopGiftPartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddShopGiftPartCommand command)
        {
            command.Validate();

            var ShopGiftParts = await _unitOfWork.ShopGiftPartRepository.FindAsync(c => c.Id == command.Id);

            if (ShopGiftParts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newShopGiftPart = Mapper.Map(command);
            await _unitOfWork.ShopGiftPartRepository.AddAsync(newShopGiftPart);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditShopGiftPartCommand command)
        {

            command.Validate();

            var ShopGiftPart = await _unitOfWork.ShopGiftPartRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ShopGiftPart == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ShopGiftPart = Mapper.Map(ShopGiftPart, command);
            ShopGiftPart.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ShopGiftPart = await _unitOfWork.ShopGiftPartRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ShopGiftPart == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ShopGiftPart.IsActive = false;
            ShopGiftPart.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ShopGiftParts = await _unitOfWork.ShopGiftPartRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ShopGiftPartsDto = Mapper.Map(ShopGiftParts);

            return OkResult(CustomMessage.DefaultMessage, ShopGiftPartsDto.ToPagingAndSorting(query), ShopGiftPartsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ShopGiftPart = await _unitOfWork.ShopGiftPartRepository.GetByIdAsync(id);

            if (ShopGiftPart is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ShopGiftPartDto = Mapper.Map(ShopGiftPart);

            return OkResult( CustomMessage.DefaultMessage , ShopGiftPartDto);

        }
    }
}
