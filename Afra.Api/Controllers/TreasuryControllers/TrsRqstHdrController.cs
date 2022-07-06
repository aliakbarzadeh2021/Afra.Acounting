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

namespace Afra.Api.Controllers.TrsRqstHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsRqstHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsRqstHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsRqstHdrCommand command)
        {
            command.Validate();

            var TrsRqstHdrs = await _unitOfWork.TrsRqstHdrRepository.FindAsync(c => c.Id == command.Id);

            if (TrsRqstHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsRqstHdr = Mapper.Map(command);
            await _unitOfWork.TrsRqstHdrRepository.AddAsync(newTrsRqstHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsRqstHdrCommand command)
        {

            command.Validate();

            var TrsRqstHdr = await _unitOfWork.TrsRqstHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsRqstHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsRqstHdr = Mapper.Map(TrsRqstHdr, command);
            TrsRqstHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsRqstHdr = await _unitOfWork.TrsRqstHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsRqstHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsRqstHdr.IsActive = false;
            TrsRqstHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsRqstHdrs = await _unitOfWork.TrsRqstHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsRqstHdrsDto = Mapper.Map(TrsRqstHdrs);

            return OkResult(CustomMessage.DefaultMessage, TrsRqstHdrsDto.ToPagingAndSorting(query), TrsRqstHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsRqstHdr = await _unitOfWork.TrsRqstHdrRepository.GetByIdAsync(id);

            if (TrsRqstHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsRqstHdrDto = Mapper.Map(TrsRqstHdr);

            return OkResult( CustomMessage.DefaultMessage , TrsRqstHdrDto);

        }
    }
}
