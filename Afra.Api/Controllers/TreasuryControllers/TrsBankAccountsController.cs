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

namespace Afra.Api.Controllers.TrsBankAccountsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsBankAccountsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsBankAccountsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsBankAccountsCommand command)
        {
            command.Validate();

            var TrsBankAccountss = await _unitOfWork.TrsBankAccountsRepository.FindAsync(c => c.Id == command.Id);

            if (TrsBankAccountss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsBankAccounts = Mapper.Map(command);
            await _unitOfWork.TrsBankAccountsRepository.AddAsync(newTrsBankAccounts);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsBankAccountsCommand command)
        {

            command.Validate();

            var TrsBankAccounts = await _unitOfWork.TrsBankAccountsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsBankAccounts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankAccounts = Mapper.Map(TrsBankAccounts, command);
            TrsBankAccounts.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsBankAccounts = await _unitOfWork.TrsBankAccountsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsBankAccounts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankAccounts.IsActive = false;
            TrsBankAccounts.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsBankAccountss = await _unitOfWork.TrsBankAccountsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsBankAccountssDto = Mapper.Map(TrsBankAccountss);

            return OkResult(CustomMessage.DefaultMessage, TrsBankAccountssDto.ToPagingAndSorting(query), TrsBankAccountssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsBankAccounts = await _unitOfWork.TrsBankAccountsRepository.GetByIdAsync(id);

            if (TrsBankAccounts is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsBankAccountsDto = Mapper.Map(TrsBankAccounts);

            return OkResult( CustomMessage.DefaultMessage , TrsBankAccountsDto);

        }
    }
}
