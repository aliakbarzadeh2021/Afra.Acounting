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

namespace Afra.Api.Controllers.HrmIncDecWorkControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmIncDecWorkController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmIncDecWorkController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmIncDecWorkCommand command)
        {
            command.Validate();

            var HrmIncDecWorks = await _unitOfWork.HrmIncDecWorkRepository.FindAsync(c => c.Id == command.Id);

            if (HrmIncDecWorks.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmIncDecWork = Mapper.Map(command);
            await _unitOfWork.HrmIncDecWorkRepository.AddAsync(newHrmIncDecWork);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmIncDecWorkCommand command)
        {

            command.Validate();

            var HrmIncDecWork = await _unitOfWork.HrmIncDecWorkRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmIncDecWork == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmIncDecWork = Mapper.Map(HrmIncDecWork, command);
            HrmIncDecWork.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmIncDecWork = await _unitOfWork.HrmIncDecWorkRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmIncDecWork == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmIncDecWork.IsActive = false;
            HrmIncDecWork.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmIncDecWorks = await _unitOfWork.HrmIncDecWorkRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmIncDecWorksDto = Mapper.Map(HrmIncDecWorks);

            return OkResult(CustomMessage.DefaultMessage, HrmIncDecWorksDto.ToPagingAndSorting(query), HrmIncDecWorksDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmIncDecWork = await _unitOfWork.HrmIncDecWorkRepository.GetByIdAsync(id);

            if (HrmIncDecWork is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmIncDecWorkDto = Mapper.Map(HrmIncDecWork);

            return OkResult( CustomMessage.DefaultMessage , HrmIncDecWorkDto);

        }
    }
}
