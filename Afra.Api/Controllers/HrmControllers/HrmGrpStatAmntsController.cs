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

namespace Afra.Api.Controllers.HrmGrpStatAmntsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmGrpStatAmntsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmGrpStatAmntsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmGrpStatAmntsCommand command)
        {
            command.Validate();

            var HrmGrpStatAmntss = await _unitOfWork.HrmGrpStatAmntsRepository.FindAsync(c => c.Id == command.Id);

            if (HrmGrpStatAmntss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmGrpStatAmnts = Mapper.Map(command);
            await _unitOfWork.HrmGrpStatAmntsRepository.AddAsync(newHrmGrpStatAmnts);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmGrpStatAmntsCommand command)
        {

            command.Validate();

            var HrmGrpStatAmnts = await _unitOfWork.HrmGrpStatAmntsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmGrpStatAmnts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmGrpStatAmnts = Mapper.Map(HrmGrpStatAmnts, command);
            HrmGrpStatAmnts.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmGrpStatAmnts = await _unitOfWork.HrmGrpStatAmntsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmGrpStatAmnts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmGrpStatAmnts.IsActive = false;
            HrmGrpStatAmnts.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmGrpStatAmntss = await _unitOfWork.HrmGrpStatAmntsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmGrpStatAmntssDto = Mapper.Map(HrmGrpStatAmntss);

            return OkResult(CustomMessage.DefaultMessage, HrmGrpStatAmntssDto.ToPagingAndSorting(query), HrmGrpStatAmntssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmGrpStatAmnts = await _unitOfWork.HrmGrpStatAmntsRepository.GetByIdAsync(id);

            if (HrmGrpStatAmnts is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmGrpStatAmntsDto = Mapper.Map(HrmGrpStatAmnts);

            return OkResult( CustomMessage.DefaultMessage , HrmGrpStatAmntsDto);

        }
    }
}
