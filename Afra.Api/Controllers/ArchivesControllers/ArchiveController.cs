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

namespace Afra.Api.Controllers.ArchiveControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ArchiveController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ArchiveController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddArchiveCommand command)
        {
            command.Validate();

            var Archives = await _unitOfWork.ArchiveRepository.FindAsync(c => c.Id == command.Id);

            if (Archives.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newArchive = Mapper.Map(command);
            await _unitOfWork.ArchiveRepository.AddAsync(newArchive);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditArchiveCommand command)
        {

            command.Validate();

            var Archive = await _unitOfWork.ArchiveRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Archive == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Archive = Mapper.Map(Archive, command);
            Archive.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Archive = await _unitOfWork.ArchiveRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Archive == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Archive.IsActive = false;
            Archive.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Archives = await _unitOfWork.ArchiveRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ArchivesDto = Mapper.Map(Archives);

            return OkResult(CustomMessage.DefaultMessage, ArchivesDto.ToPagingAndSorting(query), ArchivesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Archive = await _unitOfWork.ArchiveRepository.GetByIdAsync(id);

            if (Archive is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ArchiveDto = Mapper.Map(Archive);

            return OkResult( CustomMessage.DefaultMessage , ArchiveDto);

        }
    }
}
