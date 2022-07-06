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

namespace Afra.Api.Controllers.CmrOrdHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrOrdHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrOrdHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrOrdHdrCommand command)
        {
            command.Validate();

            var CmrOrdHdrs = await _unitOfWork.CmrOrdHdrRepository.FindAsync(c => c.Id == command.Id);

            if (CmrOrdHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrOrdHdr = Mapper.Map(command);
            await _unitOfWork.CmrOrdHdrRepository.AddAsync(newCmrOrdHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrOrdHdrCommand command)
        {

            command.Validate();

            var CmrOrdHdr = await _unitOfWork.CmrOrdHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrOrdHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrOrdHdr = Mapper.Map(CmrOrdHdr, command);
            CmrOrdHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrOrdHdr = await _unitOfWork.CmrOrdHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrOrdHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrOrdHdr.IsActive = false;
            CmrOrdHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrOrdHdrs = await _unitOfWork.CmrOrdHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrOrdHdrsDto = Mapper.Map(CmrOrdHdrs);

            return OkResult(CustomMessage.DefaultMessage, CmrOrdHdrsDto.ToPagingAndSorting(query), CmrOrdHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrOrdHdr = await _unitOfWork.CmrOrdHdrRepository.GetByIdAsync(id);

            if (CmrOrdHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrOrdHdrDto = Mapper.Map(CmrOrdHdr);

            return OkResult( CustomMessage.DefaultMessage , CmrOrdHdrDto);

        }
    }
}
