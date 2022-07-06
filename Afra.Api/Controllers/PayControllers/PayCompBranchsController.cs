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

namespace Afra.Api.Controllers.PayCompBranchsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayCompBranchsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayCompBranchsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayCompBranchsCommand command)
        {
            command.Validate();

            var PayCompBranchss = await _unitOfWork.PayCompBranchsRepository.FindAsync(c => c.Id == command.Id);

            if (PayCompBranchss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayCompBranchs = Mapper.Map(command);
            await _unitOfWork.PayCompBranchsRepository.AddAsync(newPayCompBranchs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayCompBranchsCommand command)
        {

            command.Validate();

            var PayCompBranchs = await _unitOfWork.PayCompBranchsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayCompBranchs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayCompBranchs = Mapper.Map(PayCompBranchs, command);
            PayCompBranchs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayCompBranchs = await _unitOfWork.PayCompBranchsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayCompBranchs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayCompBranchs.IsActive = false;
            PayCompBranchs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayCompBranchss = await _unitOfWork.PayCompBranchsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayCompBranchssDto = Mapper.Map(PayCompBranchss);

            return OkResult(CustomMessage.DefaultMessage, PayCompBranchssDto.ToPagingAndSorting(query), PayCompBranchssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayCompBranchs = await _unitOfWork.PayCompBranchsRepository.GetByIdAsync(id);

            if (PayCompBranchs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayCompBranchsDto = Mapper.Map(PayCompBranchs);

            return OkResult( CustomMessage.DefaultMessage , PayCompBranchsDto);

        }
    }
}
