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

namespace Afra.Api.Controllers.UserProcessStpControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserProcessStpController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserProcessStpController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserProcessStpCommand command)
        {
            command.Validate();

            var UserProcessStps = await _unitOfWork.UserProcessStpRepository.FindAsync(c => c.Id == command.Id);

            if (UserProcessStps.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUserProcessStp = Mapper.Map(command);
            await _unitOfWork.UserProcessStpRepository.AddAsync(newUserProcessStp);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserProcessStpCommand command)
        {

            command.Validate();

            var UserProcessStp = await _unitOfWork.UserProcessStpRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UserProcessStp == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserProcessStp = Mapper.Map(UserProcessStp, command);
            UserProcessStp.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UserProcessStp = await _unitOfWork.UserProcessStpRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UserProcessStp == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserProcessStp.IsActive = false;
            UserProcessStp.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UserProcessStps = await _unitOfWork.UserProcessStpRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserProcessStpsDto = Mapper.Map(UserProcessStps);

            return OkResult(CustomMessage.DefaultMessage, UserProcessStpsDto.ToPagingAndSorting(query), UserProcessStpsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UserProcessStp = await _unitOfWork.UserProcessStpRepository.GetByIdAsync(id);

            if (UserProcessStp is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserProcessStpDto = Mapper.Map(UserProcessStp);

            return OkResult( CustomMessage.DefaultMessage , UserProcessStpDto);

        }
    }
}
