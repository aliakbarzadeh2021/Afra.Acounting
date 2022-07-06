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

namespace Afra.Api.Controllers.SleBrokerSalaryTaxControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleBrokerSalaryTaxController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleBrokerSalaryTaxController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleBrokerSalaryTaxCommand command)
        {
            command.Validate();

            var SleBrokerSalaryTaxs = await _unitOfWork.SleBrokerSalaryTaxRepository.FindAsync(c => c.Id == command.Id);

            if (SleBrokerSalaryTaxs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleBrokerSalaryTax = Mapper.Map(command);
            await _unitOfWork.SleBrokerSalaryTaxRepository.AddAsync(newSleBrokerSalaryTax);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleBrokerSalaryTaxCommand command)
        {

            command.Validate();

            var SleBrokerSalaryTax = await _unitOfWork.SleBrokerSalaryTaxRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleBrokerSalaryTax == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleBrokerSalaryTax = Mapper.Map(SleBrokerSalaryTax, command);
            SleBrokerSalaryTax.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleBrokerSalaryTax = await _unitOfWork.SleBrokerSalaryTaxRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleBrokerSalaryTax == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleBrokerSalaryTax.IsActive = false;
            SleBrokerSalaryTax.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleBrokerSalaryTaxs = await _unitOfWork.SleBrokerSalaryTaxRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleBrokerSalaryTaxsDto = Mapper.Map(SleBrokerSalaryTaxs);

            return OkResult(CustomMessage.DefaultMessage, SleBrokerSalaryTaxsDto.ToPagingAndSorting(query), SleBrokerSalaryTaxsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleBrokerSalaryTax = await _unitOfWork.SleBrokerSalaryTaxRepository.GetByIdAsync(id);

            if (SleBrokerSalaryTax is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleBrokerSalaryTaxDto = Mapper.Map(SleBrokerSalaryTax);

            return OkResult( CustomMessage.DefaultMessage , SleBrokerSalaryTaxDto);

        }
    }
}
