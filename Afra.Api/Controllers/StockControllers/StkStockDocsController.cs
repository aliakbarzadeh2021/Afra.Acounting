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

namespace Afra.Api.Controllers.StkStockDocsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class StkStockDocsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StkStockDocsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddStkStockDocsCommand command)
        {
            command.Validate();

            var StkStockDocss = await _unitOfWork.StkStockDocsRepository.FindAsync(c => c.Id == command.Id);

            if (StkStockDocss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newStkStockDocs = Mapper.Map(command);
            await _unitOfWork.StkStockDocsRepository.AddAsync(newStkStockDocs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditStkStockDocsCommand command)
        {

            command.Validate();

            var StkStockDocs = await _unitOfWork.StkStockDocsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (StkStockDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StkStockDocs = Mapper.Map(StkStockDocs, command);
            StkStockDocs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var StkStockDocs = await _unitOfWork.StkStockDocsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (StkStockDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StkStockDocs.IsActive = false;
            StkStockDocs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var StkStockDocss = await _unitOfWork.StkStockDocsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var StkStockDocssDto = Mapper.Map(StkStockDocss);

            return OkResult(CustomMessage.DefaultMessage, StkStockDocssDto.ToPagingAndSorting(query), StkStockDocssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var StkStockDocs = await _unitOfWork.StkStockDocsRepository.GetByIdAsync(id);

            if (StkStockDocs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var StkStockDocsDto = Mapper.Map(StkStockDocs);

            return OkResult( CustomMessage.DefaultMessage , StkStockDocsDto);

        }
    }
}
