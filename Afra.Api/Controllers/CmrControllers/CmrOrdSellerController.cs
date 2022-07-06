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

namespace Afra.Api.Controllers.CmrOrdSellerControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrOrdSellerController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrOrdSellerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrOrdSellerCommand command)
        {
            command.Validate();

            var CmrOrdSellers = await _unitOfWork.CmrOrdSellerRepository.FindAsync(c => c.Id == command.Id);

            if (CmrOrdSellers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrOrdSeller = Mapper.Map(command);
            await _unitOfWork.CmrOrdSellerRepository.AddAsync(newCmrOrdSeller);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrOrdSellerCommand command)
        {

            command.Validate();

            var CmrOrdSeller = await _unitOfWork.CmrOrdSellerRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrOrdSeller == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrOrdSeller = Mapper.Map(CmrOrdSeller, command);
            CmrOrdSeller.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrOrdSeller = await _unitOfWork.CmrOrdSellerRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrOrdSeller == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrOrdSeller.IsActive = false;
            CmrOrdSeller.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrOrdSellers = await _unitOfWork.CmrOrdSellerRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrOrdSellersDto = Mapper.Map(CmrOrdSellers);

            return OkResult(CustomMessage.DefaultMessage, CmrOrdSellersDto.ToPagingAndSorting(query), CmrOrdSellersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrOrdSeller = await _unitOfWork.CmrOrdSellerRepository.GetByIdAsync(id);

            if (CmrOrdSeller is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrOrdSellerDto = Mapper.Map(CmrOrdSeller);

            return OkResult( CustomMessage.DefaultMessage , CmrOrdSellerDto);

        }
    }
}
