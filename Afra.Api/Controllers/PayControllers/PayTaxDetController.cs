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

namespace Afra.Api.Controllers.PayTaxDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayTaxDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayTaxDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayTaxDetCommand command)
        {
            command.Validate();

            var PayTaxDets = await _unitOfWork.PayTaxDetRepository.FindAsync(c => c.Id == command.Id);

            if (PayTaxDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayTaxDet = Mapper.Map(command);
            await _unitOfWork.PayTaxDetRepository.AddAsync(newPayTaxDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayTaxDetCommand command)
        {

            command.Validate();

            var PayTaxDet = await _unitOfWork.PayTaxDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayTaxDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayTaxDet = Mapper.Map(PayTaxDet, command);
            PayTaxDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayTaxDet = await _unitOfWork.PayTaxDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayTaxDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayTaxDet.IsActive = false;
            PayTaxDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayTaxDets = await _unitOfWork.PayTaxDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayTaxDetsDto = Mapper.Map(PayTaxDets);

            return OkResult(CustomMessage.DefaultMessage, PayTaxDetsDto.ToPagingAndSorting(query), PayTaxDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayTaxDet = await _unitOfWork.PayTaxDetRepository.GetByIdAsync(id);

            if (PayTaxDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayTaxDetDto = Mapper.Map(PayTaxDet);

            return OkResult( CustomMessage.DefaultMessage , PayTaxDetDto);

        }
    }
}
