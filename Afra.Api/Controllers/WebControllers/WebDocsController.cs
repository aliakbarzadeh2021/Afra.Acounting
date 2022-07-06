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

namespace Afra.Api.Controllers.WebDocsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class WebDocsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public WebDocsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddWebDocsCommand command)
        {
            command.Validate();

            var WebDocss = await _unitOfWork.WebDocsRepository.FindAsync(c => c.Id == command.Id);

            if (WebDocss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newWebDocs = Mapper.Map(command);
            await _unitOfWork.WebDocsRepository.AddAsync(newWebDocs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditWebDocsCommand command)
        {

            command.Validate();

            var WebDocs = await _unitOfWork.WebDocsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (WebDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WebDocs = Mapper.Map(WebDocs, command);
            WebDocs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var WebDocs = await _unitOfWork.WebDocsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (WebDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WebDocs.IsActive = false;
            WebDocs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var WebDocss = await _unitOfWork.WebDocsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var WebDocssDto = Mapper.Map(WebDocss);

            return OkResult(CustomMessage.DefaultMessage, WebDocssDto.ToPagingAndSorting(query), WebDocssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var WebDocs = await _unitOfWork.WebDocsRepository.GetByIdAsync(id);

            if (WebDocs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var WebDocsDto = Mapper.Map(WebDocs);

            return OkResult( CustomMessage.DefaultMessage , WebDocsDto);

        }
    }
}
