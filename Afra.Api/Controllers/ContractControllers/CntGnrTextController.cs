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

namespace Afra.Api.Controllers.CntGnrTextControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntGnrTextController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntGnrTextController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntGnrTextCommand command)
        {
            command.Validate();

            var CntGnrTexts = await _unitOfWork.CntGnrTextRepository.FindAsync(c => c.Id == command.Id);

            if (CntGnrTexts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntGnrText = Mapper.Map(command);
            await _unitOfWork.CntGnrTextRepository.AddAsync(newCntGnrText);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntGnrTextCommand command)
        {

            command.Validate();

            var CntGnrText = await _unitOfWork.CntGnrTextRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntGnrText == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntGnrText = Mapper.Map(CntGnrText, command);
            CntGnrText.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntGnrText = await _unitOfWork.CntGnrTextRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntGnrText == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntGnrText.IsActive = false;
            CntGnrText.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntGnrTexts = await _unitOfWork.CntGnrTextRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntGnrTextsDto = Mapper.Map(CntGnrTexts);

            return OkResult(CustomMessage.DefaultMessage, CntGnrTextsDto.ToPagingAndSorting(query), CntGnrTextsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntGnrText = await _unitOfWork.CntGnrTextRepository.GetByIdAsync(id);

            if (CntGnrText is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntGnrTextDto = Mapper.Map(CntGnrText);

            return OkResult( CustomMessage.DefaultMessage , CntGnrTextDto);

        }
    }
}
