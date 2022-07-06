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

namespace Afra.Api.Controllers.OtoLttrLinksControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoLttrLinksController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoLttrLinksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoLttrLinksCommand command)
        {
            command.Validate();

            var OtoLttrLinkss = await _unitOfWork.OtoLttrLinksRepository.FindAsync(c => c.Id == command.Id);

            if (OtoLttrLinkss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoLttrLinks = Mapper.Map(command);
            await _unitOfWork.OtoLttrLinksRepository.AddAsync(newOtoLttrLinks);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoLttrLinksCommand command)
        {

            command.Validate();

            var OtoLttrLinks = await _unitOfWork.OtoLttrLinksRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoLttrLinks == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoLttrLinks = Mapper.Map(OtoLttrLinks, command);
            OtoLttrLinks.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoLttrLinks = await _unitOfWork.OtoLttrLinksRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoLttrLinks == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoLttrLinks.IsActive = false;
            OtoLttrLinks.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoLttrLinkss = await _unitOfWork.OtoLttrLinksRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoLttrLinkssDto = Mapper.Map(OtoLttrLinkss);

            return OkResult(CustomMessage.DefaultMessage, OtoLttrLinkssDto.ToPagingAndSorting(query), OtoLttrLinkssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoLttrLinks = await _unitOfWork.OtoLttrLinksRepository.GetByIdAsync(id);

            if (OtoLttrLinks is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoLttrLinksDto = Mapper.Map(OtoLttrLinks);

            return OkResult( CustomMessage.DefaultMessage , OtoLttrLinksDto);

        }
    }
}
