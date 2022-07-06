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

namespace Afra.Api.Controllers.GnrSysMsgControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrSysMsgController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrSysMsgController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrSysMsgCommand command)
        {
            command.Validate();

            var GnrSysMsgs = await _unitOfWork.GnrSysMsgRepository.FindAsync(c => c.Id == command.Id);

            if (GnrSysMsgs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrSysMsg = Mapper.Map(command);
            await _unitOfWork.GnrSysMsgRepository.AddAsync(newGnrSysMsg);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrSysMsgCommand command)
        {

            command.Validate();

            var GnrSysMsg = await _unitOfWork.GnrSysMsgRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrSysMsg == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysMsg = Mapper.Map(GnrSysMsg, command);
            GnrSysMsg.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrSysMsg = await _unitOfWork.GnrSysMsgRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrSysMsg == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysMsg.IsActive = false;
            GnrSysMsg.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrSysMsgs = await _unitOfWork.GnrSysMsgRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrSysMsgsDto = Mapper.Map(GnrSysMsgs);

            return OkResult(CustomMessage.DefaultMessage, GnrSysMsgsDto.ToPagingAndSorting(query), GnrSysMsgsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrSysMsg = await _unitOfWork.GnrSysMsgRepository.GetByIdAsync(id);

            if (GnrSysMsg is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrSysMsgDto = Mapper.Map(GnrSysMsg);

            return OkResult( CustomMessage.DefaultMessage , GnrSysMsgDto);

        }
    }
}
