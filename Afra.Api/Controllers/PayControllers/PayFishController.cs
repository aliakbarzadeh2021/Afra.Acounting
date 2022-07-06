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

namespace Afra.Api.Controllers.PayFishControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayFishController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayFishController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayFishCommand command)
        {
            command.Validate();

            var PayFishs = await _unitOfWork.PayFishRepository.FindAsync(c => c.Id == command.Id);

            if (PayFishs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayFish = Mapper.Map(command);
            await _unitOfWork.PayFishRepository.AddAsync(newPayFish);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayFishCommand command)
        {

            command.Validate();

            var PayFish = await _unitOfWork.PayFishRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayFish == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayFish = Mapper.Map(PayFish, command);
            PayFish.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayFish = await _unitOfWork.PayFishRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayFish == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayFish.IsActive = false;
            PayFish.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayFishs = await _unitOfWork.PayFishRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayFishsDto = Mapper.Map(PayFishs);

            return OkResult(CustomMessage.DefaultMessage, PayFishsDto.ToPagingAndSorting(query), PayFishsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayFish = await _unitOfWork.PayFishRepository.GetByIdAsync(id);

            if (PayFish is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayFishDto = Mapper.Map(PayFish);

            return OkResult( CustomMessage.DefaultMessage , PayFishDto);

        }
    }
}
