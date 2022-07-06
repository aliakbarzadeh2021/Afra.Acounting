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

namespace Afra.Api.Controllers.CmrRqstHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrRqstHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrRqstHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrRqstHdrCommand command)
        {
            command.Validate();

            var CmrRqstHdrs = await _unitOfWork.CmrRqstHdrRepository.FindAsync(c => c.Id == command.Id);

            if (CmrRqstHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrRqstHdr = Mapper.Map(command);
            await _unitOfWork.CmrRqstHdrRepository.AddAsync(newCmrRqstHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrRqstHdrCommand command)
        {

            command.Validate();

            var CmrRqstHdr = await _unitOfWork.CmrRqstHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrRqstHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrRqstHdr = Mapper.Map(CmrRqstHdr, command);
            CmrRqstHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrRqstHdr = await _unitOfWork.CmrRqstHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrRqstHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrRqstHdr.IsActive = false;
            CmrRqstHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrRqstHdrs = await _unitOfWork.CmrRqstHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrRqstHdrsDto = Mapper.Map(CmrRqstHdrs);

            return OkResult(CustomMessage.DefaultMessage, CmrRqstHdrsDto.ToPagingAndSorting(query), CmrRqstHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrRqstHdr = await _unitOfWork.CmrRqstHdrRepository.GetByIdAsync(id);

            if (CmrRqstHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrRqstHdrDto = Mapper.Map(CmrRqstHdr);

            return OkResult( CustomMessage.DefaultMessage , CmrRqstHdrDto);

        }
    }
}
