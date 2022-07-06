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

namespace Afra.Api.Controllers.BdgBalanceValsDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgBalanceValsDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgBalanceValsDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgBalanceValsDetCommand command)
        {
            command.Validate();

            var BdgBalanceValsDets = await _unitOfWork.BdgBalanceValsDetRepository.FindAsync(c => c.Id == command.Id);

            if (BdgBalanceValsDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgBalanceValsDet = Mapper.Map(command);
            await _unitOfWork.BdgBalanceValsDetRepository.AddAsync(newBdgBalanceValsDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgBalanceValsDetCommand command)
        {

            command.Validate();

            var BdgBalanceValsDet = await _unitOfWork.BdgBalanceValsDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgBalanceValsDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgBalanceValsDet = Mapper.Map(BdgBalanceValsDet, command);
            BdgBalanceValsDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgBalanceValsDet = await _unitOfWork.BdgBalanceValsDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgBalanceValsDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgBalanceValsDet.IsActive = false;
            BdgBalanceValsDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgBalanceValsDets = await _unitOfWork.BdgBalanceValsDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgBalanceValsDetsDto = Mapper.Map(BdgBalanceValsDets);

            return OkResult(CustomMessage.DefaultMessage, BdgBalanceValsDetsDto.ToPagingAndSorting(query), BdgBalanceValsDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgBalanceValsDet = await _unitOfWork.BdgBalanceValsDetRepository.GetByIdAsync(id);

            if (BdgBalanceValsDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgBalanceValsDetDto = Mapper.Map(BdgBalanceValsDet);

            return OkResult( CustomMessage.DefaultMessage , BdgBalanceValsDetDto);

        }
    }
}
