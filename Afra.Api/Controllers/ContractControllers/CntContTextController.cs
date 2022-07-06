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

namespace Afra.Api.Controllers.CntContTextControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntContTextController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntContTextController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntContTextCommand command)
        {
            command.Validate();

            var CntContTexts = await _unitOfWork.CntContTextRepository.FindAsync(c => c.Id == command.Id);

            if (CntContTexts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntContText = Mapper.Map(command);
            await _unitOfWork.CntContTextRepository.AddAsync(newCntContText);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntContTextCommand command)
        {

            command.Validate();

            var CntContText = await _unitOfWork.CntContTextRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntContText == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContText = Mapper.Map(CntContText, command);
            CntContText.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntContText = await _unitOfWork.CntContTextRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntContText == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContText.IsActive = false;
            CntContText.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntContTexts = await _unitOfWork.CntContTextRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntContTextsDto = Mapper.Map(CntContTexts);

            return OkResult(CustomMessage.DefaultMessage, CntContTextsDto.ToPagingAndSorting(query), CntContTextsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntContText = await _unitOfWork.CntContTextRepository.GetByIdAsync(id);

            if (CntContText is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntContTextDto = Mapper.Map(CntContText);

            return OkResult( CustomMessage.DefaultMessage , CntContTextDto);

        }
    }
}
