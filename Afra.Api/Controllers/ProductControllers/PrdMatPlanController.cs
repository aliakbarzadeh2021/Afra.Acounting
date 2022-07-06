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

namespace Afra.Api.Controllers.PrdMatPlanControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdMatPlanController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdMatPlanController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdMatPlanCommand command)
        {
            command.Validate();

            var PrdMatPlans = await _unitOfWork.PrdMatPlanRepository.FindAsync(c => c.Id == command.Id);

            if (PrdMatPlans.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdMatPlan = Mapper.Map(command);
            await _unitOfWork.PrdMatPlanRepository.AddAsync(newPrdMatPlan);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdMatPlanCommand command)
        {

            command.Validate();

            var PrdMatPlan = await _unitOfWork.PrdMatPlanRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdMatPlan == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdMatPlan = Mapper.Map(PrdMatPlan, command);
            PrdMatPlan.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdMatPlan = await _unitOfWork.PrdMatPlanRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdMatPlan == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdMatPlan.IsActive = false;
            PrdMatPlan.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdMatPlans = await _unitOfWork.PrdMatPlanRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdMatPlansDto = Mapper.Map(PrdMatPlans);

            return OkResult(CustomMessage.DefaultMessage, PrdMatPlansDto.ToPagingAndSorting(query), PrdMatPlansDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdMatPlan = await _unitOfWork.PrdMatPlanRepository.GetByIdAsync(id);

            if (PrdMatPlan is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdMatPlanDto = Mapper.Map(PrdMatPlan);

            return OkResult( CustomMessage.DefaultMessage , PrdMatPlanDto);

        }
    }
}
