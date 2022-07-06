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

namespace Afra.Api.Controllers.TrsAccOprControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsAccOprController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsAccOprController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsAccOprCommand command)
        {
            command.Validate();

            var TrsAccOprs = await _unitOfWork.TrsAccOprRepository.FindAsync(c => c.Id == command.Id);

            if (TrsAccOprs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsAccOpr = Mapper.Map(command);
            await _unitOfWork.TrsAccOprRepository.AddAsync(newTrsAccOpr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsAccOprCommand command)
        {

            command.Validate();

            var TrsAccOpr = await _unitOfWork.TrsAccOprRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsAccOpr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsAccOpr = Mapper.Map(TrsAccOpr, command);
            TrsAccOpr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsAccOpr = await _unitOfWork.TrsAccOprRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsAccOpr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsAccOpr.IsActive = false;
            TrsAccOpr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsAccOprs = await _unitOfWork.TrsAccOprRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsAccOprsDto = Mapper.Map(TrsAccOprs);

            return OkResult(CustomMessage.DefaultMessage, TrsAccOprsDto.ToPagingAndSorting(query), TrsAccOprsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsAccOpr = await _unitOfWork.TrsAccOprRepository.GetByIdAsync(id);

            if (TrsAccOpr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsAccOprDto = Mapper.Map(TrsAccOpr);

            return OkResult( CustomMessage.DefaultMessage , TrsAccOprDto);

        }
    }
}
