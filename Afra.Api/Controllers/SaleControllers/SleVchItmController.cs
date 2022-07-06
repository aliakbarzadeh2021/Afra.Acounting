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

namespace Afra.Api.Controllers.SleVchItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleVchItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleVchItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleVchItmCommand command)
        {
            command.Validate();

            var SleVchItms = await _unitOfWork.SleVchItmRepository.FindAsync(c => c.Id == command.Id);

            if (SleVchItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleVchItm = Mapper.Map(command);
            await _unitOfWork.SleVchItmRepository.AddAsync(newSleVchItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleVchItmCommand command)
        {

            command.Validate();

            var SleVchItm = await _unitOfWork.SleVchItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleVchItm = Mapper.Map(SleVchItm, command);
            SleVchItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleVchItm = await _unitOfWork.SleVchItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleVchItm.IsActive = false;
            SleVchItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleVchItms = await _unitOfWork.SleVchItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleVchItmsDto = Mapper.Map(SleVchItms);

            return OkResult(CustomMessage.DefaultMessage, SleVchItmsDto.ToPagingAndSorting(query), SleVchItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleVchItm = await _unitOfWork.SleVchItmRepository.GetByIdAsync(id);

            if (SleVchItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleVchItmDto = Mapper.Map(SleVchItm);

            return OkResult( CustomMessage.DefaultMessage , SleVchItmDto);

        }
    }
}
