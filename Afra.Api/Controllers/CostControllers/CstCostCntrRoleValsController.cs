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

namespace Afra.Api.Controllers.CstCostCntrRoleValsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstCostCntrRoleValsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstCostCntrRoleValsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstCostCntrRoleValsCommand command)
        {
            command.Validate();

            var CstCostCntrRoleValss = await _unitOfWork.CstCostCntrRoleValsRepository.FindAsync(c => c.Id == command.Id);

            if (CstCostCntrRoleValss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstCostCntrRoleVals = Mapper.Map(command);
            await _unitOfWork.CstCostCntrRoleValsRepository.AddAsync(newCstCostCntrRoleVals);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstCostCntrRoleValsCommand command)
        {

            command.Validate();

            var CstCostCntrRoleVals = await _unitOfWork.CstCostCntrRoleValsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstCostCntrRoleVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostCntrRoleVals = Mapper.Map(CstCostCntrRoleVals, command);
            CstCostCntrRoleVals.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstCostCntrRoleVals = await _unitOfWork.CstCostCntrRoleValsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstCostCntrRoleVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostCntrRoleVals.IsActive = false;
            CstCostCntrRoleVals.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstCostCntrRoleValss = await _unitOfWork.CstCostCntrRoleValsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstCostCntrRoleValssDto = Mapper.Map(CstCostCntrRoleValss);

            return OkResult(CustomMessage.DefaultMessage, CstCostCntrRoleValssDto.ToPagingAndSorting(query), CstCostCntrRoleValssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstCostCntrRoleVals = await _unitOfWork.CstCostCntrRoleValsRepository.GetByIdAsync(id);

            if (CstCostCntrRoleVals is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstCostCntrRoleValsDto = Mapper.Map(CstCostCntrRoleVals);

            return OkResult( CustomMessage.DefaultMessage , CstCostCntrRoleValsDto);

        }
    }
}
