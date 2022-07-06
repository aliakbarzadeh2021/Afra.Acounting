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

namespace Afra.Api.Controllers.TrsFundsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFundsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFundsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFundsCommand command)
        {
            command.Validate();

            var TrsFundss = await _unitOfWork.TrsFundsRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFundss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFunds = Mapper.Map(command);
            await _unitOfWork.TrsFundsRepository.AddAsync(newTrsFunds);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFundsCommand command)
        {

            command.Validate();

            var TrsFunds = await _unitOfWork.TrsFundsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFunds == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFunds = Mapper.Map(TrsFunds, command);
            TrsFunds.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFunds = await _unitOfWork.TrsFundsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFunds == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFunds.IsActive = false;
            TrsFunds.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFundss = await _unitOfWork.TrsFundsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFundssDto = Mapper.Map(TrsFundss);

            return OkResult(CustomMessage.DefaultMessage, TrsFundssDto.ToPagingAndSorting(query), TrsFundssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFunds = await _unitOfWork.TrsFundsRepository.GetByIdAsync(id);

            if (TrsFunds is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFundsDto = Mapper.Map(TrsFunds);

            return OkResult( CustomMessage.DefaultMessage , TrsFundsDto);

        }
    }
}
