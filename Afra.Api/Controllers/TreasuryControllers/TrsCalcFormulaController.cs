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

namespace Afra.Api.Controllers.TrsCalcFormulaControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsCalcFormulaController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsCalcFormulaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsCalcFormulaCommand command)
        {
            command.Validate();

            var TrsCalcFormulas = await _unitOfWork.TrsCalcFormulaRepository.FindAsync(c => c.Id == command.Id);

            if (TrsCalcFormulas.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsCalcFormula = Mapper.Map(command);
            await _unitOfWork.TrsCalcFormulaRepository.AddAsync(newTrsCalcFormula);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsCalcFormulaCommand command)
        {

            command.Validate();

            var TrsCalcFormula = await _unitOfWork.TrsCalcFormulaRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsCalcFormula == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsCalcFormula = Mapper.Map(TrsCalcFormula, command);
            TrsCalcFormula.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsCalcFormula = await _unitOfWork.TrsCalcFormulaRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsCalcFormula == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsCalcFormula.IsActive = false;
            TrsCalcFormula.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsCalcFormulas = await _unitOfWork.TrsCalcFormulaRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsCalcFormulasDto = Mapper.Map(TrsCalcFormulas);

            return OkResult(CustomMessage.DefaultMessage, TrsCalcFormulasDto.ToPagingAndSorting(query), TrsCalcFormulasDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsCalcFormula = await _unitOfWork.TrsCalcFormulaRepository.GetByIdAsync(id);

            if (TrsCalcFormula is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsCalcFormulaDto = Mapper.Map(TrsCalcFormula);

            return OkResult( CustomMessage.DefaultMessage , TrsCalcFormulaDto);

        }
    }
}
