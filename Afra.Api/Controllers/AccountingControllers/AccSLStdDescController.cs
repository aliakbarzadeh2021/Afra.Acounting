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

namespace Afra.Api.Controllers.AccSLStdDescControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccSLStdDescController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccSLStdDescController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccSLStdDescCommand command)
        {
            command.Validate();

            var AccSLStdDescs = await _unitOfWork.AccSLStdDescRepository.FindAsync(c => c.Id == command.Id);

            if (AccSLStdDescs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccSLStdDesc = Mapper.Map(command);
            await _unitOfWork.AccSLStdDescRepository.AddAsync(newAccSLStdDesc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccSLStdDescCommand command)
        {

            command.Validate();

            var AccSLStdDesc = await _unitOfWork.AccSLStdDescRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccSLStdDesc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccSLStdDesc = Mapper.Map(AccSLStdDesc, command);
            AccSLStdDesc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccSLStdDesc = await _unitOfWork.AccSLStdDescRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccSLStdDesc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccSLStdDesc.IsActive = false;
            AccSLStdDesc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccSLStdDescs = await _unitOfWork.AccSLStdDescRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccSLStdDescsDto = Mapper.Map(AccSLStdDescs);

            return OkResult(CustomMessage.DefaultMessage, AccSLStdDescsDto.ToPagingAndSorting(query), AccSLStdDescsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccSLStdDesc = await _unitOfWork.AccSLStdDescRepository.GetByIdAsync(id);

            if (AccSLStdDesc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccSLStdDescDto = Mapper.Map(AccSLStdDesc);

            return OkResult( CustomMessage.DefaultMessage , AccSLStdDescDto);

        }
    }
}
