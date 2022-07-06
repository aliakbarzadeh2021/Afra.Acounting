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

namespace Afra.Api.Controllers.SleGuaranteeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleGuaranteeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleGuaranteeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleGuaranteeCommand command)
        {
            command.Validate();

            var SleGuarantees = await _unitOfWork.SleGuaranteeRepository.FindAsync(c => c.Id == command.Id);

            if (SleGuarantees.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleGuarantee = Mapper.Map(command);
            await _unitOfWork.SleGuaranteeRepository.AddAsync(newSleGuarantee);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleGuaranteeCommand command)
        {

            command.Validate();

            var SleGuarantee = await _unitOfWork.SleGuaranteeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleGuarantee == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleGuarantee = Mapper.Map(SleGuarantee, command);
            SleGuarantee.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleGuarantee = await _unitOfWork.SleGuaranteeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleGuarantee == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleGuarantee.IsActive = false;
            SleGuarantee.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleGuarantees = await _unitOfWork.SleGuaranteeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleGuaranteesDto = Mapper.Map(SleGuarantees);

            return OkResult(CustomMessage.DefaultMessage, SleGuaranteesDto.ToPagingAndSorting(query), SleGuaranteesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleGuarantee = await _unitOfWork.SleGuaranteeRepository.GetByIdAsync(id);

            if (SleGuarantee is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleGuaranteeDto = Mapper.Map(SleGuarantee);

            return OkResult( CustomMessage.DefaultMessage , SleGuaranteeDto);

        }
    }
}
