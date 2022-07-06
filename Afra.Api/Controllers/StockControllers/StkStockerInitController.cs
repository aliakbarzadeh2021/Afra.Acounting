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

namespace Afra.Api.Controllers.StkStockerInitControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class StkStockerInitController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StkStockerInitController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddStkStockerInitCommand command)
        {
            command.Validate();

            var StkStockerInits = await _unitOfWork.StkStockerInitRepository.FindAsync(c => c.Id == command.Id);

            if (StkStockerInits.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newStkStockerInit = Mapper.Map(command);
            await _unitOfWork.StkStockerInitRepository.AddAsync(newStkStockerInit);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditStkStockerInitCommand command)
        {

            command.Validate();

            var StkStockerInit = await _unitOfWork.StkStockerInitRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (StkStockerInit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StkStockerInit = Mapper.Map(StkStockerInit, command);
            StkStockerInit.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var StkStockerInit = await _unitOfWork.StkStockerInitRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (StkStockerInit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StkStockerInit.IsActive = false;
            StkStockerInit.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var StkStockerInits = await _unitOfWork.StkStockerInitRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var StkStockerInitsDto = Mapper.Map(StkStockerInits);

            return OkResult(CustomMessage.DefaultMessage, StkStockerInitsDto.ToPagingAndSorting(query), StkStockerInitsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var StkStockerInit = await _unitOfWork.StkStockerInitRepository.GetByIdAsync(id);

            if (StkStockerInit is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var StkStockerInitDto = Mapper.Map(StkStockerInit);

            return OkResult( CustomMessage.DefaultMessage , StkStockerInitDto);

        }
    }
}
