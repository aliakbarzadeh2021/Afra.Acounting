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

namespace Afra.Api.Controllers.TaxDutyInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TaxDutyInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TaxDutyInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTaxDutyInfCommand command)
        {
            command.Validate();

            var TaxDutyInfs = await _unitOfWork.TaxDutyInfRepository.FindAsync(c => c.Id == command.Id);

            if (TaxDutyInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTaxDutyInf = Mapper.Map(command);
            await _unitOfWork.TaxDutyInfRepository.AddAsync(newTaxDutyInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTaxDutyInfCommand command)
        {

            command.Validate();

            var TaxDutyInf = await _unitOfWork.TaxDutyInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TaxDutyInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TaxDutyInf = Mapper.Map(TaxDutyInf, command);
            TaxDutyInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TaxDutyInf = await _unitOfWork.TaxDutyInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TaxDutyInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TaxDutyInf.IsActive = false;
            TaxDutyInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TaxDutyInfs = await _unitOfWork.TaxDutyInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TaxDutyInfsDto = Mapper.Map(TaxDutyInfs);

            return OkResult(CustomMessage.DefaultMessage, TaxDutyInfsDto.ToPagingAndSorting(query), TaxDutyInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TaxDutyInf = await _unitOfWork.TaxDutyInfRepository.GetByIdAsync(id);

            if (TaxDutyInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TaxDutyInfDto = Mapper.Map(TaxDutyInf);

            return OkResult( CustomMessage.DefaultMessage , TaxDutyInfDto);

        }
    }
}
