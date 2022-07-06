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

namespace Afra.Api.Controllers.TrsCreditTblDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsCreditTblDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsCreditTblDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsCreditTblDetCommand command)
        {
            command.Validate();

            var TrsCreditTblDets = await _unitOfWork.TrsCreditTblDetRepository.FindAsync(c => c.Id == command.Id);

            if (TrsCreditTblDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsCreditTblDet = Mapper.Map(command);
            await _unitOfWork.TrsCreditTblDetRepository.AddAsync(newTrsCreditTblDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsCreditTblDetCommand command)
        {

            command.Validate();

            var TrsCreditTblDet = await _unitOfWork.TrsCreditTblDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsCreditTblDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsCreditTblDet = Mapper.Map(TrsCreditTblDet, command);
            TrsCreditTblDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsCreditTblDet = await _unitOfWork.TrsCreditTblDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsCreditTblDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsCreditTblDet.IsActive = false;
            TrsCreditTblDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsCreditTblDets = await _unitOfWork.TrsCreditTblDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsCreditTblDetsDto = Mapper.Map(TrsCreditTblDets);

            return OkResult(CustomMessage.DefaultMessage, TrsCreditTblDetsDto.ToPagingAndSorting(query), TrsCreditTblDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsCreditTblDet = await _unitOfWork.TrsCreditTblDetRepository.GetByIdAsync(id);

            if (TrsCreditTblDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsCreditTblDetDto = Mapper.Map(TrsCreditTblDet);

            return OkResult( CustomMessage.DefaultMessage , TrsCreditTblDetDto);

        }
    }
}
