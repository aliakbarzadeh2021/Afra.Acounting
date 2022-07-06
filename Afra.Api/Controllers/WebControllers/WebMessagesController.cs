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

namespace Afra.Api.Controllers.WebMessagesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class WebMessagesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public WebMessagesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddWebMessagesCommand command)
        {
            command.Validate();

            var WebMessagess = await _unitOfWork.WebMessagesRepository.FindAsync(c => c.Id == command.Id);

            if (WebMessagess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newWebMessages = Mapper.Map(command);
            await _unitOfWork.WebMessagesRepository.AddAsync(newWebMessages);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditWebMessagesCommand command)
        {

            command.Validate();

            var WebMessages = await _unitOfWork.WebMessagesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (WebMessages == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WebMessages = Mapper.Map(WebMessages, command);
            WebMessages.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var WebMessages = await _unitOfWork.WebMessagesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (WebMessages == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WebMessages.IsActive = false;
            WebMessages.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var WebMessagess = await _unitOfWork.WebMessagesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var WebMessagessDto = Mapper.Map(WebMessagess);

            return OkResult(CustomMessage.DefaultMessage, WebMessagessDto.ToPagingAndSorting(query), WebMessagessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var WebMessages = await _unitOfWork.WebMessagesRepository.GetByIdAsync(id);

            if (WebMessages is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var WebMessagesDto = Mapper.Map(WebMessages);

            return OkResult( CustomMessage.DefaultMessage , WebMessagesDto);

        }
    }
}
