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

namespace Afra.Api.Controllers.CntInvoiceRelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntInvoiceRelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntInvoiceRelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntInvoiceRelsCommand command)
        {
            command.Validate();

            var CntInvoiceRelss = await _unitOfWork.CntInvoiceRelsRepository.FindAsync(c => c.Id == command.Id);

            if (CntInvoiceRelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntInvoiceRels = Mapper.Map(command);
            await _unitOfWork.CntInvoiceRelsRepository.AddAsync(newCntInvoiceRels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntInvoiceRelsCommand command)
        {

            command.Validate();

            var CntInvoiceRels = await _unitOfWork.CntInvoiceRelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntInvoiceRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntInvoiceRels = Mapper.Map(CntInvoiceRels, command);
            CntInvoiceRels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntInvoiceRels = await _unitOfWork.CntInvoiceRelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntInvoiceRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntInvoiceRels.IsActive = false;
            CntInvoiceRels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntInvoiceRelss = await _unitOfWork.CntInvoiceRelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntInvoiceRelssDto = Mapper.Map(CntInvoiceRelss);

            return OkResult(CustomMessage.DefaultMessage, CntInvoiceRelssDto.ToPagingAndSorting(query), CntInvoiceRelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntInvoiceRels = await _unitOfWork.CntInvoiceRelsRepository.GetByIdAsync(id);

            if (CntInvoiceRels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntInvoiceRelsDto = Mapper.Map(CntInvoiceRels);

            return OkResult( CustomMessage.DefaultMessage , CntInvoiceRelsDto);

        }
    }
}
