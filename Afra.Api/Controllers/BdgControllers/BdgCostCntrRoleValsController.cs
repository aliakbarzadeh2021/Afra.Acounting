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

namespace Afra.Api.Controllers.BdgCostCntrRoleValsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgCostCntrRoleValsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgCostCntrRoleValsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgCostCntrRoleValsCommand command)
        {
            command.Validate();

            var BdgCostCntrRoleValss = await _unitOfWork.BdgCostCntrRoleValsRepository.FindAsync(c => c.Id == command.Id);

            if (BdgCostCntrRoleValss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgCostCntrRoleVals = Mapper.Map(command);
            await _unitOfWork.BdgCostCntrRoleValsRepository.AddAsync(newBdgCostCntrRoleVals);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgCostCntrRoleValsCommand command)
        {

            command.Validate();

            var BdgCostCntrRoleVals = await _unitOfWork.BdgCostCntrRoleValsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgCostCntrRoleVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgCostCntrRoleVals = Mapper.Map(BdgCostCntrRoleVals, command);
            BdgCostCntrRoleVals.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgCostCntrRoleVals = await _unitOfWork.BdgCostCntrRoleValsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgCostCntrRoleVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgCostCntrRoleVals.IsActive = false;
            BdgCostCntrRoleVals.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgCostCntrRoleValss = await _unitOfWork.BdgCostCntrRoleValsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgCostCntrRoleValssDto = Mapper.Map(BdgCostCntrRoleValss);

            return OkResult(CustomMessage.DefaultMessage, BdgCostCntrRoleValssDto.ToPagingAndSorting(query), BdgCostCntrRoleValssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgCostCntrRoleVals = await _unitOfWork.BdgCostCntrRoleValsRepository.GetByIdAsync(id);

            if (BdgCostCntrRoleVals is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgCostCntrRoleValsDto = Mapper.Map(BdgCostCntrRoleVals);

            return OkResult( CustomMessage.DefaultMessage , BdgCostCntrRoleValsDto);

        }
    }
}
