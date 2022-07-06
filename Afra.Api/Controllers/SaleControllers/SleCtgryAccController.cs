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

namespace Afra.Api.Controllers.SleCtgryAccControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleCtgryAccController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleCtgryAccController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleCtgryAccCommand command)
        {
            command.Validate();

            var SleCtgryAccs = await _unitOfWork.SleCtgryAccRepository.FindAsync(c => c.Id == command.Id);

            if (SleCtgryAccs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleCtgryAcc = Mapper.Map(command);
            await _unitOfWork.SleCtgryAccRepository.AddAsync(newSleCtgryAcc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleCtgryAccCommand command)
        {

            command.Validate();

            var SleCtgryAcc = await _unitOfWork.SleCtgryAccRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleCtgryAcc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleCtgryAcc = Mapper.Map(SleCtgryAcc, command);
            SleCtgryAcc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleCtgryAcc = await _unitOfWork.SleCtgryAccRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleCtgryAcc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleCtgryAcc.IsActive = false;
            SleCtgryAcc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleCtgryAccs = await _unitOfWork.SleCtgryAccRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleCtgryAccsDto = Mapper.Map(SleCtgryAccs);

            return OkResult(CustomMessage.DefaultMessage, SleCtgryAccsDto.ToPagingAndSorting(query), SleCtgryAccsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleCtgryAcc = await _unitOfWork.SleCtgryAccRepository.GetByIdAsync(id);

            if (SleCtgryAcc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleCtgryAccDto = Mapper.Map(SleCtgryAcc);

            return OkResult( CustomMessage.DefaultMessage , SleCtgryAccDto);

        }
    }
}
