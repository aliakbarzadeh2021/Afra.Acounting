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

namespace Afra.Api.Controllers.CmrInvoiceCostControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrInvoiceCostController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrInvoiceCostController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrInvoiceCostCommand command)
        {
            command.Validate();

            var CmrInvoiceCosts = await _unitOfWork.CmrInvoiceCostRepository.FindAsync(c => c.Id == command.Id);

            if (CmrInvoiceCosts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrInvoiceCost = Mapper.Map(command);
            await _unitOfWork.CmrInvoiceCostRepository.AddAsync(newCmrInvoiceCost);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrInvoiceCostCommand command)
        {

            command.Validate();

            var CmrInvoiceCost = await _unitOfWork.CmrInvoiceCostRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrInvoiceCost == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrInvoiceCost = Mapper.Map(CmrInvoiceCost, command);
            CmrInvoiceCost.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrInvoiceCost = await _unitOfWork.CmrInvoiceCostRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrInvoiceCost == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrInvoiceCost.IsActive = false;
            CmrInvoiceCost.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrInvoiceCosts = await _unitOfWork.CmrInvoiceCostRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrInvoiceCostsDto = Mapper.Map(CmrInvoiceCosts);

            return OkResult(CustomMessage.DefaultMessage, CmrInvoiceCostsDto.ToPagingAndSorting(query), CmrInvoiceCostsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrInvoiceCost = await _unitOfWork.CmrInvoiceCostRepository.GetByIdAsync(id);

            if (CmrInvoiceCost is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrInvoiceCostDto = Mapper.Map(CmrInvoiceCost);

            return OkResult( CustomMessage.DefaultMessage , CmrInvoiceCostDto);

        }
    }
}
