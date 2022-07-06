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

namespace Afra.Api.Controllers.UserPlaningDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserPlaningDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserPlaningDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserPlaningDetCommand command)
        {
            command.Validate();

            var UserPlaningDets = await _unitOfWork.UserPlaningDetRepository.FindAsync(c => c.Id == command.Id);

            if (UserPlaningDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUserPlaningDet = Mapper.Map(command);
            await _unitOfWork.UserPlaningDetRepository.AddAsync(newUserPlaningDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserPlaningDetCommand command)
        {

            command.Validate();

            var UserPlaningDet = await _unitOfWork.UserPlaningDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UserPlaningDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserPlaningDet = Mapper.Map(UserPlaningDet, command);
            UserPlaningDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UserPlaningDet = await _unitOfWork.UserPlaningDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UserPlaningDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserPlaningDet.IsActive = false;
            UserPlaningDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UserPlaningDets = await _unitOfWork.UserPlaningDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserPlaningDetsDto = Mapper.Map(UserPlaningDets);

            return OkResult(CustomMessage.DefaultMessage, UserPlaningDetsDto.ToPagingAndSorting(query), UserPlaningDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UserPlaningDet = await _unitOfWork.UserPlaningDetRepository.GetByIdAsync(id);

            if (UserPlaningDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserPlaningDetDto = Mapper.Map(UserPlaningDet);

            return OkResult( CustomMessage.DefaultMessage , UserPlaningDetDto);

        }
    }
}
