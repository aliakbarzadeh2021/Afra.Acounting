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

namespace Afra.Api.Controllers.PmiReqPartControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PmiReqPartController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PmiReqPartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPmiReqPartCommand command)
        {
            command.Validate();

            var PmiReqParts = await _unitOfWork.PmiReqPartRepository.FindAsync(c => c.Id == command.Id);

            if (PmiReqParts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPmiReqPart = Mapper.Map(command);
            await _unitOfWork.PmiReqPartRepository.AddAsync(newPmiReqPart);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPmiReqPartCommand command)
        {

            command.Validate();

            var PmiReqPart = await _unitOfWork.PmiReqPartRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PmiReqPart == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PmiReqPart = Mapper.Map(PmiReqPart, command);
            PmiReqPart.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PmiReqPart = await _unitOfWork.PmiReqPartRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PmiReqPart == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PmiReqPart.IsActive = false;
            PmiReqPart.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PmiReqParts = await _unitOfWork.PmiReqPartRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PmiReqPartsDto = Mapper.Map(PmiReqParts);

            return OkResult(CustomMessage.DefaultMessage, PmiReqPartsDto.ToPagingAndSorting(query), PmiReqPartsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PmiReqPart = await _unitOfWork.PmiReqPartRepository.GetByIdAsync(id);

            if (PmiReqPart is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PmiReqPartDto = Mapper.Map(PmiReqPart);

            return OkResult( CustomMessage.DefaultMessage , PmiReqPartDto);

        }
    }
}
