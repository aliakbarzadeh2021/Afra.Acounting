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

namespace Afra.Api.Controllers.QcsBasesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QcsBasesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QcsBasesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQcsBasesCommand command)
        {
            command.Validate();

            var QcsBasess = await _unitOfWork.QcsBasesRepository.FindAsync(c => c.Id == command.Id);

            if (QcsBasess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQcsBases = Mapper.Map(command);
            await _unitOfWork.QcsBasesRepository.AddAsync(newQcsBases);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQcsBasesCommand command)
        {

            command.Validate();

            var QcsBases = await _unitOfWork.QcsBasesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (QcsBases == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsBases = Mapper.Map(QcsBases, command);
            QcsBases.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var QcsBases = await _unitOfWork.QcsBasesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (QcsBases == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsBases.IsActive = false;
            QcsBases.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var QcsBasess = await _unitOfWork.QcsBasesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QcsBasessDto = Mapper.Map(QcsBasess);

            return OkResult(CustomMessage.DefaultMessage, QcsBasessDto.ToPagingAndSorting(query), QcsBasessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var QcsBases = await _unitOfWork.QcsBasesRepository.GetByIdAsync(id);

            if (QcsBases is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QcsBasesDto = Mapper.Map(QcsBases);

            return OkResult( CustomMessage.DefaultMessage , QcsBasesDto);

        }
    }
}
