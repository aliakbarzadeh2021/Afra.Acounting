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

namespace Afra.Api.Controllers.CstCostCntrAllocValsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstCostCntrAllocValsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstCostCntrAllocValsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstCostCntrAllocValsCommand command)
        {
            command.Validate();

            var CstCostCntrAllocValss = await _unitOfWork.CstCostCntrAllocValsRepository.FindAsync(c => c.Id == command.Id);

            if (CstCostCntrAllocValss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstCostCntrAllocVals = Mapper.Map(command);
            await _unitOfWork.CstCostCntrAllocValsRepository.AddAsync(newCstCostCntrAllocVals);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstCostCntrAllocValsCommand command)
        {

            command.Validate();

            var CstCostCntrAllocVals = await _unitOfWork.CstCostCntrAllocValsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstCostCntrAllocVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostCntrAllocVals = Mapper.Map(CstCostCntrAllocVals, command);
            CstCostCntrAllocVals.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstCostCntrAllocVals = await _unitOfWork.CstCostCntrAllocValsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstCostCntrAllocVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostCntrAllocVals.IsActive = false;
            CstCostCntrAllocVals.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstCostCntrAllocValss = await _unitOfWork.CstCostCntrAllocValsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstCostCntrAllocValssDto = Mapper.Map(CstCostCntrAllocValss);

            return OkResult(CustomMessage.DefaultMessage, CstCostCntrAllocValssDto.ToPagingAndSorting(query), CstCostCntrAllocValssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstCostCntrAllocVals = await _unitOfWork.CstCostCntrAllocValsRepository.GetByIdAsync(id);

            if (CstCostCntrAllocVals is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstCostCntrAllocValsDto = Mapper.Map(CstCostCntrAllocVals);

            return OkResult( CustomMessage.DefaultMessage , CstCostCntrAllocValsDto);

        }
    }
}
