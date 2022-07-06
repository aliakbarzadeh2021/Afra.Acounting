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

namespace Afra.Api.Controllers.UserSignRightControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserSignRightController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserSignRightController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserSignRightCommand command)
        {
            command.Validate();

            var UserSignRights = await _unitOfWork.UserSignRightRepository.FindAsync(c => c.Id == command.Id);

            if (UserSignRights.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUserSignRight = Mapper.Map(command);
            await _unitOfWork.UserSignRightRepository.AddAsync(newUserSignRight);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserSignRightCommand command)
        {

            command.Validate();

            var UserSignRight = await _unitOfWork.UserSignRightRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UserSignRight == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserSignRight = Mapper.Map(UserSignRight, command);
            UserSignRight.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UserSignRight = await _unitOfWork.UserSignRightRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UserSignRight == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserSignRight.IsActive = false;
            UserSignRight.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UserSignRights = await _unitOfWork.UserSignRightRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserSignRightsDto = Mapper.Map(UserSignRights);

            return OkResult(CustomMessage.DefaultMessage, UserSignRightsDto.ToPagingAndSorting(query), UserSignRightsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UserSignRight = await _unitOfWork.UserSignRightRepository.GetByIdAsync(id);

            if (UserSignRight is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserSignRightDto = Mapper.Map(UserSignRight);

            return OkResult( CustomMessage.DefaultMessage , UserSignRightDto);

        }
    }
}
