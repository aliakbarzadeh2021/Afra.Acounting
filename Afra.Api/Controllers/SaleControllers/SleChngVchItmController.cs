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

namespace Afra.Api.Controllers.SleChngVchItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleChngVchItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleChngVchItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleChngVchItmCommand command)
        {
            command.Validate();

            var SleChngVchItms = await _unitOfWork.SleChngVchItmRepository.FindAsync(c => c.Id == command.Id);

            if (SleChngVchItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleChngVchItm = Mapper.Map(command);
            await _unitOfWork.SleChngVchItmRepository.AddAsync(newSleChngVchItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleChngVchItmCommand command)
        {

            command.Validate();

            var SleChngVchItm = await _unitOfWork.SleChngVchItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleChngVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleChngVchItm = Mapper.Map(SleChngVchItm, command);
            SleChngVchItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleChngVchItm = await _unitOfWork.SleChngVchItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleChngVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleChngVchItm.IsActive = false;
            SleChngVchItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleChngVchItms = await _unitOfWork.SleChngVchItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleChngVchItmsDto = Mapper.Map(SleChngVchItms);

            return OkResult(CustomMessage.DefaultMessage, SleChngVchItmsDto.ToPagingAndSorting(query), SleChngVchItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleChngVchItm = await _unitOfWork.SleChngVchItmRepository.GetByIdAsync(id);

            if (SleChngVchItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleChngVchItmDto = Mapper.Map(SleChngVchItm);

            return OkResult( CustomMessage.DefaultMessage , SleChngVchItmDto);

        }
    }
}
