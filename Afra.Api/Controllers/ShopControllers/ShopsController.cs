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

namespace Afra.Api.Controllers.ShopsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ShopsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShopsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddShopsCommand command)
        {
            command.Validate();

            var Shopss = await _unitOfWork.ShopsRepository.FindAsync(c => c.Id == command.Id);

            if (Shopss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newShops = Mapper.Map(command);
            await _unitOfWork.ShopsRepository.AddAsync(newShops);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditShopsCommand command)
        {

            command.Validate();

            var Shops = await _unitOfWork.ShopsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Shops == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Shops = Mapper.Map(Shops, command);
            Shops.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Shops = await _unitOfWork.ShopsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Shops == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Shops.IsActive = false;
            Shops.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Shopss = await _unitOfWork.ShopsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ShopssDto = Mapper.Map(Shopss);

            return OkResult(CustomMessage.DefaultMessage, ShopssDto.ToPagingAndSorting(query), ShopssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Shops = await _unitOfWork.ShopsRepository.GetByIdAsync(id);

            if (Shops is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ShopsDto = Mapper.Map(Shops);

            return OkResult( CustomMessage.DefaultMessage , ShopsDto);

        }
    }
}
