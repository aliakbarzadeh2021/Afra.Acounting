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

namespace Afra.Api.Controllers.StkStockTransControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class StkStockTransController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StkStockTransController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddStkStockTransCommand command)
        {
            command.Validate();

            var StkStockTranss = await _unitOfWork.StkStockTransRepository.FindAsync(c => c.Id == command.Id);

            if (StkStockTranss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newStkStockTrans = Mapper.Map(command);
            await _unitOfWork.StkStockTransRepository.AddAsync(newStkStockTrans);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditStkStockTransCommand command)
        {

            command.Validate();

            var StkStockTrans = await _unitOfWork.StkStockTransRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (StkStockTrans == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StkStockTrans = Mapper.Map(StkStockTrans, command);
            StkStockTrans.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var StkStockTrans = await _unitOfWork.StkStockTransRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (StkStockTrans == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StkStockTrans.IsActive = false;
            StkStockTrans.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var StkStockTranss = await _unitOfWork.StkStockTransRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var StkStockTranssDto = Mapper.Map(StkStockTranss);

            return OkResult(CustomMessage.DefaultMessage, StkStockTranssDto.ToPagingAndSorting(query), StkStockTranssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var StkStockTrans = await _unitOfWork.StkStockTransRepository.GetByIdAsync(id);

            if (StkStockTrans is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var StkStockTransDto = Mapper.Map(StkStockTrans);

            return OkResult( CustomMessage.DefaultMessage , StkStockTransDto);

        }
    }
}
