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

namespace Afra.Api.Controllers.UserArchiveControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserArchiveController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserArchiveController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserArchiveCommand command)
        {
            command.Validate();

            var UserArchives = await _unitOfWork.UserArchiveRepository.FindAsync(c => c.Id == command.Id);

            if (UserArchives.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUserArchive = Mapper.Map(command);
            await _unitOfWork.UserArchiveRepository.AddAsync(newUserArchive);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserArchiveCommand command)
        {

            command.Validate();

            var UserArchive = await _unitOfWork.UserArchiveRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UserArchive == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserArchive = Mapper.Map(UserArchive, command);
            UserArchive.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UserArchive = await _unitOfWork.UserArchiveRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UserArchive == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserArchive.IsActive = false;
            UserArchive.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UserArchives = await _unitOfWork.UserArchiveRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserArchivesDto = Mapper.Map(UserArchives);

            return OkResult(CustomMessage.DefaultMessage, UserArchivesDto.ToPagingAndSorting(query), UserArchivesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UserArchive = await _unitOfWork.UserArchiveRepository.GetByIdAsync(id);

            if (UserArchive is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserArchiveDto = Mapper.Map(UserArchive);

            return OkResult( CustomMessage.DefaultMessage , UserArchiveDto);

        }
    }
}
