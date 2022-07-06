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

namespace Afra.Api.Controllers.TrsBankBillControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsBankBillController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsBankBillController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsBankBillCommand command)
        {
            command.Validate();

            var TrsBankBills = await _unitOfWork.TrsBankBillRepository.FindAsync(c => c.Id == command.Id);

            if (TrsBankBills.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsBankBill = Mapper.Map(command);
            await _unitOfWork.TrsBankBillRepository.AddAsync(newTrsBankBill);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsBankBillCommand command)
        {

            command.Validate();

            var TrsBankBill = await _unitOfWork.TrsBankBillRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsBankBill == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankBill = Mapper.Map(TrsBankBill, command);
            TrsBankBill.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsBankBill = await _unitOfWork.TrsBankBillRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsBankBill == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankBill.IsActive = false;
            TrsBankBill.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsBankBills = await _unitOfWork.TrsBankBillRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsBankBillsDto = Mapper.Map(TrsBankBills);

            return OkResult(CustomMessage.DefaultMessage, TrsBankBillsDto.ToPagingAndSorting(query), TrsBankBillsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsBankBill = await _unitOfWork.TrsBankBillRepository.GetByIdAsync(id);

            if (TrsBankBill is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsBankBillDto = Mapper.Map(TrsBankBill);

            return OkResult( CustomMessage.DefaultMessage , TrsBankBillDto);

        }
    }
}
