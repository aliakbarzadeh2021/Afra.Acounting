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

namespace Afra.Api.Controllers.HrmPersAccountControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmPersAccountController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmPersAccountController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmPersAccountCommand command)
        {
            command.Validate();

            var HrmPersAccounts = await _unitOfWork.HrmPersAccountRepository.FindAsync(c => c.Id == command.Id);

            if (HrmPersAccounts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmPersAccount = Mapper.Map(command);
            await _unitOfWork.HrmPersAccountRepository.AddAsync(newHrmPersAccount);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmPersAccountCommand command)
        {

            command.Validate();

            var HrmPersAccount = await _unitOfWork.HrmPersAccountRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmPersAccount == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersAccount = Mapper.Map(HrmPersAccount, command);
            HrmPersAccount.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmPersAccount = await _unitOfWork.HrmPersAccountRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmPersAccount == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersAccount.IsActive = false;
            HrmPersAccount.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmPersAccounts = await _unitOfWork.HrmPersAccountRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmPersAccountsDto = Mapper.Map(HrmPersAccounts);

            return OkResult(CustomMessage.DefaultMessage, HrmPersAccountsDto.ToPagingAndSorting(query), HrmPersAccountsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmPersAccount = await _unitOfWork.HrmPersAccountRepository.GetByIdAsync(id);

            if (HrmPersAccount is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmPersAccountDto = Mapper.Map(HrmPersAccount);

            return OkResult( CustomMessage.DefaultMessage , HrmPersAccountDto);

        }
    }
}
