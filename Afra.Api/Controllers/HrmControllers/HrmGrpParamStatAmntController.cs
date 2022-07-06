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

namespace Afra.Api.Controllers.HrmGrpParamStatAmntControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmGrpParamStatAmntController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmGrpParamStatAmntController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmGrpParamStatAmntCommand command)
        {
            command.Validate();

            var HrmGrpParamStatAmnts = await _unitOfWork.HrmGrpParamStatAmntRepository.FindAsync(c => c.Id == command.Id);

            if (HrmGrpParamStatAmnts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmGrpParamStatAmnt = Mapper.Map(command);
            await _unitOfWork.HrmGrpParamStatAmntRepository.AddAsync(newHrmGrpParamStatAmnt);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmGrpParamStatAmntCommand command)
        {

            command.Validate();

            var HrmGrpParamStatAmnt = await _unitOfWork.HrmGrpParamStatAmntRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmGrpParamStatAmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmGrpParamStatAmnt = Mapper.Map(HrmGrpParamStatAmnt, command);
            HrmGrpParamStatAmnt.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmGrpParamStatAmnt = await _unitOfWork.HrmGrpParamStatAmntRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmGrpParamStatAmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmGrpParamStatAmnt.IsActive = false;
            HrmGrpParamStatAmnt.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmGrpParamStatAmnts = await _unitOfWork.HrmGrpParamStatAmntRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmGrpParamStatAmntsDto = Mapper.Map(HrmGrpParamStatAmnts);

            return OkResult(CustomMessage.DefaultMessage, HrmGrpParamStatAmntsDto.ToPagingAndSorting(query), HrmGrpParamStatAmntsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmGrpParamStatAmnt = await _unitOfWork.HrmGrpParamStatAmntRepository.GetByIdAsync(id);

            if (HrmGrpParamStatAmnt is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmGrpParamStatAmntDto = Mapper.Map(HrmGrpParamStatAmnt);

            return OkResult( CustomMessage.DefaultMessage , HrmGrpParamStatAmntDto);

        }
    }
}
