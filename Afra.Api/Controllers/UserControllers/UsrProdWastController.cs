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

namespace Afra.Api.Controllers.UsrProdWastControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrProdWastController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrProdWastController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrProdWastCommand command)
        {
            command.Validate();

            var UsrProdWasts = await _unitOfWork.UsrProdWastRepository.FindAsync(c => c.Id == command.Id);

            if (UsrProdWasts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrProdWast = Mapper.Map(command);
            await _unitOfWork.UsrProdWastRepository.AddAsync(newUsrProdWast);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrProdWastCommand command)
        {

            command.Validate();

            var UsrProdWast = await _unitOfWork.UsrProdWastRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrProdWast == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrProdWast = Mapper.Map(UsrProdWast, command);
            UsrProdWast.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrProdWast = await _unitOfWork.UsrProdWastRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrProdWast == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrProdWast.IsActive = false;
            UsrProdWast.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrProdWasts = await _unitOfWork.UsrProdWastRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrProdWastsDto = Mapper.Map(UsrProdWasts);

            return OkResult(CustomMessage.DefaultMessage, UsrProdWastsDto.ToPagingAndSorting(query), UsrProdWastsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrProdWast = await _unitOfWork.UsrProdWastRepository.GetByIdAsync(id);

            if (UsrProdWast is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrProdWastDto = Mapper.Map(UsrProdWast);

            return OkResult( CustomMessage.DefaultMessage , UsrProdWastDto);

        }
    }
}
