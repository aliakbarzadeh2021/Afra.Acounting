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

namespace Afra.Api.Controllers.PayLoanTypesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayLoanTypesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayLoanTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayLoanTypesCommand command)
        {
            command.Validate();

            var PayLoanTypess = await _unitOfWork.PayLoanTypesRepository.FindAsync(c => c.Id == command.Id);

            if (PayLoanTypess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayLoanTypes = Mapper.Map(command);
            await _unitOfWork.PayLoanTypesRepository.AddAsync(newPayLoanTypes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayLoanTypesCommand command)
        {

            command.Validate();

            var PayLoanTypes = await _unitOfWork.PayLoanTypesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayLoanTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayLoanTypes = Mapper.Map(PayLoanTypes, command);
            PayLoanTypes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayLoanTypes = await _unitOfWork.PayLoanTypesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayLoanTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayLoanTypes.IsActive = false;
            PayLoanTypes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayLoanTypess = await _unitOfWork.PayLoanTypesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayLoanTypessDto = Mapper.Map(PayLoanTypess);

            return OkResult(CustomMessage.DefaultMessage, PayLoanTypessDto.ToPagingAndSorting(query), PayLoanTypessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayLoanTypes = await _unitOfWork.PayLoanTypesRepository.GetByIdAsync(id);

            if (PayLoanTypes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayLoanTypesDto = Mapper.Map(PayLoanTypes);

            return OkResult( CustomMessage.DefaultMessage , PayLoanTypesDto);

        }
    }
}
