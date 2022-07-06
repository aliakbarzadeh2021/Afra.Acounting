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

namespace Afra.Api.Controllers.CntInvoiceHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntInvoiceHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntInvoiceHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntInvoiceHdrCommand command)
        {
            command.Validate();

            var CntInvoiceHdrs = await _unitOfWork.CntInvoiceHdrRepository.FindAsync(c => c.Id == command.Id);

            if (CntInvoiceHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntInvoiceHdr = Mapper.Map(command);
            await _unitOfWork.CntInvoiceHdrRepository.AddAsync(newCntInvoiceHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntInvoiceHdrCommand command)
        {

            command.Validate();

            var CntInvoiceHdr = await _unitOfWork.CntInvoiceHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntInvoiceHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntInvoiceHdr = Mapper.Map(CntInvoiceHdr, command);
            CntInvoiceHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntInvoiceHdr = await _unitOfWork.CntInvoiceHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntInvoiceHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntInvoiceHdr.IsActive = false;
            CntInvoiceHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntInvoiceHdrs = await _unitOfWork.CntInvoiceHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntInvoiceHdrsDto = Mapper.Map(CntInvoiceHdrs);

            return OkResult(CustomMessage.DefaultMessage, CntInvoiceHdrsDto.ToPagingAndSorting(query), CntInvoiceHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntInvoiceHdr = await _unitOfWork.CntInvoiceHdrRepository.GetByIdAsync(id);

            if (CntInvoiceHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntInvoiceHdrDto = Mapper.Map(CntInvoiceHdr);

            return OkResult( CustomMessage.DefaultMessage , CntInvoiceHdrDto);

        }
    }
}
