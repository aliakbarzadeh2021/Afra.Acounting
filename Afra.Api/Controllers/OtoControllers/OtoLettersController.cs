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

namespace Afra.Api.Controllers.OtoLettersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoLettersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoLettersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoLettersCommand command)
        {
            command.Validate();

            var OtoLetterss = await _unitOfWork.OtoLettersRepository.FindAsync(c => c.Id == command.Id);

            if (OtoLetterss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoLetters = Mapper.Map(command);
            await _unitOfWork.OtoLettersRepository.AddAsync(newOtoLetters);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoLettersCommand command)
        {

            command.Validate();

            var OtoLetters = await _unitOfWork.OtoLettersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoLetters == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoLetters = Mapper.Map(OtoLetters, command);
            OtoLetters.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoLetters = await _unitOfWork.OtoLettersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoLetters == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoLetters.IsActive = false;
            OtoLetters.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoLetterss = await _unitOfWork.OtoLettersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoLetterssDto = Mapper.Map(OtoLetterss);

            return OkResult(CustomMessage.DefaultMessage, OtoLetterssDto.ToPagingAndSorting(query), OtoLetterssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoLetters = await _unitOfWork.OtoLettersRepository.GetByIdAsync(id);

            if (OtoLetters is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoLettersDto = Mapper.Map(OtoLetters);

            return OkResult( CustomMessage.DefaultMessage , OtoLettersDto);

        }
    }
}
