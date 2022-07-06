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

namespace Afra.Api.Controllers.UserProcessControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserProcessController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserProcessController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserProcessCommand command)
        {
            command.Validate();

            var UserProcesss = await _unitOfWork.UserProcessRepository.FindAsync(c => c.Id == command.Id);

            if (UserProcesss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUserProcess = Mapper.Map(command);
            await _unitOfWork.UserProcessRepository.AddAsync(newUserProcess);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserProcessCommand command)
        {

            command.Validate();

            var UserProcess = await _unitOfWork.UserProcessRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UserProcess == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserProcess = Mapper.Map(UserProcess, command);
            UserProcess.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UserProcess = await _unitOfWork.UserProcessRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UserProcess == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserProcess.IsActive = false;
            UserProcess.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UserProcesss = await _unitOfWork.UserProcessRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserProcesssDto = Mapper.Map(UserProcesss);

            return OkResult(CustomMessage.DefaultMessage, UserProcesssDto.ToPagingAndSorting(query), UserProcesssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UserProcess = await _unitOfWork.UserProcessRepository.GetByIdAsync(id);

            if (UserProcess is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserProcessDto = Mapper.Map(UserProcess);

            return OkResult( CustomMessage.DefaultMessage , UserProcessDto);

        }
    }
}
