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

namespace Afra.Api.Controllers.ArchTypesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ArchTypesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ArchTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddArchTypesCommand command)
        {
            command.Validate();

            var ArchTypess = await _unitOfWork.ArchTypesRepository.FindAsync(c => c.Id == command.Id);

            if (ArchTypess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newArchTypes = Mapper.Map(command);
            await _unitOfWork.ArchTypesRepository.AddAsync(newArchTypes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditArchTypesCommand command)
        {

            command.Validate();

            var ArchTypes = await _unitOfWork.ArchTypesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ArchTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ArchTypes = Mapper.Map(ArchTypes, command);
            ArchTypes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ArchTypes = await _unitOfWork.ArchTypesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ArchTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ArchTypes.IsActive = false;
            ArchTypes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ArchTypess = await _unitOfWork.ArchTypesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ArchTypessDto = Mapper.Map(ArchTypess);

            return OkResult(CustomMessage.DefaultMessage, ArchTypessDto.ToPagingAndSorting(query), ArchTypessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ArchTypes = await _unitOfWork.ArchTypesRepository.GetByIdAsync(id);

            if (ArchTypes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ArchTypesDto = Mapper.Map(ArchTypes);

            return OkResult( CustomMessage.DefaultMessage , ArchTypesDto);

        }
    }
}
