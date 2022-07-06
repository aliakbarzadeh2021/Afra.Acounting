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

namespace Afra.Api.Controllers.GnrSysMsgDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrSysMsgDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrSysMsgDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrSysMsgDetCommand command)
        {
            command.Validate();

            var GnrSysMsgDets = await _unitOfWork.GnrSysMsgDetRepository.FindAsync(c => c.Id == command.Id);

            if (GnrSysMsgDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrSysMsgDet = Mapper.Map(command);
            await _unitOfWork.GnrSysMsgDetRepository.AddAsync(newGnrSysMsgDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrSysMsgDetCommand command)
        {

            command.Validate();

            var GnrSysMsgDet = await _unitOfWork.GnrSysMsgDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrSysMsgDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysMsgDet = Mapper.Map(GnrSysMsgDet, command);
            GnrSysMsgDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrSysMsgDet = await _unitOfWork.GnrSysMsgDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrSysMsgDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysMsgDet.IsActive = false;
            GnrSysMsgDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrSysMsgDets = await _unitOfWork.GnrSysMsgDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrSysMsgDetsDto = Mapper.Map(GnrSysMsgDets);

            return OkResult(CustomMessage.DefaultMessage, GnrSysMsgDetsDto.ToPagingAndSorting(query), GnrSysMsgDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrSysMsgDet = await _unitOfWork.GnrSysMsgDetRepository.GetByIdAsync(id);

            if (GnrSysMsgDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrSysMsgDetDto = Mapper.Map(GnrSysMsgDet);

            return OkResult( CustomMessage.DefaultMessage , GnrSysMsgDetDto);

        }
    }
}
