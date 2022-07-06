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

namespace Afra.Api.Controllers.PayVchDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayVchDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayVchDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayVchDetCommand command)
        {
            command.Validate();

            var PayVchDets = await _unitOfWork.PayVchDetRepository.FindAsync(c => c.Id == command.Id);

            if (PayVchDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayVchDet = Mapper.Map(command);
            await _unitOfWork.PayVchDetRepository.AddAsync(newPayVchDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayVchDetCommand command)
        {

            command.Validate();

            var PayVchDet = await _unitOfWork.PayVchDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayVchDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayVchDet = Mapper.Map(PayVchDet, command);
            PayVchDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayVchDet = await _unitOfWork.PayVchDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayVchDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayVchDet.IsActive = false;
            PayVchDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayVchDets = await _unitOfWork.PayVchDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayVchDetsDto = Mapper.Map(PayVchDets);

            return OkResult(CustomMessage.DefaultMessage, PayVchDetsDto.ToPagingAndSorting(query), PayVchDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayVchDet = await _unitOfWork.PayVchDetRepository.GetByIdAsync(id);

            if (PayVchDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayVchDetDto = Mapper.Map(PayVchDet);

            return OkResult( CustomMessage.DefaultMessage , PayVchDetDto);

        }
    }
}
