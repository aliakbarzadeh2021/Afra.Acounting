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

namespace Afra.Api.Controllers.PrdOrdHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdOrdHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdOrdHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdOrdHdrCommand command)
        {
            command.Validate();

            var PrdOrdHdrs = await _unitOfWork.PrdOrdHdrRepository.FindAsync(c => c.Id == command.Id);

            if (PrdOrdHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdOrdHdr = Mapper.Map(command);
            await _unitOfWork.PrdOrdHdrRepository.AddAsync(newPrdOrdHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdOrdHdrCommand command)
        {

            command.Validate();

            var PrdOrdHdr = await _unitOfWork.PrdOrdHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdOrdHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdOrdHdr = Mapper.Map(PrdOrdHdr, command);
            PrdOrdHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdOrdHdr = await _unitOfWork.PrdOrdHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdOrdHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdOrdHdr.IsActive = false;
            PrdOrdHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdOrdHdrs = await _unitOfWork.PrdOrdHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdOrdHdrsDto = Mapper.Map(PrdOrdHdrs);

            return OkResult(CustomMessage.DefaultMessage, PrdOrdHdrsDto.ToPagingAndSorting(query), PrdOrdHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdOrdHdr = await _unitOfWork.PrdOrdHdrRepository.GetByIdAsync(id);

            if (PrdOrdHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdOrdHdrDto = Mapper.Map(PrdOrdHdr);

            return OkResult( CustomMessage.DefaultMessage , PrdOrdHdrDto);

        }
    }
}
