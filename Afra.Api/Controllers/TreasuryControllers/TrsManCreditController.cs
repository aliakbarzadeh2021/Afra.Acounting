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

namespace Afra.Api.Controllers.TrsManCreditControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsManCreditController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsManCreditController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsManCreditCommand command)
        {
            command.Validate();

            var TrsManCredits = await _unitOfWork.TrsManCreditRepository.FindAsync(c => c.Id == command.Id);

            if (TrsManCredits.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsManCredit = Mapper.Map(command);
            await _unitOfWork.TrsManCreditRepository.AddAsync(newTrsManCredit);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsManCreditCommand command)
        {

            command.Validate();

            var TrsManCredit = await _unitOfWork.TrsManCreditRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsManCredit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsManCredit = Mapper.Map(TrsManCredit, command);
            TrsManCredit.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsManCredit = await _unitOfWork.TrsManCreditRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsManCredit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsManCredit.IsActive = false;
            TrsManCredit.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsManCredits = await _unitOfWork.TrsManCreditRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsManCreditsDto = Mapper.Map(TrsManCredits);

            return OkResult(CustomMessage.DefaultMessage, TrsManCreditsDto.ToPagingAndSorting(query), TrsManCreditsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsManCredit = await _unitOfWork.TrsManCreditRepository.GetByIdAsync(id);

            if (TrsManCredit is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsManCreditDto = Mapper.Map(TrsManCredit);

            return OkResult( CustomMessage.DefaultMessage , TrsManCreditDto);

        }
    }
}
