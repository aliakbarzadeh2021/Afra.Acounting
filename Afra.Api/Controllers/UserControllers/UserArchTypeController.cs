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

namespace Afra.Api.Controllers.UserArchTypeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserArchTypeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserArchTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserArchTypeCommand command)
        {
            command.Validate();

            var UserArchTypes = await _unitOfWork.UserArchTypeRepository.FindAsync(c => c.Id == command.Id);

            if (UserArchTypes.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUserArchType = Mapper.Map(command);
            await _unitOfWork.UserArchTypeRepository.AddAsync(newUserArchType);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserArchTypeCommand command)
        {

            command.Validate();

            var UserArchType = await _unitOfWork.UserArchTypeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UserArchType == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserArchType = Mapper.Map(UserArchType, command);
            UserArchType.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UserArchType = await _unitOfWork.UserArchTypeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UserArchType == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserArchType.IsActive = false;
            UserArchType.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UserArchTypes = await _unitOfWork.UserArchTypeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserArchTypesDto = Mapper.Map(UserArchTypes);

            return OkResult(CustomMessage.DefaultMessage, UserArchTypesDto.ToPagingAndSorting(query), UserArchTypesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UserArchType = await _unitOfWork.UserArchTypeRepository.GetByIdAsync(id);

            if (UserArchType is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserArchTypeDto = Mapper.Map(UserArchType);

            return OkResult( CustomMessage.DefaultMessage , UserArchTypeDto);

        }
    }
}
