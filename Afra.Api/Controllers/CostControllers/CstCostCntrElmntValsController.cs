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

namespace Afra.Api.Controllers.CstCostCntrElmntValsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstCostCntrElmntValsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstCostCntrElmntValsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstCostCntrElmntValsCommand command)
        {
            command.Validate();

            var CstCostCntrElmntValss = await _unitOfWork.CstCostCntrElmntValsRepository.FindAsync(c => c.Id == command.Id);

            if (CstCostCntrElmntValss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstCostCntrElmntVals = Mapper.Map(command);
            await _unitOfWork.CstCostCntrElmntValsRepository.AddAsync(newCstCostCntrElmntVals);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstCostCntrElmntValsCommand command)
        {

            command.Validate();

            var CstCostCntrElmntVals = await _unitOfWork.CstCostCntrElmntValsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstCostCntrElmntVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostCntrElmntVals = Mapper.Map(CstCostCntrElmntVals, command);
            CstCostCntrElmntVals.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstCostCntrElmntVals = await _unitOfWork.CstCostCntrElmntValsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstCostCntrElmntVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostCntrElmntVals.IsActive = false;
            CstCostCntrElmntVals.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstCostCntrElmntValss = await _unitOfWork.CstCostCntrElmntValsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstCostCntrElmntValssDto = Mapper.Map(CstCostCntrElmntValss);

            return OkResult(CustomMessage.DefaultMessage, CstCostCntrElmntValssDto.ToPagingAndSorting(query), CstCostCntrElmntValssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstCostCntrElmntVals = await _unitOfWork.CstCostCntrElmntValsRepository.GetByIdAsync(id);

            if (CstCostCntrElmntVals is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstCostCntrElmntValsDto = Mapper.Map(CstCostCntrElmntVals);

            return OkResult( CustomMessage.DefaultMessage , CstCostCntrElmntValsDto);

        }
    }
}
