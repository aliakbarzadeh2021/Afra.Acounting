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

namespace Afra.Api.Controllers.QcsVchItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QcsVchItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QcsVchItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQcsVchItmCommand command)
        {
            command.Validate();

            var QcsVchItms = await _unitOfWork.QcsVchItmRepository.FindAsync(c => c.Id == command.Id);

            if (QcsVchItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQcsVchItm = Mapper.Map(command);
            await _unitOfWork.QcsVchItmRepository.AddAsync(newQcsVchItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQcsVchItmCommand command)
        {

            command.Validate();

            var QcsVchItm = await _unitOfWork.QcsVchItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (QcsVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsVchItm = Mapper.Map(QcsVchItm, command);
            QcsVchItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var QcsVchItm = await _unitOfWork.QcsVchItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (QcsVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsVchItm.IsActive = false;
            QcsVchItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var QcsVchItms = await _unitOfWork.QcsVchItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QcsVchItmsDto = Mapper.Map(QcsVchItms);

            return OkResult(CustomMessage.DefaultMessage, QcsVchItmsDto.ToPagingAndSorting(query), QcsVchItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var QcsVchItm = await _unitOfWork.QcsVchItmRepository.GetByIdAsync(id);

            if (QcsVchItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QcsVchItmDto = Mapper.Map(QcsVchItm);

            return OkResult( CustomMessage.DefaultMessage , QcsVchItmDto);

        }
    }
}
