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

namespace Afra.Api.Controllers.InvStockControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvStockController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvStockController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvStockCommand command)
        {
            command.Validate();

            var InvStocks = await _unitOfWork.InvStockRepository.FindAsync(c => c.Id == command.Id);

            if (InvStocks.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvStock = Mapper.Map(command);
            await _unitOfWork.InvStockRepository.AddAsync(newInvStock);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvStockCommand command)
        {

            command.Validate();

            var InvStock = await _unitOfWork.InvStockRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvStock == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvStock = Mapper.Map(InvStock, command);
            InvStock.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvStock = await _unitOfWork.InvStockRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvStock == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvStock.IsActive = false;
            InvStock.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvStocks = await _unitOfWork.InvStockRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvStocksDto = Mapper.Map(InvStocks);

            return OkResult(CustomMessage.DefaultMessage, InvStocksDto.ToPagingAndSorting(query), InvStocksDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvStock = await _unitOfWork.InvStockRepository.GetByIdAsync(id);

            if (InvStock is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvStockDto = Mapper.Map(InvStock);

            return OkResult( CustomMessage.DefaultMessage , InvStockDto);

        }
    }
}
