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

namespace Afra.Api.Controllers.TrsGuaranteeOprControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsGuaranteeOprController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsGuaranteeOprController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsGuaranteeOprCommand command)
        {
            command.Validate();

            var TrsGuaranteeOprs = await _unitOfWork.TrsGuaranteeOprRepository.FindAsync(c => c.Id == command.Id);

            if (TrsGuaranteeOprs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsGuaranteeOpr = Mapper.Map(command);
            await _unitOfWork.TrsGuaranteeOprRepository.AddAsync(newTrsGuaranteeOpr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsGuaranteeOprCommand command)
        {

            command.Validate();

            var TrsGuaranteeOpr = await _unitOfWork.TrsGuaranteeOprRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsGuaranteeOpr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsGuaranteeOpr = Mapper.Map(TrsGuaranteeOpr, command);
            TrsGuaranteeOpr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsGuaranteeOpr = await _unitOfWork.TrsGuaranteeOprRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsGuaranteeOpr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsGuaranteeOpr.IsActive = false;
            TrsGuaranteeOpr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsGuaranteeOprs = await _unitOfWork.TrsGuaranteeOprRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsGuaranteeOprsDto = Mapper.Map(TrsGuaranteeOprs);

            return OkResult(CustomMessage.DefaultMessage, TrsGuaranteeOprsDto.ToPagingAndSorting(query), TrsGuaranteeOprsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsGuaranteeOpr = await _unitOfWork.TrsGuaranteeOprRepository.GetByIdAsync(id);

            if (TrsGuaranteeOpr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsGuaranteeOprDto = Mapper.Map(TrsGuaranteeOpr);

            return OkResult( CustomMessage.DefaultMessage , TrsGuaranteeOprDto);

        }
    }
}
