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

namespace Afra.Api.Controllers.TrsGuaranteeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsGuaranteeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsGuaranteeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsGuaranteeCommand command)
        {
            command.Validate();

            var TrsGuarantees = await _unitOfWork.TrsGuaranteeRepository.FindAsync(c => c.Id == command.Id);

            if (TrsGuarantees.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsGuarantee = Mapper.Map(command);
            await _unitOfWork.TrsGuaranteeRepository.AddAsync(newTrsGuarantee);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsGuaranteeCommand command)
        {

            command.Validate();

            var TrsGuarantee = await _unitOfWork.TrsGuaranteeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsGuarantee == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsGuarantee = Mapper.Map(TrsGuarantee, command);
            TrsGuarantee.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsGuarantee = await _unitOfWork.TrsGuaranteeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsGuarantee == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsGuarantee.IsActive = false;
            TrsGuarantee.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsGuarantees = await _unitOfWork.TrsGuaranteeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsGuaranteesDto = Mapper.Map(TrsGuarantees);

            return OkResult(CustomMessage.DefaultMessage, TrsGuaranteesDto.ToPagingAndSorting(query), TrsGuaranteesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsGuarantee = await _unitOfWork.TrsGuaranteeRepository.GetByIdAsync(id);

            if (TrsGuarantee is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsGuaranteeDto = Mapper.Map(TrsGuarantee);

            return OkResult( CustomMessage.DefaultMessage , TrsGuaranteeDto);

        }
    }
}
