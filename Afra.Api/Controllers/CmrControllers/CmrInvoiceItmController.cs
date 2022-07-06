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

namespace Afra.Api.Controllers.CmrInvoiceItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrInvoiceItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrInvoiceItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrInvoiceItmCommand command)
        {
            command.Validate();

            var CmrInvoiceItms = await _unitOfWork.CmrInvoiceItmRepository.FindAsync(c => c.Id == command.Id);

            if (CmrInvoiceItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrInvoiceItm = Mapper.Map(command);
            await _unitOfWork.CmrInvoiceItmRepository.AddAsync(newCmrInvoiceItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrInvoiceItmCommand command)
        {

            command.Validate();

            var CmrInvoiceItm = await _unitOfWork.CmrInvoiceItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrInvoiceItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrInvoiceItm = Mapper.Map(CmrInvoiceItm, command);
            CmrInvoiceItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrInvoiceItm = await _unitOfWork.CmrInvoiceItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrInvoiceItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrInvoiceItm.IsActive = false;
            CmrInvoiceItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrInvoiceItms = await _unitOfWork.CmrInvoiceItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrInvoiceItmsDto = Mapper.Map(CmrInvoiceItms);

            return OkResult(CustomMessage.DefaultMessage, CmrInvoiceItmsDto.ToPagingAndSorting(query), CmrInvoiceItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrInvoiceItm = await _unitOfWork.CmrInvoiceItmRepository.GetByIdAsync(id);

            if (CmrInvoiceItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrInvoiceItmDto = Mapper.Map(CmrInvoiceItm);

            return OkResult( CustomMessage.DefaultMessage , CmrInvoiceItmDto);

        }
    }
}
