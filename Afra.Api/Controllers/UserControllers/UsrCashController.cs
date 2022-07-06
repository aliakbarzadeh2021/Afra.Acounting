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

namespace Afra.Api.Controllers.UsrCashControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrCashController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrCashController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrCashCommand command)
        {
            command.Validate();

            var UsrCashs = await _unitOfWork.UsrCashRepository.FindAsync(c => c.Id == command.Id);

            if (UsrCashs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrCash = Mapper.Map(command);
            await _unitOfWork.UsrCashRepository.AddAsync(newUsrCash);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrCashCommand command)
        {

            command.Validate();

            var UsrCash = await _unitOfWork.UsrCashRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrCash == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrCash = Mapper.Map(UsrCash, command);
            UsrCash.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrCash = await _unitOfWork.UsrCashRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrCash == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrCash.IsActive = false;
            UsrCash.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrCashs = await _unitOfWork.UsrCashRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrCashsDto = Mapper.Map(UsrCashs);

            return OkResult(CustomMessage.DefaultMessage, UsrCashsDto.ToPagingAndSorting(query), UsrCashsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrCash = await _unitOfWork.UsrCashRepository.GetByIdAsync(id);

            if (UsrCash is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrCashDto = Mapper.Map(UsrCash);

            return OkResult( CustomMessage.DefaultMessage , UsrCashDto);

        }
    }
}
