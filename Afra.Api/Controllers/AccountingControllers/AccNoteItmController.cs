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

namespace Afra.Api.Controllers.AccNoteItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccNoteItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccNoteItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccNoteItmCommand command)
        {
            command.Validate();

            var AccNoteItms = await _unitOfWork.AccNoteItmRepository.FindAsync(c => c.Id == command.Id);

            if (AccNoteItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccNoteItm = Mapper.Map(command);
            await _unitOfWork.AccNoteItmRepository.AddAsync(newAccNoteItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccNoteItmCommand command)
        {

            command.Validate();

            var AccNoteItm = await _unitOfWork.AccNoteItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccNoteItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccNoteItm = Mapper.Map(AccNoteItm, command);
            AccNoteItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccNoteItm = await _unitOfWork.AccNoteItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccNoteItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccNoteItm.IsActive = false;
            AccNoteItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccNoteItms = await _unitOfWork.AccNoteItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccNoteItmsDto = Mapper.Map(AccNoteItms);

            return OkResult(CustomMessage.DefaultMessage, AccNoteItmsDto.ToPagingAndSorting(query), AccNoteItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccNoteItm = await _unitOfWork.AccNoteItmRepository.GetByIdAsync(id);

            if (AccNoteItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccNoteItmDto = Mapper.Map(AccNoteItm);

            return OkResult( CustomMessage.DefaultMessage , AccNoteItmDto);

        }
    }
}
