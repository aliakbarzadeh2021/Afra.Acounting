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

namespace Afra.Api.Controllers.OtoFilesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoFilesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoFilesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoFilesCommand command)
        {
            command.Validate();

            var OtoFiless = await _unitOfWork.OtoFilesRepository.FindAsync(c => c.Id == command.Id);

            if (OtoFiless.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoFiles = Mapper.Map(command);
            await _unitOfWork.OtoFilesRepository.AddAsync(newOtoFiles);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoFilesCommand command)
        {

            command.Validate();

            var OtoFiles = await _unitOfWork.OtoFilesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoFiles == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoFiles = Mapper.Map(OtoFiles, command);
            OtoFiles.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoFiles = await _unitOfWork.OtoFilesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoFiles == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoFiles.IsActive = false;
            OtoFiles.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoFiless = await _unitOfWork.OtoFilesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoFilessDto = Mapper.Map(OtoFiless);

            return OkResult(CustomMessage.DefaultMessage, OtoFilessDto.ToPagingAndSorting(query), OtoFilessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoFiles = await _unitOfWork.OtoFilesRepository.GetByIdAsync(id);

            if (OtoFiles is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoFilesDto = Mapper.Map(OtoFiles);

            return OkResult( CustomMessage.DefaultMessage , OtoFilesDto);

        }
    }
}
