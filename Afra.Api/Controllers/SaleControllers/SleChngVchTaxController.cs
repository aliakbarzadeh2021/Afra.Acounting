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

namespace Afra.Api.Controllers.SleChngVchTaxControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleChngVchTaxController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleChngVchTaxController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleChngVchTaxCommand command)
        {
            command.Validate();

            var SleChngVchTaxs = await _unitOfWork.SleChngVchTaxRepository.FindAsync(c => c.Id == command.Id);

            if (SleChngVchTaxs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleChngVchTax = Mapper.Map(command);
            await _unitOfWork.SleChngVchTaxRepository.AddAsync(newSleChngVchTax);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleChngVchTaxCommand command)
        {

            command.Validate();

            var SleChngVchTax = await _unitOfWork.SleChngVchTaxRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleChngVchTax == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleChngVchTax = Mapper.Map(SleChngVchTax, command);
            SleChngVchTax.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleChngVchTax = await _unitOfWork.SleChngVchTaxRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleChngVchTax == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleChngVchTax.IsActive = false;
            SleChngVchTax.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleChngVchTaxs = await _unitOfWork.SleChngVchTaxRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleChngVchTaxsDto = Mapper.Map(SleChngVchTaxs);

            return OkResult(CustomMessage.DefaultMessage, SleChngVchTaxsDto.ToPagingAndSorting(query), SleChngVchTaxsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleChngVchTax = await _unitOfWork.SleChngVchTaxRepository.GetByIdAsync(id);

            if (SleChngVchTax is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleChngVchTaxDto = Mapper.Map(SleChngVchTax);

            return OkResult( CustomMessage.DefaultMessage , SleChngVchTaxDto);

        }
    }
}
