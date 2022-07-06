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

namespace Afra.Api.Controllers.CstCostCntrAllocSValsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstCostCntrAllocSValsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstCostCntrAllocSValsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstCostCntrAllocSValsCommand command)
        {
            command.Validate();

            var CstCostCntrAllocSValss = await _unitOfWork.CstCostCntrAllocSValsRepository.FindAsync(c => c.Id == command.Id);

            if (CstCostCntrAllocSValss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstCostCntrAllocSVals = Mapper.Map(command);
            await _unitOfWork.CstCostCntrAllocSValsRepository.AddAsync(newCstCostCntrAllocSVals);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstCostCntrAllocSValsCommand command)
        {

            command.Validate();

            var CstCostCntrAllocSVals = await _unitOfWork.CstCostCntrAllocSValsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstCostCntrAllocSVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostCntrAllocSVals = Mapper.Map(CstCostCntrAllocSVals, command);
            CstCostCntrAllocSVals.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstCostCntrAllocSVals = await _unitOfWork.CstCostCntrAllocSValsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstCostCntrAllocSVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostCntrAllocSVals.IsActive = false;
            CstCostCntrAllocSVals.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstCostCntrAllocSValss = await _unitOfWork.CstCostCntrAllocSValsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstCostCntrAllocSValssDto = Mapper.Map(CstCostCntrAllocSValss);

            return OkResult(CustomMessage.DefaultMessage, CstCostCntrAllocSValssDto.ToPagingAndSorting(query), CstCostCntrAllocSValssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstCostCntrAllocSVals = await _unitOfWork.CstCostCntrAllocSValsRepository.GetByIdAsync(id);

            if (CstCostCntrAllocSVals is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstCostCntrAllocSValsDto = Mapper.Map(CstCostCntrAllocSVals);

            return OkResult( CustomMessage.DefaultMessage , CstCostCntrAllocSValsDto);

        }
    }
}
