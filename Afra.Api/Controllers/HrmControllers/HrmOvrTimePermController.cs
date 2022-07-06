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

namespace Afra.Api.Controllers.HrmOvrTimePermControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmOvrTimePermController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmOvrTimePermController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmOvrTimePermCommand command)
        {
            command.Validate();

            var HrmOvrTimePerms = await _unitOfWork.HrmOvrTimePermRepository.FindAsync(c => c.Id == command.Id);

            if (HrmOvrTimePerms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmOvrTimePerm = Mapper.Map(command);
            await _unitOfWork.HrmOvrTimePermRepository.AddAsync(newHrmOvrTimePerm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmOvrTimePermCommand command)
        {

            command.Validate();

            var HrmOvrTimePerm = await _unitOfWork.HrmOvrTimePermRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmOvrTimePerm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmOvrTimePerm = Mapper.Map(HrmOvrTimePerm, command);
            HrmOvrTimePerm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmOvrTimePerm = await _unitOfWork.HrmOvrTimePermRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmOvrTimePerm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmOvrTimePerm.IsActive = false;
            HrmOvrTimePerm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmOvrTimePerms = await _unitOfWork.HrmOvrTimePermRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmOvrTimePermsDto = Mapper.Map(HrmOvrTimePerms);

            return OkResult(CustomMessage.DefaultMessage, HrmOvrTimePermsDto.ToPagingAndSorting(query), HrmOvrTimePermsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmOvrTimePerm = await _unitOfWork.HrmOvrTimePermRepository.GetByIdAsync(id);

            if (HrmOvrTimePerm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmOvrTimePermDto = Mapper.Map(HrmOvrTimePerm);

            return OkResult( CustomMessage.DefaultMessage , HrmOvrTimePermDto);

        }
    }
}
