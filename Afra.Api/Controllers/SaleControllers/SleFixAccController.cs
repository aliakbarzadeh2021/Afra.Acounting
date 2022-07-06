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

namespace Afra.Api.Controllers.SleFixAccControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleFixAccController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleFixAccController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleFixAccCommand command)
        {
            command.Validate();

            var SleFixAccs = await _unitOfWork.SleFixAccRepository.FindAsync(c => c.Id == command.Id);

            if (SleFixAccs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleFixAcc = Mapper.Map(command);
            await _unitOfWork.SleFixAccRepository.AddAsync(newSleFixAcc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleFixAccCommand command)
        {

            command.Validate();

            var SleFixAcc = await _unitOfWork.SleFixAccRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleFixAcc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleFixAcc = Mapper.Map(SleFixAcc, command);
            SleFixAcc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleFixAcc = await _unitOfWork.SleFixAccRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleFixAcc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleFixAcc.IsActive = false;
            SleFixAcc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleFixAccs = await _unitOfWork.SleFixAccRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleFixAccsDto = Mapper.Map(SleFixAccs);

            return OkResult(CustomMessage.DefaultMessage, SleFixAccsDto.ToPagingAndSorting(query), SleFixAccsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleFixAcc = await _unitOfWork.SleFixAccRepository.GetByIdAsync(id);

            if (SleFixAcc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleFixAccDto = Mapper.Map(SleFixAcc);

            return OkResult( CustomMessage.DefaultMessage , SleFixAccDto);

        }
    }
}
