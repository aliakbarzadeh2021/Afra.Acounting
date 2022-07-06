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

namespace Afra.Api.Controllers.PrdOprDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdOprDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdOprDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdOprDetCommand command)
        {
            command.Validate();

            var PrdOprDets = await _unitOfWork.PrdOprDetRepository.FindAsync(c => c.Id == command.Id);

            if (PrdOprDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdOprDet = Mapper.Map(command);
            await _unitOfWork.PrdOprDetRepository.AddAsync(newPrdOprDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdOprDetCommand command)
        {

            command.Validate();

            var PrdOprDet = await _unitOfWork.PrdOprDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdOprDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdOprDet = Mapper.Map(PrdOprDet, command);
            PrdOprDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdOprDet = await _unitOfWork.PrdOprDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdOprDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdOprDet.IsActive = false;
            PrdOprDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdOprDets = await _unitOfWork.PrdOprDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdOprDetsDto = Mapper.Map(PrdOprDets);

            return OkResult(CustomMessage.DefaultMessage, PrdOprDetsDto.ToPagingAndSorting(query), PrdOprDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdOprDet = await _unitOfWork.PrdOprDetRepository.GetByIdAsync(id);

            if (PrdOprDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdOprDetDto = Mapper.Map(PrdOprDet);

            return OkResult( CustomMessage.DefaultMessage , PrdOprDetDto);

        }
    }
}
