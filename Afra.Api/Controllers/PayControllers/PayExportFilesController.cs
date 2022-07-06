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

namespace Afra.Api.Controllers.PayExportFilesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayExportFilesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayExportFilesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayExportFilesCommand command)
        {
            command.Validate();

            var PayExportFiless = await _unitOfWork.PayExportFilesRepository.FindAsync(c => c.Id == command.Id);

            if (PayExportFiless.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayExportFiles = Mapper.Map(command);
            await _unitOfWork.PayExportFilesRepository.AddAsync(newPayExportFiles);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayExportFilesCommand command)
        {

            command.Validate();

            var PayExportFiles = await _unitOfWork.PayExportFilesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayExportFiles == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayExportFiles = Mapper.Map(PayExportFiles, command);
            PayExportFiles.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayExportFiles = await _unitOfWork.PayExportFilesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayExportFiles == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayExportFiles.IsActive = false;
            PayExportFiles.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayExportFiless = await _unitOfWork.PayExportFilesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayExportFilessDto = Mapper.Map(PayExportFiless);

            return OkResult(CustomMessage.DefaultMessage, PayExportFilessDto.ToPagingAndSorting(query), PayExportFilessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayExportFiles = await _unitOfWork.PayExportFilesRepository.GetByIdAsync(id);

            if (PayExportFiles is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayExportFilesDto = Mapper.Map(PayExportFiles);

            return OkResult( CustomMessage.DefaultMessage , PayExportFilesDto);

        }
    }
}
