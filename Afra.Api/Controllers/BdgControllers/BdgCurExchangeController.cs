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

namespace Afra.Api.Controllers.BdgCurExchangeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgCurExchangeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgCurExchangeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgCurExchangeCommand command)
        {
            command.Validate();

            var BdgCurExchanges = await _unitOfWork.BdgCurExchangeRepository.FindAsync(c => c.Id == command.Id);

            if (BdgCurExchanges.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgCurExchange = Mapper.Map(command);
            await _unitOfWork.BdgCurExchangeRepository.AddAsync(newBdgCurExchange);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgCurExchangeCommand command)
        {

            command.Validate();

            var BdgCurExchange = await _unitOfWork.BdgCurExchangeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgCurExchange == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgCurExchange = Mapper.Map(BdgCurExchange, command);
            BdgCurExchange.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgCurExchange = await _unitOfWork.BdgCurExchangeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgCurExchange == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgCurExchange.IsActive = false;
            BdgCurExchange.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgCurExchanges = await _unitOfWork.BdgCurExchangeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgCurExchangesDto = Mapper.Map(BdgCurExchanges);

            return OkResult(CustomMessage.DefaultMessage, BdgCurExchangesDto.ToPagingAndSorting(query), BdgCurExchangesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgCurExchange = await _unitOfWork.BdgCurExchangeRepository.GetByIdAsync(id);

            if (BdgCurExchange is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgCurExchangeDto = Mapper.Map(BdgCurExchange);

            return OkResult( CustomMessage.DefaultMessage , BdgCurExchangeDto);

        }
    }
}
