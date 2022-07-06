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

namespace Afra.Api.Controllers.TrsPayBoredOprControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsPayBoredOprController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsPayBoredOprController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsPayBoredOprCommand command)
        {
            command.Validate();

            var TrsPayBoredOprs = await _unitOfWork.TrsPayBoredOprRepository.FindAsync(c => c.Id == command.Id);

            if (TrsPayBoredOprs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsPayBoredOpr = Mapper.Map(command);
            await _unitOfWork.TrsPayBoredOprRepository.AddAsync(newTrsPayBoredOpr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsPayBoredOprCommand command)
        {

            command.Validate();

            var TrsPayBoredOpr = await _unitOfWork.TrsPayBoredOprRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsPayBoredOpr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsPayBoredOpr = Mapper.Map(TrsPayBoredOpr, command);
            TrsPayBoredOpr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsPayBoredOpr = await _unitOfWork.TrsPayBoredOprRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsPayBoredOpr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsPayBoredOpr.IsActive = false;
            TrsPayBoredOpr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsPayBoredOprs = await _unitOfWork.TrsPayBoredOprRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsPayBoredOprsDto = Mapper.Map(TrsPayBoredOprs);

            return OkResult(CustomMessage.DefaultMessage, TrsPayBoredOprsDto.ToPagingAndSorting(query), TrsPayBoredOprsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsPayBoredOpr = await _unitOfWork.TrsPayBoredOprRepository.GetByIdAsync(id);

            if (TrsPayBoredOpr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsPayBoredOprDto = Mapper.Map(TrsPayBoredOpr);

            return OkResult( CustomMessage.DefaultMessage , TrsPayBoredOprDto);

        }
    }
}
