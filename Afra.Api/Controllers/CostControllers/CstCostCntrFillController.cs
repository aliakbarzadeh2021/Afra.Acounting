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

namespace Afra.Api.Controllers.CstCostCntrFillControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstCostCntrFillController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstCostCntrFillController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstCostCntrFillCommand command)
        {
            command.Validate();

            var CstCostCntrFills = await _unitOfWork.CstCostCntrFillRepository.FindAsync(c => c.Id == command.Id);

            if (CstCostCntrFills.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstCostCntrFill = Mapper.Map(command);
            await _unitOfWork.CstCostCntrFillRepository.AddAsync(newCstCostCntrFill);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstCostCntrFillCommand command)
        {

            command.Validate();

            var CstCostCntrFill = await _unitOfWork.CstCostCntrFillRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstCostCntrFill == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostCntrFill = Mapper.Map(CstCostCntrFill, command);
            CstCostCntrFill.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstCostCntrFill = await _unitOfWork.CstCostCntrFillRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstCostCntrFill == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostCntrFill.IsActive = false;
            CstCostCntrFill.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstCostCntrFills = await _unitOfWork.CstCostCntrFillRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstCostCntrFillsDto = Mapper.Map(CstCostCntrFills);

            return OkResult(CustomMessage.DefaultMessage, CstCostCntrFillsDto.ToPagingAndSorting(query), CstCostCntrFillsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstCostCntrFill = await _unitOfWork.CstCostCntrFillRepository.GetByIdAsync(id);

            if (CstCostCntrFill is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstCostCntrFillDto = Mapper.Map(CstCostCntrFill);

            return OkResult( CustomMessage.DefaultMessage , CstCostCntrFillDto);

        }
    }
}
