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

namespace Afra.Api.Controllers.PayTaxTableControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayTaxTableController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayTaxTableController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayTaxTableCommand command)
        {
            command.Validate();

            var PayTaxTables = await _unitOfWork.PayTaxTableRepository.FindAsync(c => c.Id == command.Id);

            if (PayTaxTables.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayTaxTable = Mapper.Map(command);
            await _unitOfWork.PayTaxTableRepository.AddAsync(newPayTaxTable);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayTaxTableCommand command)
        {

            command.Validate();

            var PayTaxTable = await _unitOfWork.PayTaxTableRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayTaxTable == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayTaxTable = Mapper.Map(PayTaxTable, command);
            PayTaxTable.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayTaxTable = await _unitOfWork.PayTaxTableRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayTaxTable == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayTaxTable.IsActive = false;
            PayTaxTable.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayTaxTables = await _unitOfWork.PayTaxTableRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayTaxTablesDto = Mapper.Map(PayTaxTables);

            return OkResult(CustomMessage.DefaultMessage, PayTaxTablesDto.ToPagingAndSorting(query), PayTaxTablesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayTaxTable = await _unitOfWork.PayTaxTableRepository.GetByIdAsync(id);

            if (PayTaxTable is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayTaxTableDto = Mapper.Map(PayTaxTable);

            return OkResult( CustomMessage.DefaultMessage , PayTaxTableDto);

        }
    }
}
