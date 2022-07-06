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

namespace Afra.Api.Controllers.OtoTemplatesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoTemplatesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoTemplatesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoTemplatesCommand command)
        {
            command.Validate();

            var OtoTemplatess = await _unitOfWork.OtoTemplatesRepository.FindAsync(c => c.Id == command.Id);

            if (OtoTemplatess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoTemplates = Mapper.Map(command);
            await _unitOfWork.OtoTemplatesRepository.AddAsync(newOtoTemplates);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoTemplatesCommand command)
        {

            command.Validate();

            var OtoTemplates = await _unitOfWork.OtoTemplatesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoTemplates == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoTemplates = Mapper.Map(OtoTemplates, command);
            OtoTemplates.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoTemplates = await _unitOfWork.OtoTemplatesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoTemplates == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoTemplates.IsActive = false;
            OtoTemplates.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoTemplatess = await _unitOfWork.OtoTemplatesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoTemplatessDto = Mapper.Map(OtoTemplatess);

            return OkResult(CustomMessage.DefaultMessage, OtoTemplatessDto.ToPagingAndSorting(query), OtoTemplatessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoTemplates = await _unitOfWork.OtoTemplatesRepository.GetByIdAsync(id);

            if (OtoTemplates is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoTemplatesDto = Mapper.Map(OtoTemplates);

            return OkResult( CustomMessage.DefaultMessage , OtoTemplatesDto);

        }
    }
}
