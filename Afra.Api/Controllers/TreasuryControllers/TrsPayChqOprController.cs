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

namespace Afra.Api.Controllers.TrsPayChqOprControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsPayChqOprController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsPayChqOprController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsPayChqOprCommand command)
        {
            command.Validate();

            var TrsPayChqOprs = await _unitOfWork.TrsPayChqOprRepository.FindAsync(c => c.Id == command.Id);

            if (TrsPayChqOprs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsPayChqOpr = Mapper.Map(command);
            await _unitOfWork.TrsPayChqOprRepository.AddAsync(newTrsPayChqOpr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsPayChqOprCommand command)
        {

            command.Validate();

            var TrsPayChqOpr = await _unitOfWork.TrsPayChqOprRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsPayChqOpr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsPayChqOpr = Mapper.Map(TrsPayChqOpr, command);
            TrsPayChqOpr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsPayChqOpr = await _unitOfWork.TrsPayChqOprRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsPayChqOpr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsPayChqOpr.IsActive = false;
            TrsPayChqOpr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsPayChqOprs = await _unitOfWork.TrsPayChqOprRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsPayChqOprsDto = Mapper.Map(TrsPayChqOprs);

            return OkResult(CustomMessage.DefaultMessage, TrsPayChqOprsDto.ToPagingAndSorting(query), TrsPayChqOprsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsPayChqOpr = await _unitOfWork.TrsPayChqOprRepository.GetByIdAsync(id);

            if (TrsPayChqOpr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsPayChqOprDto = Mapper.Map(TrsPayChqOpr);

            return OkResult( CustomMessage.DefaultMessage , TrsPayChqOprDto);

        }
    }
}
