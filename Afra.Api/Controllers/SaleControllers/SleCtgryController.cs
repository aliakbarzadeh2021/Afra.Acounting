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

namespace Afra.Api.Controllers.SleCtgryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleCtgryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleCtgryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleCtgryCommand command)
        {
            command.Validate();

            var SleCtgrys = await _unitOfWork.SleCtgryRepository.FindAsync(c => c.Id == command.Id);

            if (SleCtgrys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleCtgry = Mapper.Map(command);
            await _unitOfWork.SleCtgryRepository.AddAsync(newSleCtgry);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleCtgryCommand command)
        {

            command.Validate();

            var SleCtgry = await _unitOfWork.SleCtgryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleCtgry == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleCtgry = Mapper.Map(SleCtgry, command);
            SleCtgry.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleCtgry = await _unitOfWork.SleCtgryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleCtgry == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleCtgry.IsActive = false;
            SleCtgry.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleCtgrys = await _unitOfWork.SleCtgryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleCtgrysDto = Mapper.Map(SleCtgrys);

            return OkResult(CustomMessage.DefaultMessage, SleCtgrysDto.ToPagingAndSorting(query), SleCtgrysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleCtgry = await _unitOfWork.SleCtgryRepository.GetByIdAsync(id);

            if (SleCtgry is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleCtgryDto = Mapper.Map(SleCtgry);

            return OkResult( CustomMessage.DefaultMessage , SleCtgryDto);

        }
    }
}
