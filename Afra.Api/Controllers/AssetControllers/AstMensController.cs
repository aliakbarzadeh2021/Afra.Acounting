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

namespace Afra.Api.Controllers.AstMensControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AstMensController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AstMensController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAstMensCommand command)
        {
            command.Validate();

            var AstMenss = await _unitOfWork.AstMensRepository.FindAsync(c => c.Id == command.Id);

            if (AstMenss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAstMens = Mapper.Map(command);
            await _unitOfWork.AstMensRepository.AddAsync(newAstMens);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAstMensCommand command)
        {

            command.Validate();

            var AstMens = await _unitOfWork.AstMensRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AstMens == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstMens = Mapper.Map(AstMens, command);
            AstMens.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AstMens = await _unitOfWork.AstMensRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AstMens == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstMens.IsActive = false;
            AstMens.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AstMenss = await _unitOfWork.AstMensRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AstMenssDto = Mapper.Map(AstMenss);

            return OkResult(CustomMessage.DefaultMessage, AstMenssDto.ToPagingAndSorting(query), AstMenssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AstMens = await _unitOfWork.AstMensRepository.GetByIdAsync(id);

            if (AstMens is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AstMensDto = Mapper.Map(AstMens);

            return OkResult( CustomMessage.DefaultMessage , AstMensDto);

        }
    }
}
