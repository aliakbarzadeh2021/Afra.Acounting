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

namespace Afra.Api.Controllers.UsGroupAccessControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsGroupAccessController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsGroupAccessController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsGroupAccessCommand command)
        {
            command.Validate();

            var UsGroupAccesss = await _unitOfWork.UsGroupAccessRepository.FindAsync(c => c.Id == command.Id);

            if (UsGroupAccesss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsGroupAccess = Mapper.Map(command);
            await _unitOfWork.UsGroupAccessRepository.AddAsync(newUsGroupAccess);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsGroupAccessCommand command)
        {

            command.Validate();

            var UsGroupAccess = await _unitOfWork.UsGroupAccessRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsGroupAccess == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsGroupAccess = Mapper.Map(UsGroupAccess, command);
            UsGroupAccess.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsGroupAccess = await _unitOfWork.UsGroupAccessRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsGroupAccess == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsGroupAccess.IsActive = false;
            UsGroupAccess.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsGroupAccesss = await _unitOfWork.UsGroupAccessRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsGroupAccesssDto = Mapper.Map(UsGroupAccesss);

            return OkResult(CustomMessage.DefaultMessage, UsGroupAccesssDto.ToPagingAndSorting(query), UsGroupAccesssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsGroupAccess = await _unitOfWork.UsGroupAccessRepository.GetByIdAsync(id);

            if (UsGroupAccess is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsGroupAccessDto = Mapper.Map(UsGroupAccess);

            return OkResult( CustomMessage.DefaultMessage , UsGroupAccessDto);

        }
    }
}
