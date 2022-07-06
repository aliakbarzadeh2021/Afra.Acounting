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

namespace Afra.Api.Controllers.PrdSendHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdSendHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdSendHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdSendHdrCommand command)
        {
            command.Validate();

            var PrdSendHdrs = await _unitOfWork.PrdSendHdrRepository.FindAsync(c => c.Id == command.Id);

            if (PrdSendHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdSendHdr = Mapper.Map(command);
            await _unitOfWork.PrdSendHdrRepository.AddAsync(newPrdSendHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdSendHdrCommand command)
        {

            command.Validate();

            var PrdSendHdr = await _unitOfWork.PrdSendHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdSendHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdSendHdr = Mapper.Map(PrdSendHdr, command);
            PrdSendHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdSendHdr = await _unitOfWork.PrdSendHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdSendHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdSendHdr.IsActive = false;
            PrdSendHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdSendHdrs = await _unitOfWork.PrdSendHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdSendHdrsDto = Mapper.Map(PrdSendHdrs);

            return OkResult(CustomMessage.DefaultMessage, PrdSendHdrsDto.ToPagingAndSorting(query), PrdSendHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdSendHdr = await _unitOfWork.PrdSendHdrRepository.GetByIdAsync(id);

            if (PrdSendHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdSendHdrDto = Mapper.Map(PrdSendHdr);

            return OkResult( CustomMessage.DefaultMessage , PrdSendHdrDto);

        }
    }
}
