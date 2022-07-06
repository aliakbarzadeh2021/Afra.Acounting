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

namespace Afra.Api.Controllers.WebLoginsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class WebLoginsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public WebLoginsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddWebLoginsCommand command)
        {
            command.Validate();

            var WebLoginss = await _unitOfWork.WebLoginsRepository.FindAsync(c => c.Id == command.Id);

            if (WebLoginss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newWebLogins = Mapper.Map(command);
            await _unitOfWork.WebLoginsRepository.AddAsync(newWebLogins);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditWebLoginsCommand command)
        {

            command.Validate();

            var WebLogins = await _unitOfWork.WebLoginsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (WebLogins == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WebLogins = Mapper.Map(WebLogins, command);
            WebLogins.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var WebLogins = await _unitOfWork.WebLoginsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (WebLogins == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WebLogins.IsActive = false;
            WebLogins.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var WebLoginss = await _unitOfWork.WebLoginsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var WebLoginssDto = Mapper.Map(WebLoginss);

            return OkResult(CustomMessage.DefaultMessage, WebLoginssDto.ToPagingAndSorting(query), WebLoginssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var WebLogins = await _unitOfWork.WebLoginsRepository.GetByIdAsync(id);

            if (WebLogins is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var WebLoginsDto = Mapper.Map(WebLogins);

            return OkResult( CustomMessage.DefaultMessage , WebLoginsDto);

        }
    }
}
