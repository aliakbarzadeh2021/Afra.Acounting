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

namespace Afra.Api.Controllers.PayImportFilesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayImportFilesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayImportFilesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayImportFilesCommand command)
        {
            command.Validate();

            var PayImportFiless = await _unitOfWork.PayImportFilesRepository.FindAsync(c => c.Id == command.Id);

            if (PayImportFiless.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayImportFiles = Mapper.Map(command);
            await _unitOfWork.PayImportFilesRepository.AddAsync(newPayImportFiles);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayImportFilesCommand command)
        {

            command.Validate();

            var PayImportFiles = await _unitOfWork.PayImportFilesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayImportFiles == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayImportFiles = Mapper.Map(PayImportFiles, command);
            PayImportFiles.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayImportFiles = await _unitOfWork.PayImportFilesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayImportFiles == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayImportFiles.IsActive = false;
            PayImportFiles.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayImportFiless = await _unitOfWork.PayImportFilesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayImportFilessDto = Mapper.Map(PayImportFiless);

            return OkResult(CustomMessage.DefaultMessage, PayImportFilessDto.ToPagingAndSorting(query), PayImportFilessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayImportFiles = await _unitOfWork.PayImportFilesRepository.GetByIdAsync(id);

            if (PayImportFiles is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayImportFilesDto = Mapper.Map(PayImportFiles);

            return OkResult( CustomMessage.DefaultMessage , PayImportFilesDto);

        }
    }
}
