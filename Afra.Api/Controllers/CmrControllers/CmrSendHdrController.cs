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

namespace Afra.Api.Controllers.CmrSendHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrSendHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrSendHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrSendHdrCommand command)
        {
            command.Validate();

            var CmrSendHdrs = await _unitOfWork.CmrSendHdrRepository.FindAsync(c => c.Id == command.Id);

            if (CmrSendHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrSendHdr = Mapper.Map(command);
            await _unitOfWork.CmrSendHdrRepository.AddAsync(newCmrSendHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrSendHdrCommand command)
        {

            command.Validate();

            var CmrSendHdr = await _unitOfWork.CmrSendHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrSendHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrSendHdr = Mapper.Map(CmrSendHdr, command);
            CmrSendHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrSendHdr = await _unitOfWork.CmrSendHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrSendHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrSendHdr.IsActive = false;
            CmrSendHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrSendHdrs = await _unitOfWork.CmrSendHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrSendHdrsDto = Mapper.Map(CmrSendHdrs);

            return OkResult(CustomMessage.DefaultMessage, CmrSendHdrsDto.ToPagingAndSorting(query), CmrSendHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrSendHdr = await _unitOfWork.CmrSendHdrRepository.GetByIdAsync(id);

            if (CmrSendHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrSendHdrDto = Mapper.Map(CmrSendHdr);

            return OkResult( CustomMessage.DefaultMessage , CmrSendHdrDto);

        }
    }
}
