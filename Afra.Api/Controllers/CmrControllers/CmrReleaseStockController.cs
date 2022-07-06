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

namespace Afra.Api.Controllers.CmrReleaseStockControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrReleaseStockController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrReleaseStockController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrReleaseStockCommand command)
        {
            command.Validate();

            var CmrReleaseStocks = await _unitOfWork.CmrReleaseStockRepository.FindAsync(c => c.Id == command.Id);

            if (CmrReleaseStocks.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrReleaseStock = Mapper.Map(command);
            await _unitOfWork.CmrReleaseStockRepository.AddAsync(newCmrReleaseStock);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrReleaseStockCommand command)
        {

            command.Validate();

            var CmrReleaseStock = await _unitOfWork.CmrReleaseStockRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrReleaseStock == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrReleaseStock = Mapper.Map(CmrReleaseStock, command);
            CmrReleaseStock.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrReleaseStock = await _unitOfWork.CmrReleaseStockRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrReleaseStock == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrReleaseStock.IsActive = false;
            CmrReleaseStock.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrReleaseStocks = await _unitOfWork.CmrReleaseStockRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrReleaseStocksDto = Mapper.Map(CmrReleaseStocks);

            return OkResult(CustomMessage.DefaultMessage, CmrReleaseStocksDto.ToPagingAndSorting(query), CmrReleaseStocksDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrReleaseStock = await _unitOfWork.CmrReleaseStockRepository.GetByIdAsync(id);

            if (CmrReleaseStock is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrReleaseStockDto = Mapper.Map(CmrReleaseStock);

            return OkResult( CustomMessage.DefaultMessage , CmrReleaseStockDto);

        }
    }
}
