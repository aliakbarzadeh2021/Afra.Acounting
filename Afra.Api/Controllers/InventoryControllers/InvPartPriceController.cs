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

namespace Afra.Api.Controllers.InvPartPriceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvPartPriceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvPartPriceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvPartPriceCommand command)
        {
            command.Validate();

            var InvPartPrices = await _unitOfWork.InvPartPriceRepository.FindAsync(c => c.Id == command.Id);

            if (InvPartPrices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvPartPrice = Mapper.Map(command);
            await _unitOfWork.InvPartPriceRepository.AddAsync(newInvPartPrice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvPartPriceCommand command)
        {

            command.Validate();

            var InvPartPrice = await _unitOfWork.InvPartPriceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvPartPrice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartPrice = Mapper.Map(InvPartPrice, command);
            InvPartPrice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvPartPrice = await _unitOfWork.InvPartPriceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvPartPrice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartPrice.IsActive = false;
            InvPartPrice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvPartPrices = await _unitOfWork.InvPartPriceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvPartPricesDto = Mapper.Map(InvPartPrices);

            return OkResult(CustomMessage.DefaultMessage, InvPartPricesDto.ToPagingAndSorting(query), InvPartPricesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvPartPrice = await _unitOfWork.InvPartPriceRepository.GetByIdAsync(id);

            if (InvPartPrice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvPartPriceDto = Mapper.Map(InvPartPrice);

            return OkResult( CustomMessage.DefaultMessage , InvPartPriceDto);

        }
    }
}
