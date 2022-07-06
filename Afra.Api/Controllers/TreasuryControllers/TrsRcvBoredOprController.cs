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

namespace Afra.Api.Controllers.TrsRcvBoredOprControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsRcvBoredOprController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsRcvBoredOprController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsRcvBoredOprCommand command)
        {
            command.Validate();

            var TrsRcvBoredOprs = await _unitOfWork.TrsRcvBoredOprRepository.FindAsync(c => c.Id == command.Id);

            if (TrsRcvBoredOprs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsRcvBoredOpr = Mapper.Map(command);
            await _unitOfWork.TrsRcvBoredOprRepository.AddAsync(newTrsRcvBoredOpr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsRcvBoredOprCommand command)
        {

            command.Validate();

            var TrsRcvBoredOpr = await _unitOfWork.TrsRcvBoredOprRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsRcvBoredOpr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsRcvBoredOpr = Mapper.Map(TrsRcvBoredOpr, command);
            TrsRcvBoredOpr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsRcvBoredOpr = await _unitOfWork.TrsRcvBoredOprRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsRcvBoredOpr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsRcvBoredOpr.IsActive = false;
            TrsRcvBoredOpr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsRcvBoredOprs = await _unitOfWork.TrsRcvBoredOprRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsRcvBoredOprsDto = Mapper.Map(TrsRcvBoredOprs);

            return OkResult(CustomMessage.DefaultMessage, TrsRcvBoredOprsDto.ToPagingAndSorting(query), TrsRcvBoredOprsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsRcvBoredOpr = await _unitOfWork.TrsRcvBoredOprRepository.GetByIdAsync(id);

            if (TrsRcvBoredOpr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsRcvBoredOprDto = Mapper.Map(TrsRcvBoredOpr);

            return OkResult( CustomMessage.DefaultMessage , TrsRcvBoredOprDto);

        }
    }
}
