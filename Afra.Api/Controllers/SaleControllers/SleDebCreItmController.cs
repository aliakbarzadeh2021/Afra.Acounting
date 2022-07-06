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

namespace Afra.Api.Controllers.SleDebCreItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleDebCreItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleDebCreItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleDebCreItmCommand command)
        {
            command.Validate();

            var SleDebCreItms = await _unitOfWork.SleDebCreItmRepository.FindAsync(c => c.Id == command.Id);

            if (SleDebCreItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleDebCreItm = Mapper.Map(command);
            await _unitOfWork.SleDebCreItmRepository.AddAsync(newSleDebCreItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleDebCreItmCommand command)
        {

            command.Validate();

            var SleDebCreItm = await _unitOfWork.SleDebCreItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleDebCreItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleDebCreItm = Mapper.Map(SleDebCreItm, command);
            SleDebCreItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleDebCreItm = await _unitOfWork.SleDebCreItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleDebCreItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleDebCreItm.IsActive = false;
            SleDebCreItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleDebCreItms = await _unitOfWork.SleDebCreItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleDebCreItmsDto = Mapper.Map(SleDebCreItms);

            return OkResult(CustomMessage.DefaultMessage, SleDebCreItmsDto.ToPagingAndSorting(query), SleDebCreItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleDebCreItm = await _unitOfWork.SleDebCreItmRepository.GetByIdAsync(id);

            if (SleDebCreItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleDebCreItmDto = Mapper.Map(SleDebCreItm);

            return OkResult( CustomMessage.DefaultMessage , SleDebCreItmDto);

        }
    }
}
