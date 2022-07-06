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

namespace Afra.Api.Controllers.PayFishElmntControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayFishElmntController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayFishElmntController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayFishElmntCommand command)
        {
            command.Validate();

            var PayFishElmnts = await _unitOfWork.PayFishElmntRepository.FindAsync(c => c.Id == command.Id);

            if (PayFishElmnts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayFishElmnt = Mapper.Map(command);
            await _unitOfWork.PayFishElmntRepository.AddAsync(newPayFishElmnt);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayFishElmntCommand command)
        {

            command.Validate();

            var PayFishElmnt = await _unitOfWork.PayFishElmntRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayFishElmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayFishElmnt = Mapper.Map(PayFishElmnt, command);
            PayFishElmnt.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayFishElmnt = await _unitOfWork.PayFishElmntRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayFishElmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayFishElmnt.IsActive = false;
            PayFishElmnt.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayFishElmnts = await _unitOfWork.PayFishElmntRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayFishElmntsDto = Mapper.Map(PayFishElmnts);

            return OkResult(CustomMessage.DefaultMessage, PayFishElmntsDto.ToPagingAndSorting(query), PayFishElmntsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayFishElmnt = await _unitOfWork.PayFishElmntRepository.GetByIdAsync(id);

            if (PayFishElmnt is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayFishElmntDto = Mapper.Map(PayFishElmnt);

            return OkResult( CustomMessage.DefaultMessage , PayFishElmntDto);

        }
    }
}
