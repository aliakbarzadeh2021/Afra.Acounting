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

namespace Afra.Api.Controllers.QcsMenLabsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QcsMenLabsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QcsMenLabsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQcsMenLabsCommand command)
        {
            command.Validate();

            var QcsMenLabss = await _unitOfWork.QcsMenLabsRepository.FindAsync(c => c.Id == command.Id);

            if (QcsMenLabss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQcsMenLabs = Mapper.Map(command);
            await _unitOfWork.QcsMenLabsRepository.AddAsync(newQcsMenLabs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQcsMenLabsCommand command)
        {

            command.Validate();

            var QcsMenLabs = await _unitOfWork.QcsMenLabsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (QcsMenLabs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsMenLabs = Mapper.Map(QcsMenLabs, command);
            QcsMenLabs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var QcsMenLabs = await _unitOfWork.QcsMenLabsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (QcsMenLabs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsMenLabs.IsActive = false;
            QcsMenLabs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var QcsMenLabss = await _unitOfWork.QcsMenLabsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QcsMenLabssDto = Mapper.Map(QcsMenLabss);

            return OkResult(CustomMessage.DefaultMessage, QcsMenLabssDto.ToPagingAndSorting(query), QcsMenLabssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var QcsMenLabs = await _unitOfWork.QcsMenLabsRepository.GetByIdAsync(id);

            if (QcsMenLabs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QcsMenLabsDto = Mapper.Map(QcsMenLabs);

            return OkResult( CustomMessage.DefaultMessage , QcsMenLabsDto);

        }
    }
}
