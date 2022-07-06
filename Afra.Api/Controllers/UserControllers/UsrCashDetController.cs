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

namespace Afra.Api.Controllers.UsrCashDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrCashDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrCashDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrCashDetCommand command)
        {
            command.Validate();

            var UsrCashDets = await _unitOfWork.UsrCashDetRepository.FindAsync(c => c.Id == command.Id);

            if (UsrCashDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrCashDet = Mapper.Map(command);
            await _unitOfWork.UsrCashDetRepository.AddAsync(newUsrCashDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrCashDetCommand command)
        {

            command.Validate();

            var UsrCashDet = await _unitOfWork.UsrCashDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrCashDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrCashDet = Mapper.Map(UsrCashDet, command);
            UsrCashDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrCashDet = await _unitOfWork.UsrCashDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrCashDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrCashDet.IsActive = false;
            UsrCashDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrCashDets = await _unitOfWork.UsrCashDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrCashDetsDto = Mapper.Map(UsrCashDets);

            return OkResult(CustomMessage.DefaultMessage, UsrCashDetsDto.ToPagingAndSorting(query), UsrCashDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrCashDet = await _unitOfWork.UsrCashDetRepository.GetByIdAsync(id);

            if (UsrCashDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrCashDetDto = Mapper.Map(UsrCashDet);

            return OkResult( CustomMessage.DefaultMessage , UsrCashDetDto);

        }
    }
}
