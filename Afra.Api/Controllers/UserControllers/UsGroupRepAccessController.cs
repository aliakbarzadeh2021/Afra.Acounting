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

namespace Afra.Api.Controllers.UsGroupRepAccessControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsGroupRepAccessController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsGroupRepAccessController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsGroupRepAccessCommand command)
        {
            command.Validate();

            var UsGroupRepAccesss = await _unitOfWork.UsGroupRepAccessRepository.FindAsync(c => c.Id == command.Id);

            if (UsGroupRepAccesss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsGroupRepAccess = Mapper.Map(command);
            await _unitOfWork.UsGroupRepAccessRepository.AddAsync(newUsGroupRepAccess);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsGroupRepAccessCommand command)
        {

            command.Validate();

            var UsGroupRepAccess = await _unitOfWork.UsGroupRepAccessRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsGroupRepAccess == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsGroupRepAccess = Mapper.Map(UsGroupRepAccess, command);
            UsGroupRepAccess.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsGroupRepAccess = await _unitOfWork.UsGroupRepAccessRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsGroupRepAccess == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsGroupRepAccess.IsActive = false;
            UsGroupRepAccess.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsGroupRepAccesss = await _unitOfWork.UsGroupRepAccessRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsGroupRepAccesssDto = Mapper.Map(UsGroupRepAccesss);

            return OkResult(CustomMessage.DefaultMessage, UsGroupRepAccesssDto.ToPagingAndSorting(query), UsGroupRepAccesssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsGroupRepAccess = await _unitOfWork.UsGroupRepAccessRepository.GetByIdAsync(id);

            if (UsGroupRepAccess is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsGroupRepAccessDto = Mapper.Map(UsGroupRepAccess);

            return OkResult( CustomMessage.DefaultMessage , UsGroupRepAccessDto);

        }
    }
}
