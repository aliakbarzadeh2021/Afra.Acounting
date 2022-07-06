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

namespace Afra.Api.Controllers.HrmParamStatAmntControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmParamStatAmntController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmParamStatAmntController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmParamStatAmntCommand command)
        {
            command.Validate();

            var HrmParamStatAmnts = await _unitOfWork.HrmParamStatAmntRepository.FindAsync(c => c.Id == command.Id);

            if (HrmParamStatAmnts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmParamStatAmnt = Mapper.Map(command);
            await _unitOfWork.HrmParamStatAmntRepository.AddAsync(newHrmParamStatAmnt);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmParamStatAmntCommand command)
        {

            command.Validate();

            var HrmParamStatAmnt = await _unitOfWork.HrmParamStatAmntRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmParamStatAmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmParamStatAmnt = Mapper.Map(HrmParamStatAmnt, command);
            HrmParamStatAmnt.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmParamStatAmnt = await _unitOfWork.HrmParamStatAmntRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmParamStatAmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmParamStatAmnt.IsActive = false;
            HrmParamStatAmnt.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmParamStatAmnts = await _unitOfWork.HrmParamStatAmntRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmParamStatAmntsDto = Mapper.Map(HrmParamStatAmnts);

            return OkResult(CustomMessage.DefaultMessage, HrmParamStatAmntsDto.ToPagingAndSorting(query), HrmParamStatAmntsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmParamStatAmnt = await _unitOfWork.HrmParamStatAmntRepository.GetByIdAsync(id);

            if (HrmParamStatAmnt is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmParamStatAmntDto = Mapper.Map(HrmParamStatAmnt);

            return OkResult( CustomMessage.DefaultMessage , HrmParamStatAmntDto);

        }
    }
}
