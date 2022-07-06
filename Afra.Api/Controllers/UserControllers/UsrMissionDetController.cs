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

namespace Afra.Api.Controllers.UsrMissionDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrMissionDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrMissionDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrMissionDetCommand command)
        {
            command.Validate();

            var UsrMissionDets = await _unitOfWork.UsrMissionDetRepository.FindAsync(c => c.Id == command.Id);

            if (UsrMissionDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrMissionDet = Mapper.Map(command);
            await _unitOfWork.UsrMissionDetRepository.AddAsync(newUsrMissionDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrMissionDetCommand command)
        {

            command.Validate();

            var UsrMissionDet = await _unitOfWork.UsrMissionDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrMissionDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrMissionDet = Mapper.Map(UsrMissionDet, command);
            UsrMissionDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrMissionDet = await _unitOfWork.UsrMissionDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrMissionDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrMissionDet.IsActive = false;
            UsrMissionDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrMissionDets = await _unitOfWork.UsrMissionDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrMissionDetsDto = Mapper.Map(UsrMissionDets);

            return OkResult(CustomMessage.DefaultMessage, UsrMissionDetsDto.ToPagingAndSorting(query), UsrMissionDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrMissionDet = await _unitOfWork.UsrMissionDetRepository.GetByIdAsync(id);

            if (UsrMissionDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrMissionDetDto = Mapper.Map(UsrMissionDet);

            return OkResult( CustomMessage.DefaultMessage , UsrMissionDetDto);

        }
    }
}
