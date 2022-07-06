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

namespace Afra.Api.Controllers.CmrInsuranceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrInsuranceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrInsuranceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrInsuranceCommand command)
        {
            command.Validate();

            var CmrInsurances = await _unitOfWork.CmrInsuranceRepository.FindAsync(c => c.Id == command.Id);

            if (CmrInsurances.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrInsurance = Mapper.Map(command);
            await _unitOfWork.CmrInsuranceRepository.AddAsync(newCmrInsurance);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrInsuranceCommand command)
        {

            command.Validate();

            var CmrInsurance = await _unitOfWork.CmrInsuranceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrInsurance == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrInsurance = Mapper.Map(CmrInsurance, command);
            CmrInsurance.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrInsurance = await _unitOfWork.CmrInsuranceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrInsurance == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrInsurance.IsActive = false;
            CmrInsurance.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrInsurances = await _unitOfWork.CmrInsuranceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrInsurancesDto = Mapper.Map(CmrInsurances);

            return OkResult(CustomMessage.DefaultMessage, CmrInsurancesDto.ToPagingAndSorting(query), CmrInsurancesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrInsurance = await _unitOfWork.CmrInsuranceRepository.GetByIdAsync(id);

            if (CmrInsurance is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrInsuranceDto = Mapper.Map(CmrInsurance);

            return OkResult( CustomMessage.DefaultMessage , CmrInsuranceDto);

        }
    }
}
