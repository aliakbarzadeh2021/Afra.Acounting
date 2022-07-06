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

namespace Afra.Api.Controllers.TrsCostFactorsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsCostFactorsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsCostFactorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsCostFactorsCommand command)
        {
            command.Validate();

            var TrsCostFactorss = await _unitOfWork.TrsCostFactorsRepository.FindAsync(c => c.Id == command.Id);

            if (TrsCostFactorss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsCostFactors = Mapper.Map(command);
            await _unitOfWork.TrsCostFactorsRepository.AddAsync(newTrsCostFactors);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsCostFactorsCommand command)
        {

            command.Validate();

            var TrsCostFactors = await _unitOfWork.TrsCostFactorsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsCostFactors == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsCostFactors = Mapper.Map(TrsCostFactors, command);
            TrsCostFactors.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsCostFactors = await _unitOfWork.TrsCostFactorsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsCostFactors == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsCostFactors.IsActive = false;
            TrsCostFactors.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsCostFactorss = await _unitOfWork.TrsCostFactorsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsCostFactorssDto = Mapper.Map(TrsCostFactorss);

            return OkResult(CustomMessage.DefaultMessage, TrsCostFactorssDto.ToPagingAndSorting(query), TrsCostFactorssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsCostFactors = await _unitOfWork.TrsCostFactorsRepository.GetByIdAsync(id);

            if (TrsCostFactors is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsCostFactorsDto = Mapper.Map(TrsCostFactors);

            return OkResult( CustomMessage.DefaultMessage , TrsCostFactorsDto);

        }
    }
}
