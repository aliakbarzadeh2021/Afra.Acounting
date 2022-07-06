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

namespace Afra.Api.Controllers.SleVchTaxControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleVchTaxController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleVchTaxController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleVchTaxCommand command)
        {
            command.Validate();

            var SleVchTaxs = await _unitOfWork.SleVchTaxRepository.FindAsync(c => c.Id == command.Id);

            if (SleVchTaxs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleVchTax = Mapper.Map(command);
            await _unitOfWork.SleVchTaxRepository.AddAsync(newSleVchTax);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleVchTaxCommand command)
        {

            command.Validate();

            var SleVchTax = await _unitOfWork.SleVchTaxRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleVchTax == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleVchTax = Mapper.Map(SleVchTax, command);
            SleVchTax.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleVchTax = await _unitOfWork.SleVchTaxRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleVchTax == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleVchTax.IsActive = false;
            SleVchTax.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleVchTaxs = await _unitOfWork.SleVchTaxRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleVchTaxsDto = Mapper.Map(SleVchTaxs);

            return OkResult(CustomMessage.DefaultMessage, SleVchTaxsDto.ToPagingAndSorting(query), SleVchTaxsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleVchTax = await _unitOfWork.SleVchTaxRepository.GetByIdAsync(id);

            if (SleVchTax is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleVchTaxDto = Mapper.Map(SleVchTax);

            return OkResult( CustomMessage.DefaultMessage , SleVchTaxDto);

        }
    }
}
