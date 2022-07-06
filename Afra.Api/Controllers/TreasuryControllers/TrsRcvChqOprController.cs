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

namespace Afra.Api.Controllers.TrsRcvChqOprControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsRcvChqOprController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsRcvChqOprController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsRcvChqOprCommand command)
        {
            command.Validate();

            var TrsRcvChqOprs = await _unitOfWork.TrsRcvChqOprRepository.FindAsync(c => c.Id == command.Id);

            if (TrsRcvChqOprs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsRcvChqOpr = Mapper.Map(command);
            await _unitOfWork.TrsRcvChqOprRepository.AddAsync(newTrsRcvChqOpr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsRcvChqOprCommand command)
        {

            command.Validate();

            var TrsRcvChqOpr = await _unitOfWork.TrsRcvChqOprRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsRcvChqOpr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsRcvChqOpr = Mapper.Map(TrsRcvChqOpr, command);
            TrsRcvChqOpr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsRcvChqOpr = await _unitOfWork.TrsRcvChqOprRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsRcvChqOpr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsRcvChqOpr.IsActive = false;
            TrsRcvChqOpr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsRcvChqOprs = await _unitOfWork.TrsRcvChqOprRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsRcvChqOprsDto = Mapper.Map(TrsRcvChqOprs);

            return OkResult(CustomMessage.DefaultMessage, TrsRcvChqOprsDto.ToPagingAndSorting(query), TrsRcvChqOprsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsRcvChqOpr = await _unitOfWork.TrsRcvChqOprRepository.GetByIdAsync(id);

            if (TrsRcvChqOpr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsRcvChqOprDto = Mapper.Map(TrsRcvChqOpr);

            return OkResult( CustomMessage.DefaultMessage , TrsRcvChqOprDto);

        }
    }
}
