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

namespace Afra.Api.Controllers.UserPlaningControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserPlaningController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserPlaningController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserPlaningCommand command)
        {
            command.Validate();

            var UserPlanings = await _unitOfWork.UserPlaningRepository.FindAsync(c => c.Id == command.Id);

            if (UserPlanings.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUserPlaning = Mapper.Map(command);
            await _unitOfWork.UserPlaningRepository.AddAsync(newUserPlaning);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserPlaningCommand command)
        {

            command.Validate();

            var UserPlaning = await _unitOfWork.UserPlaningRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UserPlaning == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserPlaning = Mapper.Map(UserPlaning, command);
            UserPlaning.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UserPlaning = await _unitOfWork.UserPlaningRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UserPlaning == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserPlaning.IsActive = false;
            UserPlaning.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UserPlanings = await _unitOfWork.UserPlaningRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserPlaningsDto = Mapper.Map(UserPlanings);

            return OkResult(CustomMessage.DefaultMessage, UserPlaningsDto.ToPagingAndSorting(query), UserPlaningsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UserPlaning = await _unitOfWork.UserPlaningRepository.GetByIdAsync(id);

            if (UserPlaning is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserPlaningDto = Mapper.Map(UserPlaning);

            return OkResult( CustomMessage.DefaultMessage , UserPlaningDto);

        }
    }
}
