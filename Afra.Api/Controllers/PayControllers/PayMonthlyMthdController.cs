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

namespace Afra.Api.Controllers.PayMonthlyMthdControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayMonthlyMthdController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayMonthlyMthdController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayMonthlyMthdCommand command)
        {
            command.Validate();

            var PayMonthlyMthds = await _unitOfWork.PayMonthlyMthdRepository.FindAsync(c => c.Id == command.Id);

            if (PayMonthlyMthds.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayMonthlyMthd = Mapper.Map(command);
            await _unitOfWork.PayMonthlyMthdRepository.AddAsync(newPayMonthlyMthd);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayMonthlyMthdCommand command)
        {

            command.Validate();

            var PayMonthlyMthd = await _unitOfWork.PayMonthlyMthdRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayMonthlyMthd == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayMonthlyMthd = Mapper.Map(PayMonthlyMthd, command);
            PayMonthlyMthd.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayMonthlyMthd = await _unitOfWork.PayMonthlyMthdRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayMonthlyMthd == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayMonthlyMthd.IsActive = false;
            PayMonthlyMthd.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayMonthlyMthds = await _unitOfWork.PayMonthlyMthdRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayMonthlyMthdsDto = Mapper.Map(PayMonthlyMthds);

            return OkResult(CustomMessage.DefaultMessage, PayMonthlyMthdsDto.ToPagingAndSorting(query), PayMonthlyMthdsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayMonthlyMthd = await _unitOfWork.PayMonthlyMthdRepository.GetByIdAsync(id);

            if (PayMonthlyMthd is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayMonthlyMthdDto = Mapper.Map(PayMonthlyMthd);

            return OkResult( CustomMessage.DefaultMessage , PayMonthlyMthdDto);

        }
    }
}
