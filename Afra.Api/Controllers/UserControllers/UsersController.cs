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

namespace Afra.Api.Controllers.UsersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsersCommand command)
        {
            command.Validate();

            var Userss = await _unitOfWork.UsersRepository.FindAsync(c => c.Id == command.Id);

            if (Userss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsers = Mapper.Map(command);
            await _unitOfWork.UsersRepository.AddAsync(newUsers);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsersCommand command)
        {

            command.Validate();

            var Users = await _unitOfWork.UsersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Users == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Users = Mapper.Map(Users, command);
            Users.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Users = await _unitOfWork.UsersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Users == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Users.IsActive = false;
            Users.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Userss = await _unitOfWork.UsersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserssDto = Mapper.Map(Userss);

            return OkResult(CustomMessage.DefaultMessage, UserssDto.ToPagingAndSorting(query), UserssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Users = await _unitOfWork.UsersRepository.GetByIdAsync(id);

            if (Users is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsersDto = Mapper.Map(Users);

            return OkResult( CustomMessage.DefaultMessage , UsersDto);

        }
    }
}
