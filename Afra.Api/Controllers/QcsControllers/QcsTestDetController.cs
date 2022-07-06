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

namespace Afra.Api.Controllers.QcsTestDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QcsTestDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QcsTestDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQcsTestDetCommand command)
        {
            command.Validate();

            var QcsTestDets = await _unitOfWork.QcsTestDetRepository.FindAsync(c => c.Id == command.Id);

            if (QcsTestDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQcsTestDet = Mapper.Map(command);
            await _unitOfWork.QcsTestDetRepository.AddAsync(newQcsTestDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQcsTestDetCommand command)
        {

            command.Validate();

            var QcsTestDet = await _unitOfWork.QcsTestDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (QcsTestDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsTestDet = Mapper.Map(QcsTestDet, command);
            QcsTestDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var QcsTestDet = await _unitOfWork.QcsTestDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (QcsTestDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsTestDet.IsActive = false;
            QcsTestDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var QcsTestDets = await _unitOfWork.QcsTestDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QcsTestDetsDto = Mapper.Map(QcsTestDets);

            return OkResult(CustomMessage.DefaultMessage, QcsTestDetsDto.ToPagingAndSorting(query), QcsTestDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var QcsTestDet = await _unitOfWork.QcsTestDetRepository.GetByIdAsync(id);

            if (QcsTestDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QcsTestDetDto = Mapper.Map(QcsTestDet);

            return OkResult( CustomMessage.DefaultMessage , QcsTestDetDto);

        }
    }
}
