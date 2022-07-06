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

namespace Afra.Api.Controllers.BdgTaxPrcCostControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgTaxPrcCostController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgTaxPrcCostController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgTaxPrcCostCommand command)
        {
            command.Validate();

            var BdgTaxPrcCosts = await _unitOfWork.BdgTaxPrcCostRepository.FindAsync(c => c.Id == command.Id);

            if (BdgTaxPrcCosts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgTaxPrcCost = Mapper.Map(command);
            await _unitOfWork.BdgTaxPrcCostRepository.AddAsync(newBdgTaxPrcCost);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgTaxPrcCostCommand command)
        {

            command.Validate();

            var BdgTaxPrcCost = await _unitOfWork.BdgTaxPrcCostRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgTaxPrcCost == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgTaxPrcCost = Mapper.Map(BdgTaxPrcCost, command);
            BdgTaxPrcCost.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgTaxPrcCost = await _unitOfWork.BdgTaxPrcCostRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgTaxPrcCost == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgTaxPrcCost.IsActive = false;
            BdgTaxPrcCost.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgTaxPrcCosts = await _unitOfWork.BdgTaxPrcCostRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgTaxPrcCostsDto = Mapper.Map(BdgTaxPrcCosts);

            return OkResult(CustomMessage.DefaultMessage, BdgTaxPrcCostsDto.ToPagingAndSorting(query), BdgTaxPrcCostsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgTaxPrcCost = await _unitOfWork.BdgTaxPrcCostRepository.GetByIdAsync(id);

            if (BdgTaxPrcCost is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgTaxPrcCostDto = Mapper.Map(BdgTaxPrcCost);

            return OkResult( CustomMessage.DefaultMessage , BdgTaxPrcCostDto);

        }
    }
}
