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

namespace Afra.Api.Controllers.StkStockersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class StkStockersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StkStockersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddStkStockersCommand command)
        {
            command.Validate();

            var StkStockerss = await _unitOfWork.StkStockersRepository.FindAsync(c => c.Id == command.Id);

            if (StkStockerss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newStkStockers = Mapper.Map(command);
            await _unitOfWork.StkStockersRepository.AddAsync(newStkStockers);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditStkStockersCommand command)
        {

            command.Validate();

            var StkStockers = await _unitOfWork.StkStockersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (StkStockers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StkStockers = Mapper.Map(StkStockers, command);
            StkStockers.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var StkStockers = await _unitOfWork.StkStockersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (StkStockers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StkStockers.IsActive = false;
            StkStockers.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var StkStockerss = await _unitOfWork.StkStockersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var StkStockerssDto = Mapper.Map(StkStockerss);

            return OkResult(CustomMessage.DefaultMessage, StkStockerssDto.ToPagingAndSorting(query), StkStockerssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var StkStockers = await _unitOfWork.StkStockersRepository.GetByIdAsync(id);

            if (StkStockers is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var StkStockersDto = Mapper.Map(StkStockers);

            return OkResult( CustomMessage.DefaultMessage , StkStockersDto);

        }
    }
}
