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

namespace Afra.Api.Controllers.BdgBalanceValControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgBalanceValController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgBalanceValController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgBalanceValCommand command)
        {
            command.Validate();

            var BdgBalanceVals = await _unitOfWork.BdgBalanceValRepository.FindAsync(c => c.Id == command.Id);

            if (BdgBalanceVals.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgBalanceVal = Mapper.Map(command);
            await _unitOfWork.BdgBalanceValRepository.AddAsync(newBdgBalanceVal);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgBalanceValCommand command)
        {

            command.Validate();

            var BdgBalanceVal = await _unitOfWork.BdgBalanceValRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgBalanceVal == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgBalanceVal = Mapper.Map(BdgBalanceVal, command);
            BdgBalanceVal.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgBalanceVal = await _unitOfWork.BdgBalanceValRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgBalanceVal == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgBalanceVal.IsActive = false;
            BdgBalanceVal.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgBalanceVals = await _unitOfWork.BdgBalanceValRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgBalanceValsDto = Mapper.Map(BdgBalanceVals);

            return OkResult(CustomMessage.DefaultMessage, BdgBalanceValsDto.ToPagingAndSorting(query), BdgBalanceValsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgBalanceVal = await _unitOfWork.BdgBalanceValRepository.GetByIdAsync(id);

            if (BdgBalanceVal is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgBalanceValDto = Mapper.Map(BdgBalanceVal);

            return OkResult( CustomMessage.DefaultMessage , BdgBalanceValDto);

        }
    }
}
