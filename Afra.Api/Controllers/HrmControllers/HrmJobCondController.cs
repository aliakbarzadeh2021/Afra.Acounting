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

namespace Afra.Api.Controllers.HrmJobCondControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmJobCondController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmJobCondController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmJobCondCommand command)
        {
            command.Validate();

            var HrmJobConds = await _unitOfWork.HrmJobCondRepository.FindAsync(c => c.Id == command.Id);

            if (HrmJobConds.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmJobCond = Mapper.Map(command);
            await _unitOfWork.HrmJobCondRepository.AddAsync(newHrmJobCond);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmJobCondCommand command)
        {

            command.Validate();

            var HrmJobCond = await _unitOfWork.HrmJobCondRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmJobCond == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmJobCond = Mapper.Map(HrmJobCond, command);
            HrmJobCond.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmJobCond = await _unitOfWork.HrmJobCondRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmJobCond == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmJobCond.IsActive = false;
            HrmJobCond.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmJobConds = await _unitOfWork.HrmJobCondRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmJobCondsDto = Mapper.Map(HrmJobConds);

            return OkResult(CustomMessage.DefaultMessage, HrmJobCondsDto.ToPagingAndSorting(query), HrmJobCondsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmJobCond = await _unitOfWork.HrmJobCondRepository.GetByIdAsync(id);

            if (HrmJobCond is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmJobCondDto = Mapper.Map(HrmJobCond);

            return OkResult( CustomMessage.DefaultMessage , HrmJobCondDto);

        }
    }
}
