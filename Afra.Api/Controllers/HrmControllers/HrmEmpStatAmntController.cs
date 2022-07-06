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

namespace Afra.Api.Controllers.HrmEmpStatAmntControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmEmpStatAmntController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmEmpStatAmntController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmEmpStatAmntCommand command)
        {
            command.Validate();

            var HrmEmpStatAmnts = await _unitOfWork.HrmEmpStatAmntRepository.FindAsync(c => c.Id == command.Id);

            if (HrmEmpStatAmnts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmEmpStatAmnt = Mapper.Map(command);
            await _unitOfWork.HrmEmpStatAmntRepository.AddAsync(newHrmEmpStatAmnt);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmEmpStatAmntCommand command)
        {

            command.Validate();

            var HrmEmpStatAmnt = await _unitOfWork.HrmEmpStatAmntRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmEmpStatAmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmEmpStatAmnt = Mapper.Map(HrmEmpStatAmnt, command);
            HrmEmpStatAmnt.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmEmpStatAmnt = await _unitOfWork.HrmEmpStatAmntRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmEmpStatAmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmEmpStatAmnt.IsActive = false;
            HrmEmpStatAmnt.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmEmpStatAmnts = await _unitOfWork.HrmEmpStatAmntRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmEmpStatAmntsDto = Mapper.Map(HrmEmpStatAmnts);

            return OkResult(CustomMessage.DefaultMessage, HrmEmpStatAmntsDto.ToPagingAndSorting(query), HrmEmpStatAmntsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmEmpStatAmnt = await _unitOfWork.HrmEmpStatAmntRepository.GetByIdAsync(id);

            if (HrmEmpStatAmnt is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmEmpStatAmntDto = Mapper.Map(HrmEmpStatAmnt);

            return OkResult( CustomMessage.DefaultMessage , HrmEmpStatAmntDto);

        }
    }
}
