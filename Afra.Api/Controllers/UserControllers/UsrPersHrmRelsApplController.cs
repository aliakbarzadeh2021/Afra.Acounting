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

namespace Afra.Api.Controllers.UsrPersHrmRelsApplControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrPersHrmRelsApplController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrPersHrmRelsApplController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrPersHrmRelsApplCommand command)
        {
            command.Validate();

            var UsrPersHrmRelsAppls = await _unitOfWork.UsrPersHrmRelsApplRepository.FindAsync(c => c.Id == command.Id);

            if (UsrPersHrmRelsAppls.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrPersHrmRelsAppl = Mapper.Map(command);
            await _unitOfWork.UsrPersHrmRelsApplRepository.AddAsync(newUsrPersHrmRelsAppl);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrPersHrmRelsApplCommand command)
        {

            command.Validate();

            var UsrPersHrmRelsAppl = await _unitOfWork.UsrPersHrmRelsApplRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrPersHrmRelsAppl == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrPersHrmRelsAppl = Mapper.Map(UsrPersHrmRelsAppl, command);
            UsrPersHrmRelsAppl.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrPersHrmRelsAppl = await _unitOfWork.UsrPersHrmRelsApplRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrPersHrmRelsAppl == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrPersHrmRelsAppl.IsActive = false;
            UsrPersHrmRelsAppl.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrPersHrmRelsAppls = await _unitOfWork.UsrPersHrmRelsApplRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrPersHrmRelsApplsDto = Mapper.Map(UsrPersHrmRelsAppls);

            return OkResult(CustomMessage.DefaultMessage, UsrPersHrmRelsApplsDto.ToPagingAndSorting(query), UsrPersHrmRelsApplsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrPersHrmRelsAppl = await _unitOfWork.UsrPersHrmRelsApplRepository.GetByIdAsync(id);

            if (UsrPersHrmRelsAppl is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrPersHrmRelsApplDto = Mapper.Map(UsrPersHrmRelsAppl);

            return OkResult( CustomMessage.DefaultMessage , UsrPersHrmRelsApplDto);

        }
    }
}
