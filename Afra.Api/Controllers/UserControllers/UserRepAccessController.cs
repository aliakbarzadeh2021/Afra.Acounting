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

namespace Afra.Api.Controllers.UserRepAccessControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserRepAccessController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserRepAccessController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserRepAccessCommand command)
        {
            command.Validate();

            var UserRepAccesss = await _unitOfWork.UserRepAccessRepository.FindAsync(c => c.Id == command.Id);

            if (UserRepAccesss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUserRepAccess = Mapper.Map(command);
            await _unitOfWork.UserRepAccessRepository.AddAsync(newUserRepAccess);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserRepAccessCommand command)
        {

            command.Validate();

            var UserRepAccess = await _unitOfWork.UserRepAccessRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UserRepAccess == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserRepAccess = Mapper.Map(UserRepAccess, command);
            UserRepAccess.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UserRepAccess = await _unitOfWork.UserRepAccessRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UserRepAccess == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserRepAccess.IsActive = false;
            UserRepAccess.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UserRepAccesss = await _unitOfWork.UserRepAccessRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserRepAccesssDto = Mapper.Map(UserRepAccesss);

            return OkResult(CustomMessage.DefaultMessage, UserRepAccesssDto.ToPagingAndSorting(query), UserRepAccesssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UserRepAccess = await _unitOfWork.UserRepAccessRepository.GetByIdAsync(id);

            if (UserRepAccess is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserRepAccessDto = Mapper.Map(UserRepAccess);

            return OkResult( CustomMessage.DefaultMessage , UserRepAccessDto);

        }
    }
}
