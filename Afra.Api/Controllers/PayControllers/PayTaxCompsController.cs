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

namespace Afra.Api.Controllers.PayTaxCompsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayTaxCompsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayTaxCompsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayTaxCompsCommand command)
        {
            command.Validate();

            var PayTaxCompss = await _unitOfWork.PayTaxCompsRepository.FindAsync(c => c.Id == command.Id);

            if (PayTaxCompss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayTaxComps = Mapper.Map(command);
            await _unitOfWork.PayTaxCompsRepository.AddAsync(newPayTaxComps);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayTaxCompsCommand command)
        {

            command.Validate();

            var PayTaxComps = await _unitOfWork.PayTaxCompsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayTaxComps == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayTaxComps = Mapper.Map(PayTaxComps, command);
            PayTaxComps.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayTaxComps = await _unitOfWork.PayTaxCompsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayTaxComps == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayTaxComps.IsActive = false;
            PayTaxComps.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayTaxCompss = await _unitOfWork.PayTaxCompsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayTaxCompssDto = Mapper.Map(PayTaxCompss);

            return OkResult(CustomMessage.DefaultMessage, PayTaxCompssDto.ToPagingAndSorting(query), PayTaxCompssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayTaxComps = await _unitOfWork.PayTaxCompsRepository.GetByIdAsync(id);

            if (PayTaxComps is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayTaxCompsDto = Mapper.Map(PayTaxComps);

            return OkResult( CustomMessage.DefaultMessage , PayTaxCompsDto);

        }
    }
}
