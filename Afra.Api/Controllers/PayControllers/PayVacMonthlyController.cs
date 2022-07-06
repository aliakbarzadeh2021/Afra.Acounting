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

namespace Afra.Api.Controllers.PayVacMonthlyControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayVacMonthlyController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayVacMonthlyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayVacMonthlyCommand command)
        {
            command.Validate();

            var PayVacMonthlys = await _unitOfWork.PayVacMonthlyRepository.FindAsync(c => c.Id == command.Id);

            if (PayVacMonthlys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayVacMonthly = Mapper.Map(command);
            await _unitOfWork.PayVacMonthlyRepository.AddAsync(newPayVacMonthly);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayVacMonthlyCommand command)
        {

            command.Validate();

            var PayVacMonthly = await _unitOfWork.PayVacMonthlyRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayVacMonthly == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayVacMonthly = Mapper.Map(PayVacMonthly, command);
            PayVacMonthly.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayVacMonthly = await _unitOfWork.PayVacMonthlyRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayVacMonthly == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayVacMonthly.IsActive = false;
            PayVacMonthly.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayVacMonthlys = await _unitOfWork.PayVacMonthlyRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayVacMonthlysDto = Mapper.Map(PayVacMonthlys);

            return OkResult(CustomMessage.DefaultMessage, PayVacMonthlysDto.ToPagingAndSorting(query), PayVacMonthlysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayVacMonthly = await _unitOfWork.PayVacMonthlyRepository.GetByIdAsync(id);

            if (PayVacMonthly is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayVacMonthlyDto = Mapper.Map(PayVacMonthly);

            return OkResult( CustomMessage.DefaultMessage , PayVacMonthlyDto);

        }
    }
}
