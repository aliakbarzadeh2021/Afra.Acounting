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

namespace Afra.Api.Controllers.PayAccVchDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayAccVchDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayAccVchDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayAccVchDetCommand command)
        {
            command.Validate();

            var PayAccVchDets = await _unitOfWork.PayAccVchDetRepository.FindAsync(c => c.Id == command.Id);

            if (PayAccVchDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayAccVchDet = Mapper.Map(command);
            await _unitOfWork.PayAccVchDetRepository.AddAsync(newPayAccVchDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayAccVchDetCommand command)
        {

            command.Validate();

            var PayAccVchDet = await _unitOfWork.PayAccVchDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayAccVchDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayAccVchDet = Mapper.Map(PayAccVchDet, command);
            PayAccVchDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayAccVchDet = await _unitOfWork.PayAccVchDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayAccVchDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayAccVchDet.IsActive = false;
            PayAccVchDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayAccVchDets = await _unitOfWork.PayAccVchDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayAccVchDetsDto = Mapper.Map(PayAccVchDets);

            return OkResult(CustomMessage.DefaultMessage, PayAccVchDetsDto.ToPagingAndSorting(query), PayAccVchDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayAccVchDet = await _unitOfWork.PayAccVchDetRepository.GetByIdAsync(id);

            if (PayAccVchDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayAccVchDetDto = Mapper.Map(PayAccVchDet);

            return OkResult( CustomMessage.DefaultMessage , PayAccVchDetDto);

        }
    }
}
