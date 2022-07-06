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

namespace Afra.Api.Controllers.TrsFundBillHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFundBillHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFundBillHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFundBillHdrCommand command)
        {
            command.Validate();

            var TrsFundBillHdrs = await _unitOfWork.TrsFundBillHdrRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFundBillHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFundBillHdr = Mapper.Map(command);
            await _unitOfWork.TrsFundBillHdrRepository.AddAsync(newTrsFundBillHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFundBillHdrCommand command)
        {

            command.Validate();

            var TrsFundBillHdr = await _unitOfWork.TrsFundBillHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFundBillHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFundBillHdr = Mapper.Map(TrsFundBillHdr, command);
            TrsFundBillHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFundBillHdr = await _unitOfWork.TrsFundBillHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFundBillHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFundBillHdr.IsActive = false;
            TrsFundBillHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFundBillHdrs = await _unitOfWork.TrsFundBillHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFundBillHdrsDto = Mapper.Map(TrsFundBillHdrs);

            return OkResult(CustomMessage.DefaultMessage, TrsFundBillHdrsDto.ToPagingAndSorting(query), TrsFundBillHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFundBillHdr = await _unitOfWork.TrsFundBillHdrRepository.GetByIdAsync(id);

            if (TrsFundBillHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFundBillHdrDto = Mapper.Map(TrsFundBillHdr);

            return OkResult( CustomMessage.DefaultMessage , TrsFundBillHdrDto);

        }
    }
}
