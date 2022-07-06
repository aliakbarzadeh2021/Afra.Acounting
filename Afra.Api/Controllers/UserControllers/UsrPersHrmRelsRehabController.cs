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

namespace Afra.Api.Controllers.UsrPersHrmRelsRehabControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrPersHrmRelsRehabController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrPersHrmRelsRehabController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrPersHrmRelsRehabCommand command)
        {
            command.Validate();

            var UsrPersHrmRelsRehabs = await _unitOfWork.UsrPersHrmRelsRehabRepository.FindAsync(c => c.Id == command.Id);

            if (UsrPersHrmRelsRehabs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrPersHrmRelsRehab = Mapper.Map(command);
            await _unitOfWork.UsrPersHrmRelsRehabRepository.AddAsync(newUsrPersHrmRelsRehab);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrPersHrmRelsRehabCommand command)
        {

            command.Validate();

            var UsrPersHrmRelsRehab = await _unitOfWork.UsrPersHrmRelsRehabRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrPersHrmRelsRehab == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrPersHrmRelsRehab = Mapper.Map(UsrPersHrmRelsRehab, command);
            UsrPersHrmRelsRehab.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrPersHrmRelsRehab = await _unitOfWork.UsrPersHrmRelsRehabRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrPersHrmRelsRehab == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrPersHrmRelsRehab.IsActive = false;
            UsrPersHrmRelsRehab.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrPersHrmRelsRehabs = await _unitOfWork.UsrPersHrmRelsRehabRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrPersHrmRelsRehabsDto = Mapper.Map(UsrPersHrmRelsRehabs);

            return OkResult(CustomMessage.DefaultMessage, UsrPersHrmRelsRehabsDto.ToPagingAndSorting(query), UsrPersHrmRelsRehabsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrPersHrmRelsRehab = await _unitOfWork.UsrPersHrmRelsRehabRepository.GetByIdAsync(id);

            if (UsrPersHrmRelsRehab is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrPersHrmRelsRehabDto = Mapper.Map(UsrPersHrmRelsRehab);

            return OkResult( CustomMessage.DefaultMessage , UsrPersHrmRelsRehabDto);

        }
    }
}
