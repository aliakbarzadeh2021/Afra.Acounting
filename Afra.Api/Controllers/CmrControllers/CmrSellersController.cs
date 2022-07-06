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

namespace Afra.Api.Controllers.CmrSellersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrSellersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrSellersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrSellersCommand command)
        {
            command.Validate();

            var CmrSellerss = await _unitOfWork.CmrSellersRepository.FindAsync(c => c.Id == command.Id);

            if (CmrSellerss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrSellers = Mapper.Map(command);
            await _unitOfWork.CmrSellersRepository.AddAsync(newCmrSellers);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrSellersCommand command)
        {

            command.Validate();

            var CmrSellers = await _unitOfWork.CmrSellersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrSellers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrSellers = Mapper.Map(CmrSellers, command);
            CmrSellers.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrSellers = await _unitOfWork.CmrSellersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrSellers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrSellers.IsActive = false;
            CmrSellers.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrSellerss = await _unitOfWork.CmrSellersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrSellerssDto = Mapper.Map(CmrSellerss);

            return OkResult(CustomMessage.DefaultMessage, CmrSellerssDto.ToPagingAndSorting(query), CmrSellerssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrSellers = await _unitOfWork.CmrSellersRepository.GetByIdAsync(id);

            if (CmrSellers is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrSellersDto = Mapper.Map(CmrSellers);

            return OkResult( CustomMessage.DefaultMessage , CmrSellersDto);

        }
    }
}
