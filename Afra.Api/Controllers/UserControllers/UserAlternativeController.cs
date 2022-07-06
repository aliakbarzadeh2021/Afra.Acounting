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

namespace Afra.Api.Controllers.UserAlternativeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserAlternativeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserAlternativeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserAlternativeCommand command)
        {
            command.Validate();

            var UserAlternatives = await _unitOfWork.UserAlternativeRepository.FindAsync(c => c.Id == command.Id);

            if (UserAlternatives.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUserAlternative = Mapper.Map(command);
            await _unitOfWork.UserAlternativeRepository.AddAsync(newUserAlternative);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserAlternativeCommand command)
        {

            command.Validate();

            var UserAlternative = await _unitOfWork.UserAlternativeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UserAlternative == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserAlternative = Mapper.Map(UserAlternative, command);
            UserAlternative.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UserAlternative = await _unitOfWork.UserAlternativeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UserAlternative == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserAlternative.IsActive = false;
            UserAlternative.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UserAlternatives = await _unitOfWork.UserAlternativeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserAlternativesDto = Mapper.Map(UserAlternatives);

            return OkResult(CustomMessage.DefaultMessage, UserAlternativesDto.ToPagingAndSorting(query), UserAlternativesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UserAlternative = await _unitOfWork.UserAlternativeRepository.GetByIdAsync(id);

            if (UserAlternative is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserAlternativeDto = Mapper.Map(UserAlternative);

            return OkResult( CustomMessage.DefaultMessage , UserAlternativeDto);

        }
    }
}
