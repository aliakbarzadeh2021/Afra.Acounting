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

namespace Afra.Api.Controllers.PrdPOrdHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdPOrdHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdPOrdHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdPOrdHdrCommand command)
        {
            command.Validate();

            var PrdPOrdHdrs = await _unitOfWork.PrdPOrdHdrRepository.FindAsync(c => c.Id == command.Id);

            if (PrdPOrdHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdPOrdHdr = Mapper.Map(command);
            await _unitOfWork.PrdPOrdHdrRepository.AddAsync(newPrdPOrdHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdPOrdHdrCommand command)
        {

            command.Validate();

            var PrdPOrdHdr = await _unitOfWork.PrdPOrdHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdPOrdHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdPOrdHdr = Mapper.Map(PrdPOrdHdr, command);
            PrdPOrdHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdPOrdHdr = await _unitOfWork.PrdPOrdHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdPOrdHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdPOrdHdr.IsActive = false;
            PrdPOrdHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdPOrdHdrs = await _unitOfWork.PrdPOrdHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdPOrdHdrsDto = Mapper.Map(PrdPOrdHdrs);

            return OkResult(CustomMessage.DefaultMessage, PrdPOrdHdrsDto.ToPagingAndSorting(query), PrdPOrdHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdPOrdHdr = await _unitOfWork.PrdPOrdHdrRepository.GetByIdAsync(id);

            if (PrdPOrdHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdPOrdHdrDto = Mapper.Map(PrdPOrdHdr);

            return OkResult( CustomMessage.DefaultMessage , PrdPOrdHdrDto);

        }
    }
}
