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

namespace Afra.Api.Controllers.InvVchItmRateControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvVchItmRateController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvVchItmRateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvVchItmRateCommand command)
        {
            command.Validate();

            var InvVchItmRates = await _unitOfWork.InvVchItmRateRepository.FindAsync(c => c.Id == command.Id);

            if (InvVchItmRates.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvVchItmRate = Mapper.Map(command);
            await _unitOfWork.InvVchItmRateRepository.AddAsync(newInvVchItmRate);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvVchItmRateCommand command)
        {

            command.Validate();

            var InvVchItmRate = await _unitOfWork.InvVchItmRateRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvVchItmRate == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvVchItmRate = Mapper.Map(InvVchItmRate, command);
            InvVchItmRate.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvVchItmRate = await _unitOfWork.InvVchItmRateRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvVchItmRate == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvVchItmRate.IsActive = false;
            InvVchItmRate.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvVchItmRates = await _unitOfWork.InvVchItmRateRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvVchItmRatesDto = Mapper.Map(InvVchItmRates);

            return OkResult(CustomMessage.DefaultMessage, InvVchItmRatesDto.ToPagingAndSorting(query), InvVchItmRatesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvVchItmRate = await _unitOfWork.InvVchItmRateRepository.GetByIdAsync(id);

            if (InvVchItmRate is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvVchItmRateDto = Mapper.Map(InvVchItmRate);

            return OkResult( CustomMessage.DefaultMessage , InvVchItmRateDto);

        }
    }
}
