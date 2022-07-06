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

namespace Afra.Api.Controllers.SleGuaDocsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleGuaDocsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleGuaDocsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleGuaDocsCommand command)
        {
            command.Validate();

            var SleGuaDocss = await _unitOfWork.SleGuaDocsRepository.FindAsync(c => c.Id == command.Id);

            if (SleGuaDocss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleGuaDocs = Mapper.Map(command);
            await _unitOfWork.SleGuaDocsRepository.AddAsync(newSleGuaDocs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleGuaDocsCommand command)
        {

            command.Validate();

            var SleGuaDocs = await _unitOfWork.SleGuaDocsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleGuaDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleGuaDocs = Mapper.Map(SleGuaDocs, command);
            SleGuaDocs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleGuaDocs = await _unitOfWork.SleGuaDocsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleGuaDocs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleGuaDocs.IsActive = false;
            SleGuaDocs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleGuaDocss = await _unitOfWork.SleGuaDocsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleGuaDocssDto = Mapper.Map(SleGuaDocss);

            return OkResult(CustomMessage.DefaultMessage, SleGuaDocssDto.ToPagingAndSorting(query), SleGuaDocssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleGuaDocs = await _unitOfWork.SleGuaDocsRepository.GetByIdAsync(id);

            if (SleGuaDocs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleGuaDocsDto = Mapper.Map(SleGuaDocs);

            return OkResult( CustomMessage.DefaultMessage , SleGuaDocsDto);

        }
    }
}
