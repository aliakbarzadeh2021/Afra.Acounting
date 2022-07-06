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

namespace Afra.Api.Controllers.QcsTestsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QcsTestsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QcsTestsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQcsTestsCommand command)
        {
            command.Validate();

            var QcsTestss = await _unitOfWork.QcsTestsRepository.FindAsync(c => c.Id == command.Id);

            if (QcsTestss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQcsTests = Mapper.Map(command);
            await _unitOfWork.QcsTestsRepository.AddAsync(newQcsTests);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQcsTestsCommand command)
        {

            command.Validate();

            var QcsTests = await _unitOfWork.QcsTestsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (QcsTests == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsTests = Mapper.Map(QcsTests, command);
            QcsTests.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var QcsTests = await _unitOfWork.QcsTestsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (QcsTests == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QcsTests.IsActive = false;
            QcsTests.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var QcsTestss = await _unitOfWork.QcsTestsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QcsTestssDto = Mapper.Map(QcsTestss);

            return OkResult(CustomMessage.DefaultMessage, QcsTestssDto.ToPagingAndSorting(query), QcsTestssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var QcsTests = await _unitOfWork.QcsTestsRepository.GetByIdAsync(id);

            if (QcsTests is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QcsTestsDto = Mapper.Map(QcsTests);

            return OkResult( CustomMessage.DefaultMessage , QcsTestsDto);

        }
    }
}
