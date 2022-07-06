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

namespace Afra.Api.Controllers.GnrAutoTextControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrAutoTextController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrAutoTextController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrAutoTextCommand command)
        {
            command.Validate();

            var GnrAutoTexts = await _unitOfWork.GnrAutoTextRepository.FindAsync(c => c.Id == command.Id);

            if (GnrAutoTexts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrAutoText = Mapper.Map(command);
            await _unitOfWork.GnrAutoTextRepository.AddAsync(newGnrAutoText);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrAutoTextCommand command)
        {

            command.Validate();

            var GnrAutoText = await _unitOfWork.GnrAutoTextRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrAutoText == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrAutoText = Mapper.Map(GnrAutoText, command);
            GnrAutoText.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrAutoText = await _unitOfWork.GnrAutoTextRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrAutoText == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrAutoText.IsActive = false;
            GnrAutoText.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrAutoTexts = await _unitOfWork.GnrAutoTextRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrAutoTextsDto = Mapper.Map(GnrAutoTexts);

            return OkResult(CustomMessage.DefaultMessage, GnrAutoTextsDto.ToPagingAndSorting(query), GnrAutoTextsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrAutoText = await _unitOfWork.GnrAutoTextRepository.GetByIdAsync(id);

            if (GnrAutoText is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrAutoTextDto = Mapper.Map(GnrAutoText);

            return OkResult( CustomMessage.DefaultMessage , GnrAutoTextDto);

        }
    }
}
