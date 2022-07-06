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

namespace Afra.Api.Controllers.PrdMacroControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdMacroController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdMacroController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdMacroCommand command)
        {
            command.Validate();

            var PrdMacros = await _unitOfWork.PrdMacroRepository.FindAsync(c => c.Id == command.Id);

            if (PrdMacros.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdMacro = Mapper.Map(command);
            await _unitOfWork.PrdMacroRepository.AddAsync(newPrdMacro);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdMacroCommand command)
        {

            command.Validate();

            var PrdMacro = await _unitOfWork.PrdMacroRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdMacro == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdMacro = Mapper.Map(PrdMacro, command);
            PrdMacro.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdMacro = await _unitOfWork.PrdMacroRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdMacro == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdMacro.IsActive = false;
            PrdMacro.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdMacros = await _unitOfWork.PrdMacroRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdMacrosDto = Mapper.Map(PrdMacros);

            return OkResult(CustomMessage.DefaultMessage, PrdMacrosDto.ToPagingAndSorting(query), PrdMacrosDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdMacro = await _unitOfWork.PrdMacroRepository.GetByIdAsync(id);

            if (PrdMacro is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdMacroDto = Mapper.Map(PrdMacro);

            return OkResult( CustomMessage.DefaultMessage , PrdMacroDto);

        }
    }
}
