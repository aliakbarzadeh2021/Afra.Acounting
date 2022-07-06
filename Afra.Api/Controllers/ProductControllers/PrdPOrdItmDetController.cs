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

namespace Afra.Api.Controllers.PrdPOrdItmDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdPOrdItmDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdPOrdItmDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdPOrdItmDetCommand command)
        {
            command.Validate();

            var PrdPOrdItmDets = await _unitOfWork.PrdPOrdItmDetRepository.FindAsync(c => c.Id == command.Id);

            if (PrdPOrdItmDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdPOrdItmDet = Mapper.Map(command);
            await _unitOfWork.PrdPOrdItmDetRepository.AddAsync(newPrdPOrdItmDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdPOrdItmDetCommand command)
        {

            command.Validate();

            var PrdPOrdItmDet = await _unitOfWork.PrdPOrdItmDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdPOrdItmDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdPOrdItmDet = Mapper.Map(PrdPOrdItmDet, command);
            PrdPOrdItmDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdPOrdItmDet = await _unitOfWork.PrdPOrdItmDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdPOrdItmDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdPOrdItmDet.IsActive = false;
            PrdPOrdItmDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdPOrdItmDets = await _unitOfWork.PrdPOrdItmDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdPOrdItmDetsDto = Mapper.Map(PrdPOrdItmDets);

            return OkResult(CustomMessage.DefaultMessage, PrdPOrdItmDetsDto.ToPagingAndSorting(query), PrdPOrdItmDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdPOrdItmDet = await _unitOfWork.PrdPOrdItmDetRepository.GetByIdAsync(id);

            if (PrdPOrdItmDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdPOrdItmDetDto = Mapper.Map(PrdPOrdItmDet);

            return OkResult( CustomMessage.DefaultMessage , PrdPOrdItmDetDto);

        }
    }
}
