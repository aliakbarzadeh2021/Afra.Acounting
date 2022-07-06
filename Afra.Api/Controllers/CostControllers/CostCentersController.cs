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

namespace Afra.Api.Controllers.CostCentersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CostCentersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CostCentersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCostCentersCommand command)
        {
            command.Validate();

            var CostCenterss = await _unitOfWork.CostCentersRepository.FindAsync(c => c.Id == command.Id);

            if (CostCenterss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCostCenters = Mapper.Map(command);
            await _unitOfWork.CostCentersRepository.AddAsync(newCostCenters);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCostCentersCommand command)
        {

            command.Validate();

            var CostCenters = await _unitOfWork.CostCentersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CostCenters == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CostCenters = Mapper.Map(CostCenters, command);
            CostCenters.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CostCenters = await _unitOfWork.CostCentersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CostCenters == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CostCenters.IsActive = false;
            CostCenters.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CostCenterss = await _unitOfWork.CostCentersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CostCenterssDto = Mapper.Map(CostCenterss);

            return OkResult(CustomMessage.DefaultMessage, CostCenterssDto.ToPagingAndSorting(query), CostCenterssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CostCenters = await _unitOfWork.CostCentersRepository.GetByIdAsync(id);

            if (CostCenters is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CostCentersDto = Mapper.Map(CostCenters);

            return OkResult( CustomMessage.DefaultMessage , CostCentersDto);

        }
    }
}
