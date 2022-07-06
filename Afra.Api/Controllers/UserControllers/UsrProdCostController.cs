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

namespace Afra.Api.Controllers.UsrProdCostControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrProdCostController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrProdCostController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrProdCostCommand command)
        {
            command.Validate();

            var UsrProdCosts = await _unitOfWork.UsrProdCostRepository.FindAsync(c => c.Id == command.Id);

            if (UsrProdCosts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrProdCost = Mapper.Map(command);
            await _unitOfWork.UsrProdCostRepository.AddAsync(newUsrProdCost);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrProdCostCommand command)
        {

            command.Validate();

            var UsrProdCost = await _unitOfWork.UsrProdCostRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrProdCost == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrProdCost = Mapper.Map(UsrProdCost, command);
            UsrProdCost.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrProdCost = await _unitOfWork.UsrProdCostRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrProdCost == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrProdCost.IsActive = false;
            UsrProdCost.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrProdCosts = await _unitOfWork.UsrProdCostRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrProdCostsDto = Mapper.Map(UsrProdCosts);

            return OkResult(CustomMessage.DefaultMessage, UsrProdCostsDto.ToPagingAndSorting(query), UsrProdCostsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrProdCost = await _unitOfWork.UsrProdCostRepository.GetByIdAsync(id);

            if (UsrProdCost is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrProdCostDto = Mapper.Map(UsrProdCost);

            return OkResult( CustomMessage.DefaultMessage , UsrProdCostDto);

        }
    }
}
