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

namespace Afra.Api.Controllers.OtoTransScriptControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoTransScriptController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoTransScriptController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoTransScriptCommand command)
        {
            command.Validate();

            var OtoTransScripts = await _unitOfWork.OtoTransScriptRepository.FindAsync(c => c.Id == command.Id);

            if (OtoTransScripts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoTransScript = Mapper.Map(command);
            await _unitOfWork.OtoTransScriptRepository.AddAsync(newOtoTransScript);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoTransScriptCommand command)
        {

            command.Validate();

            var OtoTransScript = await _unitOfWork.OtoTransScriptRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoTransScript == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoTransScript = Mapper.Map(OtoTransScript, command);
            OtoTransScript.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoTransScript = await _unitOfWork.OtoTransScriptRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoTransScript == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoTransScript.IsActive = false;
            OtoTransScript.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoTransScripts = await _unitOfWork.OtoTransScriptRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoTransScriptsDto = Mapper.Map(OtoTransScripts);

            return OkResult(CustomMessage.DefaultMessage, OtoTransScriptsDto.ToPagingAndSorting(query), OtoTransScriptsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoTransScript = await _unitOfWork.OtoTransScriptRepository.GetByIdAsync(id);

            if (OtoTransScript is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoTransScriptDto = Mapper.Map(OtoTransScript);

            return OkResult( CustomMessage.DefaultMessage , OtoTransScriptDto);

        }
    }
}
