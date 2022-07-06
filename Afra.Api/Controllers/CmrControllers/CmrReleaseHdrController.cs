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

namespace Afra.Api.Controllers.CmrReleaseHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrReleaseHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrReleaseHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrReleaseHdrCommand command)
        {
            command.Validate();

            var CmrReleaseHdrs = await _unitOfWork.CmrReleaseHdrRepository.FindAsync(c => c.Id == command.Id);

            if (CmrReleaseHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrReleaseHdr = Mapper.Map(command);
            await _unitOfWork.CmrReleaseHdrRepository.AddAsync(newCmrReleaseHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrReleaseHdrCommand command)
        {

            command.Validate();

            var CmrReleaseHdr = await _unitOfWork.CmrReleaseHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrReleaseHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrReleaseHdr = Mapper.Map(CmrReleaseHdr, command);
            CmrReleaseHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrReleaseHdr = await _unitOfWork.CmrReleaseHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrReleaseHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrReleaseHdr.IsActive = false;
            CmrReleaseHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrReleaseHdrs = await _unitOfWork.CmrReleaseHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrReleaseHdrsDto = Mapper.Map(CmrReleaseHdrs);

            return OkResult(CustomMessage.DefaultMessage, CmrReleaseHdrsDto.ToPagingAndSorting(query), CmrReleaseHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrReleaseHdr = await _unitOfWork.CmrReleaseHdrRepository.GetByIdAsync(id);

            if (CmrReleaseHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrReleaseHdrDto = Mapper.Map(CmrReleaseHdr);

            return OkResult( CustomMessage.DefaultMessage , CmrReleaseHdrDto);

        }
    }
}
