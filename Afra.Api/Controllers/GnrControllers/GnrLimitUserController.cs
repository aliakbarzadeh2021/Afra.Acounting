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

namespace Afra.Api.Controllers.GnrLimitUserControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrLimitUserController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrLimitUserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrLimitUserCommand command)
        {
            command.Validate();

            var GnrLimitUsers = await _unitOfWork.GnrLimitUserRepository.FindAsync(c => c.Id == command.Id);

            if (GnrLimitUsers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrLimitUser = Mapper.Map(command);
            await _unitOfWork.GnrLimitUserRepository.AddAsync(newGnrLimitUser);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrLimitUserCommand command)
        {

            command.Validate();

            var GnrLimitUser = await _unitOfWork.GnrLimitUserRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrLimitUser == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrLimitUser = Mapper.Map(GnrLimitUser, command);
            GnrLimitUser.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrLimitUser = await _unitOfWork.GnrLimitUserRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrLimitUser == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrLimitUser.IsActive = false;
            GnrLimitUser.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrLimitUsers = await _unitOfWork.GnrLimitUserRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrLimitUsersDto = Mapper.Map(GnrLimitUsers);

            return OkResult(CustomMessage.DefaultMessage, GnrLimitUsersDto.ToPagingAndSorting(query), GnrLimitUsersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrLimitUser = await _unitOfWork.GnrLimitUserRepository.GetByIdAsync(id);

            if (GnrLimitUser is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrLimitUserDto = Mapper.Map(GnrLimitUser);

            return OkResult( CustomMessage.DefaultMessage , GnrLimitUserDto);

        }
    }
}
