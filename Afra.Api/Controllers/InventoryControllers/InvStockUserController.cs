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

namespace Afra.Api.Controllers.InvStockUserControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvStockUserController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvStockUserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvStockUserCommand command)
        {
            command.Validate();

            var InvStockUsers = await _unitOfWork.InvStockUserRepository.FindAsync(c => c.Id == command.Id);

            if (InvStockUsers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvStockUser = Mapper.Map(command);
            await _unitOfWork.InvStockUserRepository.AddAsync(newInvStockUser);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvStockUserCommand command)
        {

            command.Validate();

            var InvStockUser = await _unitOfWork.InvStockUserRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvStockUser == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvStockUser = Mapper.Map(InvStockUser, command);
            InvStockUser.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvStockUser = await _unitOfWork.InvStockUserRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvStockUser == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvStockUser.IsActive = false;
            InvStockUser.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvStockUsers = await _unitOfWork.InvStockUserRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvStockUsersDto = Mapper.Map(InvStockUsers);

            return OkResult(CustomMessage.DefaultMessage, InvStockUsersDto.ToPagingAndSorting(query), InvStockUsersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvStockUser = await _unitOfWork.InvStockUserRepository.GetByIdAsync(id);

            if (InvStockUser is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvStockUserDto = Mapper.Map(InvStockUser);

            return OkResult( CustomMessage.DefaultMessage , InvStockUserDto);

        }
    }
}
