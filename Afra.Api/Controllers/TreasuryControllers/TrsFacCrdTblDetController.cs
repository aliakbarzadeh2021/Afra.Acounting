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

namespace Afra.Api.Controllers.TrsFacCrdTblDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFacCrdTblDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFacCrdTblDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFacCrdTblDetCommand command)
        {
            command.Validate();

            var TrsFacCrdTblDets = await _unitOfWork.TrsFacCrdTblDetRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFacCrdTblDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFacCrdTblDet = Mapper.Map(command);
            await _unitOfWork.TrsFacCrdTblDetRepository.AddAsync(newTrsFacCrdTblDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFacCrdTblDetCommand command)
        {

            command.Validate();

            var TrsFacCrdTblDet = await _unitOfWork.TrsFacCrdTblDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFacCrdTblDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacCrdTblDet = Mapper.Map(TrsFacCrdTblDet, command);
            TrsFacCrdTblDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFacCrdTblDet = await _unitOfWork.TrsFacCrdTblDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFacCrdTblDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacCrdTblDet.IsActive = false;
            TrsFacCrdTblDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFacCrdTblDets = await _unitOfWork.TrsFacCrdTblDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFacCrdTblDetsDto = Mapper.Map(TrsFacCrdTblDets);

            return OkResult(CustomMessage.DefaultMessage, TrsFacCrdTblDetsDto.ToPagingAndSorting(query), TrsFacCrdTblDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFacCrdTblDet = await _unitOfWork.TrsFacCrdTblDetRepository.GetByIdAsync(id);

            if (TrsFacCrdTblDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFacCrdTblDetDto = Mapper.Map(TrsFacCrdTblDet);

            return OkResult( CustomMessage.DefaultMessage , TrsFacCrdTblDetDto);

        }
    }
}
