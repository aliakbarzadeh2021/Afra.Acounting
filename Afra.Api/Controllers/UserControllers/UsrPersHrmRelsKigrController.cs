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

namespace Afra.Api.Controllers.UsrPersHrmRelsKigrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrPersHrmRelsKigrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrPersHrmRelsKigrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrPersHrmRelsKigrCommand command)
        {
            command.Validate();

            var UsrPersHrmRelsKigrs = await _unitOfWork.UsrPersHrmRelsKigrRepository.FindAsync(c => c.Id == command.Id);

            if (UsrPersHrmRelsKigrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrPersHrmRelsKigr = Mapper.Map(command);
            await _unitOfWork.UsrPersHrmRelsKigrRepository.AddAsync(newUsrPersHrmRelsKigr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrPersHrmRelsKigrCommand command)
        {

            command.Validate();

            var UsrPersHrmRelsKigr = await _unitOfWork.UsrPersHrmRelsKigrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrPersHrmRelsKigr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrPersHrmRelsKigr = Mapper.Map(UsrPersHrmRelsKigr, command);
            UsrPersHrmRelsKigr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrPersHrmRelsKigr = await _unitOfWork.UsrPersHrmRelsKigrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrPersHrmRelsKigr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrPersHrmRelsKigr.IsActive = false;
            UsrPersHrmRelsKigr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrPersHrmRelsKigrs = await _unitOfWork.UsrPersHrmRelsKigrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrPersHrmRelsKigrsDto = Mapper.Map(UsrPersHrmRelsKigrs);

            return OkResult(CustomMessage.DefaultMessage, UsrPersHrmRelsKigrsDto.ToPagingAndSorting(query), UsrPersHrmRelsKigrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrPersHrmRelsKigr = await _unitOfWork.UsrPersHrmRelsKigrRepository.GetByIdAsync(id);

            if (UsrPersHrmRelsKigr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrPersHrmRelsKigrDto = Mapper.Map(UsrPersHrmRelsKigr);

            return OkResult( CustomMessage.DefaultMessage , UsrPersHrmRelsKigrDto);

        }
    }
}
