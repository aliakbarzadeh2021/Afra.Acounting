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

namespace Afra.Api.Controllers.PayFixElmntValControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayFixElmntValController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayFixElmntValController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayFixElmntValCommand command)
        {
            command.Validate();

            var PayFixElmntVals = await _unitOfWork.PayFixElmntValRepository.FindAsync(c => c.Id == command.Id);

            if (PayFixElmntVals.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayFixElmntVal = Mapper.Map(command);
            await _unitOfWork.PayFixElmntValRepository.AddAsync(newPayFixElmntVal);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayFixElmntValCommand command)
        {

            command.Validate();

            var PayFixElmntVal = await _unitOfWork.PayFixElmntValRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayFixElmntVal == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayFixElmntVal = Mapper.Map(PayFixElmntVal, command);
            PayFixElmntVal.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayFixElmntVal = await _unitOfWork.PayFixElmntValRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayFixElmntVal == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayFixElmntVal.IsActive = false;
            PayFixElmntVal.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayFixElmntVals = await _unitOfWork.PayFixElmntValRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayFixElmntValsDto = Mapper.Map(PayFixElmntVals);

            return OkResult(CustomMessage.DefaultMessage, PayFixElmntValsDto.ToPagingAndSorting(query), PayFixElmntValsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayFixElmntVal = await _unitOfWork.PayFixElmntValRepository.GetByIdAsync(id);

            if (PayFixElmntVal is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayFixElmntValDto = Mapper.Map(PayFixElmntVal);

            return OkResult( CustomMessage.DefaultMessage , PayFixElmntValDto);

        }
    }
}
