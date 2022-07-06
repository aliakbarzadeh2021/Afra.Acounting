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

namespace Afra.Api.Controllers.AstAssetRateControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AstAssetRateController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AstAssetRateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAstAssetRateCommand command)
        {
            command.Validate();

            var AstAssetRates = await _unitOfWork.AstAssetRateRepository.FindAsync(c => c.Id == command.Id);

            if (AstAssetRates.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAstAssetRate = Mapper.Map(command);
            await _unitOfWork.AstAssetRateRepository.AddAsync(newAstAssetRate);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAstAssetRateCommand command)
        {

            command.Validate();

            var AstAssetRate = await _unitOfWork.AstAssetRateRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AstAssetRate == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstAssetRate = Mapper.Map(AstAssetRate, command);
            AstAssetRate.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AstAssetRate = await _unitOfWork.AstAssetRateRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AstAssetRate == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstAssetRate.IsActive = false;
            AstAssetRate.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AstAssetRates = await _unitOfWork.AstAssetRateRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AstAssetRatesDto = Mapper.Map(AstAssetRates);

            return OkResult(CustomMessage.DefaultMessage, AstAssetRatesDto.ToPagingAndSorting(query), AstAssetRatesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AstAssetRate = await _unitOfWork.AstAssetRateRepository.GetByIdAsync(id);

            if (AstAssetRate is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AstAssetRateDto = Mapper.Map(AstAssetRate);

            return OkResult( CustomMessage.DefaultMessage , AstAssetRateDto);

        }
    }
}
