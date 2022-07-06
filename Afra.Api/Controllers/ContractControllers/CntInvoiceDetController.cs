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

namespace Afra.Api.Controllers.CntInvoiceDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntInvoiceDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntInvoiceDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntInvoiceDetCommand command)
        {
            command.Validate();

            var CntInvoiceDets = await _unitOfWork.CntInvoiceDetRepository.FindAsync(c => c.Id == command.Id);

            if (CntInvoiceDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntInvoiceDet = Mapper.Map(command);
            await _unitOfWork.CntInvoiceDetRepository.AddAsync(newCntInvoiceDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntInvoiceDetCommand command)
        {

            command.Validate();

            var CntInvoiceDet = await _unitOfWork.CntInvoiceDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntInvoiceDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntInvoiceDet = Mapper.Map(CntInvoiceDet, command);
            CntInvoiceDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntInvoiceDet = await _unitOfWork.CntInvoiceDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntInvoiceDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntInvoiceDet.IsActive = false;
            CntInvoiceDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntInvoiceDets = await _unitOfWork.CntInvoiceDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntInvoiceDetsDto = Mapper.Map(CntInvoiceDets);

            return OkResult(CustomMessage.DefaultMessage, CntInvoiceDetsDto.ToPagingAndSorting(query), CntInvoiceDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntInvoiceDet = await _unitOfWork.CntInvoiceDetRepository.GetByIdAsync(id);

            if (CntInvoiceDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntInvoiceDetDto = Mapper.Map(CntInvoiceDet);

            return OkResult( CustomMessage.DefaultMessage , CntInvoiceDetDto);

        }
    }
}
