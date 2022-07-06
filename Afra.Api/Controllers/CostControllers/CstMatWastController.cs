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

namespace Afra.Api.Controllers.CstMatWastControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstMatWastController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstMatWastController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstMatWastCommand command)
        {
            command.Validate();

            var CstMatWasts = await _unitOfWork.CstMatWastRepository.FindAsync(c => c.Id == command.Id);

            if (CstMatWasts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstMatWast = Mapper.Map(command);
            await _unitOfWork.CstMatWastRepository.AddAsync(newCstMatWast);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstMatWastCommand command)
        {

            command.Validate();

            var CstMatWast = await _unitOfWork.CstMatWastRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstMatWast == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstMatWast = Mapper.Map(CstMatWast, command);
            CstMatWast.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstMatWast = await _unitOfWork.CstMatWastRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstMatWast == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstMatWast.IsActive = false;
            CstMatWast.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstMatWasts = await _unitOfWork.CstMatWastRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstMatWastsDto = Mapper.Map(CstMatWasts);

            return OkResult(CustomMessage.DefaultMessage, CstMatWastsDto.ToPagingAndSorting(query), CstMatWastsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstMatWast = await _unitOfWork.CstMatWastRepository.GetByIdAsync(id);

            if (CstMatWast is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstMatWastDto = Mapper.Map(CstMatWast);

            return OkResult( CustomMessage.DefaultMessage , CstMatWastDto);

        }
    }
}
