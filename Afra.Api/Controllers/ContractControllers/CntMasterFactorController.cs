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

namespace Afra.Api.Controllers.CntMasterFactorControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntMasterFactorController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntMasterFactorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntMasterFactorCommand command)
        {
            command.Validate();

            var CntMasterFactors = await _unitOfWork.CntMasterFactorRepository.FindAsync(c => c.Id == command.Id);

            if (CntMasterFactors.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntMasterFactor = Mapper.Map(command);
            await _unitOfWork.CntMasterFactorRepository.AddAsync(newCntMasterFactor);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntMasterFactorCommand command)
        {

            command.Validate();

            var CntMasterFactor = await _unitOfWork.CntMasterFactorRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntMasterFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntMasterFactor = Mapper.Map(CntMasterFactor, command);
            CntMasterFactor.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntMasterFactor = await _unitOfWork.CntMasterFactorRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntMasterFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntMasterFactor.IsActive = false;
            CntMasterFactor.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntMasterFactors = await _unitOfWork.CntMasterFactorRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntMasterFactorsDto = Mapper.Map(CntMasterFactors);

            return OkResult(CustomMessage.DefaultMessage, CntMasterFactorsDto.ToPagingAndSorting(query), CntMasterFactorsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntMasterFactor = await _unitOfWork.CntMasterFactorRepository.GetByIdAsync(id);

            if (CntMasterFactor is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntMasterFactorDto = Mapper.Map(CntMasterFactor);

            return OkResult( CustomMessage.DefaultMessage , CntMasterFactorDto);

        }
    }
}
