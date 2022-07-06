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

namespace Afra.Api.Controllers.GnrUserMsgControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrUserMsgController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrUserMsgController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrUserMsgCommand command)
        {
            command.Validate();

            var GnrUserMsgs = await _unitOfWork.GnrUserMsgRepository.FindAsync(c => c.Id == command.Id);

            if (GnrUserMsgs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrUserMsg = Mapper.Map(command);
            await _unitOfWork.GnrUserMsgRepository.AddAsync(newGnrUserMsg);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrUserMsgCommand command)
        {

            command.Validate();

            var GnrUserMsg = await _unitOfWork.GnrUserMsgRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrUserMsg == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserMsg = Mapper.Map(GnrUserMsg, command);
            GnrUserMsg.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrUserMsg = await _unitOfWork.GnrUserMsgRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrUserMsg == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserMsg.IsActive = false;
            GnrUserMsg.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrUserMsgs = await _unitOfWork.GnrUserMsgRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrUserMsgsDto = Mapper.Map(GnrUserMsgs);

            return OkResult(CustomMessage.DefaultMessage, GnrUserMsgsDto.ToPagingAndSorting(query), GnrUserMsgsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrUserMsg = await _unitOfWork.GnrUserMsgRepository.GetByIdAsync(id);

            if (GnrUserMsg is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrUserMsgDto = Mapper.Map(GnrUserMsg);

            return OkResult( CustomMessage.DefaultMessage , GnrUserMsgDto);

        }
    }
}
