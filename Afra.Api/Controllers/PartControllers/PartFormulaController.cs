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

namespace Afra.Api.Controllers.PartFormulaControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PartFormulaController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PartFormulaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPartFormulaCommand command)
        {
            command.Validate();

            var PartFormulas = await _unitOfWork.PartFormulaRepository.FindAsync(c => c.Id == command.Id);

            if (PartFormulas.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPartFormula = Mapper.Map(command);
            await _unitOfWork.PartFormulaRepository.AddAsync(newPartFormula);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPartFormulaCommand command)
        {

            command.Validate();

            var PartFormula = await _unitOfWork.PartFormulaRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PartFormula == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartFormula = Mapper.Map(PartFormula, command);
            PartFormula.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PartFormula = await _unitOfWork.PartFormulaRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PartFormula == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartFormula.IsActive = false;
            PartFormula.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PartFormulas = await _unitOfWork.PartFormulaRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PartFormulasDto = Mapper.Map(PartFormulas);

            return OkResult(CustomMessage.DefaultMessage, PartFormulasDto.ToPagingAndSorting(query), PartFormulasDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PartFormula = await _unitOfWork.PartFormulaRepository.GetByIdAsync(id);

            if (PartFormula is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PartFormulaDto = Mapper.Map(PartFormula);

            return OkResult( CustomMessage.DefaultMessage , PartFormulaDto);

        }
    }
}
