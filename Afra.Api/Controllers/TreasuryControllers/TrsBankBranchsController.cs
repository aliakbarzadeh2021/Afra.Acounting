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

namespace Afra.Api.Controllers.TrsBankBranchsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsBankBranchsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsBankBranchsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsBankBranchsCommand command)
        {
            command.Validate();

            var TrsBankBranchss = await _unitOfWork.TrsBankBranchsRepository.FindAsync(c => c.Id == command.Id);

            if (TrsBankBranchss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsBankBranchs = Mapper.Map(command);
            await _unitOfWork.TrsBankBranchsRepository.AddAsync(newTrsBankBranchs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsBankBranchsCommand command)
        {

            command.Validate();

            var TrsBankBranchs = await _unitOfWork.TrsBankBranchsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsBankBranchs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankBranchs = Mapper.Map(TrsBankBranchs, command);
            TrsBankBranchs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsBankBranchs = await _unitOfWork.TrsBankBranchsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsBankBranchs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankBranchs.IsActive = false;
            TrsBankBranchs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsBankBranchss = await _unitOfWork.TrsBankBranchsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsBankBranchssDto = Mapper.Map(TrsBankBranchss);

            return OkResult(CustomMessage.DefaultMessage, TrsBankBranchssDto.ToPagingAndSorting(query), TrsBankBranchssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsBankBranchs = await _unitOfWork.TrsBankBranchsRepository.GetByIdAsync(id);

            if (TrsBankBranchs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsBankBranchsDto = Mapper.Map(TrsBankBranchs);

            return OkResult( CustomMessage.DefaultMessage , TrsBankBranchsDto);

        }
    }
}
