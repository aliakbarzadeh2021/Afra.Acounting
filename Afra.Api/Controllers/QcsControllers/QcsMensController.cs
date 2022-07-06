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

namespace Afra.Api.Controllers.QcsMensControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QcsMensController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QcsMensController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQcsMensCommand command)
        {
            command.Validate();

            var QcsMenss = await _unitOfWork.QcsMensRepository.FindAsync(c => c.Id == command.Id);

            if (QcsMenss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQcsMens = Mapper.Map(command);
            await _unitOfWork.QcsMensRepository.AddAsync(newQcsMens);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQcsMensCommand command)
        {

            command.Validate();

            var QcsMens = await _unitOfWork.QcsMensRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (QcsMens == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsMens = Mapper.Map(QcsMens, command);
            QcsMens.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var QcsMens = await _unitOfWork.QcsMensRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (QcsMens == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsMens.IsActive = false;
            QcsMens.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var QcsMenss = await _unitOfWork.QcsMensRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QcsMenssDto = Mapper.Map(QcsMenss);

            return OkResult(CustomMessage.DefaultMessage, QcsMenssDto.ToPagingAndSorting(query), QcsMenssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var QcsMens = await _unitOfWork.QcsMensRepository.GetByIdAsync(id);

            if (QcsMens is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QcsMensDto = Mapper.Map(QcsMens);

            return OkResult( CustomMessage.DefaultMessage , QcsMensDto);

        }
    }
}
