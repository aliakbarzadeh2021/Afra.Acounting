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

namespace Afra.Api.Controllers.TrsBankBillDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsBankBillDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsBankBillDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsBankBillDetCommand command)
        {
            command.Validate();

            var TrsBankBillDets = await _unitOfWork.TrsBankBillDetRepository.FindAsync(c => c.Id == command.Id);

            if (TrsBankBillDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsBankBillDet = Mapper.Map(command);
            await _unitOfWork.TrsBankBillDetRepository.AddAsync(newTrsBankBillDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsBankBillDetCommand command)
        {

            command.Validate();

            var TrsBankBillDet = await _unitOfWork.TrsBankBillDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsBankBillDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankBillDet = Mapper.Map(TrsBankBillDet, command);
            TrsBankBillDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsBankBillDet = await _unitOfWork.TrsBankBillDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsBankBillDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankBillDet.IsActive = false;
            TrsBankBillDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsBankBillDets = await _unitOfWork.TrsBankBillDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsBankBillDetsDto = Mapper.Map(TrsBankBillDets);

            return OkResult(CustomMessage.DefaultMessage, TrsBankBillDetsDto.ToPagingAndSorting(query), TrsBankBillDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsBankBillDet = await _unitOfWork.TrsBankBillDetRepository.GetByIdAsync(id);

            if (TrsBankBillDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsBankBillDetDto = Mapper.Map(TrsBankBillDet);

            return OkResult( CustomMessage.DefaultMessage , TrsBankBillDetDto);

        }
    }
}
