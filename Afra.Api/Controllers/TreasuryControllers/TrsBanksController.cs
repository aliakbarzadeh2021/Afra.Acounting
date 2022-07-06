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

namespace Afra.Api.Controllers.TrsBanksControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsBanksController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsBanksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsBanksCommand command)
        {
            command.Validate();

            var TrsBankss = await _unitOfWork.TrsBanksRepository.FindAsync(c => c.Id == command.Id);

            if (TrsBankss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsBanks = Mapper.Map(command);
            await _unitOfWork.TrsBanksRepository.AddAsync(newTrsBanks);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsBanksCommand command)
        {

            command.Validate();

            var TrsBanks = await _unitOfWork.TrsBanksRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsBanks == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBanks = Mapper.Map(TrsBanks, command);
            TrsBanks.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsBanks = await _unitOfWork.TrsBanksRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsBanks == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBanks.IsActive = false;
            TrsBanks.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsBankss = await _unitOfWork.TrsBanksRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsBankssDto = Mapper.Map(TrsBankss);

            return OkResult(CustomMessage.DefaultMessage, TrsBankssDto.ToPagingAndSorting(query), TrsBankssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsBanks = await _unitOfWork.TrsBanksRepository.GetByIdAsync(id);

            if (TrsBanks is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsBanksDto = Mapper.Map(TrsBanks);

            return OkResult( CustomMessage.DefaultMessage , TrsBanksDto);

        }
    }
}
