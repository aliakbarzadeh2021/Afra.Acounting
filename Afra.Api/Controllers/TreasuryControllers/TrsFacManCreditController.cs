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

namespace Afra.Api.Controllers.TrsFacManCreditControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFacManCreditController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFacManCreditController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFacManCreditCommand command)
        {
            command.Validate();

            var TrsFacManCredits = await _unitOfWork.TrsFacManCreditRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFacManCredits.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFacManCredit = Mapper.Map(command);
            await _unitOfWork.TrsFacManCreditRepository.AddAsync(newTrsFacManCredit);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFacManCreditCommand command)
        {

            command.Validate();

            var TrsFacManCredit = await _unitOfWork.TrsFacManCreditRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFacManCredit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacManCredit = Mapper.Map(TrsFacManCredit, command);
            TrsFacManCredit.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFacManCredit = await _unitOfWork.TrsFacManCreditRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFacManCredit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacManCredit.IsActive = false;
            TrsFacManCredit.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFacManCredits = await _unitOfWork.TrsFacManCreditRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFacManCreditsDto = Mapper.Map(TrsFacManCredits);

            return OkResult(CustomMessage.DefaultMessage, TrsFacManCreditsDto.ToPagingAndSorting(query), TrsFacManCreditsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFacManCredit = await _unitOfWork.TrsFacManCreditRepository.GetByIdAsync(id);

            if (TrsFacManCredit is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFacManCreditDto = Mapper.Map(TrsFacManCredit);

            return OkResult( CustomMessage.DefaultMessage , TrsFacManCreditDto);

        }
    }
}
