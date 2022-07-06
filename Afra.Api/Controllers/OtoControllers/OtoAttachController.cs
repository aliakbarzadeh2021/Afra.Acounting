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

namespace Afra.Api.Controllers.OtoAttachControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoAttachController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoAttachController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoAttachCommand command)
        {
            command.Validate();

            var OtoAttachs = await _unitOfWork.OtoAttachRepository.FindAsync(c => c.Id == command.Id);

            if (OtoAttachs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoAttach = Mapper.Map(command);
            await _unitOfWork.OtoAttachRepository.AddAsync(newOtoAttach);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoAttachCommand command)
        {

            command.Validate();

            var OtoAttach = await _unitOfWork.OtoAttachRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoAttach == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoAttach = Mapper.Map(OtoAttach, command);
            OtoAttach.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoAttach = await _unitOfWork.OtoAttachRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoAttach == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoAttach.IsActive = false;
            OtoAttach.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoAttachs = await _unitOfWork.OtoAttachRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoAttachsDto = Mapper.Map(OtoAttachs);

            return OkResult(CustomMessage.DefaultMessage, OtoAttachsDto.ToPagingAndSorting(query), OtoAttachsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoAttach = await _unitOfWork.OtoAttachRepository.GetByIdAsync(id);

            if (OtoAttach is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoAttachDto = Mapper.Map(OtoAttach);

            return OkResult( CustomMessage.DefaultMessage , OtoAttachDto);

        }
    }
}
