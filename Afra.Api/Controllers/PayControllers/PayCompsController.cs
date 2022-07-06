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

namespace Afra.Api.Controllers.PayCompsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayCompsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayCompsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayCompsCommand command)
        {
            command.Validate();

            var PayCompss = await _unitOfWork.PayCompsRepository.FindAsync(c => c.Id == command.Id);

            if (PayCompss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayComps = Mapper.Map(command);
            await _unitOfWork.PayCompsRepository.AddAsync(newPayComps);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayCompsCommand command)
        {

            command.Validate();

            var PayComps = await _unitOfWork.PayCompsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayComps == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayComps = Mapper.Map(PayComps, command);
            PayComps.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayComps = await _unitOfWork.PayCompsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayComps == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayComps.IsActive = false;
            PayComps.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayCompss = await _unitOfWork.PayCompsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayCompssDto = Mapper.Map(PayCompss);

            return OkResult(CustomMessage.DefaultMessage, PayCompssDto.ToPagingAndSorting(query), PayCompssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayComps = await _unitOfWork.PayCompsRepository.GetByIdAsync(id);

            if (PayComps is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayCompsDto = Mapper.Map(PayComps);

            return OkResult( CustomMessage.DefaultMessage , PayCompsDto);

        }
    }
}
