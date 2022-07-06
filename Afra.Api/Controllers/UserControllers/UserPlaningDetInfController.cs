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

namespace Afra.Api.Controllers.UserPlaningDetInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserPlaningDetInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserPlaningDetInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserPlaningDetInfCommand command)
        {
            command.Validate();

            var UserPlaningDetInfs = await _unitOfWork.UserPlaningDetInfRepository.FindAsync(c => c.Id == command.Id);

            if (UserPlaningDetInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUserPlaningDetInf = Mapper.Map(command);
            await _unitOfWork.UserPlaningDetInfRepository.AddAsync(newUserPlaningDetInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserPlaningDetInfCommand command)
        {

            command.Validate();

            var UserPlaningDetInf = await _unitOfWork.UserPlaningDetInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UserPlaningDetInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserPlaningDetInf = Mapper.Map(UserPlaningDetInf, command);
            UserPlaningDetInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UserPlaningDetInf = await _unitOfWork.UserPlaningDetInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UserPlaningDetInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserPlaningDetInf.IsActive = false;
            UserPlaningDetInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UserPlaningDetInfs = await _unitOfWork.UserPlaningDetInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserPlaningDetInfsDto = Mapper.Map(UserPlaningDetInfs);

            return OkResult(CustomMessage.DefaultMessage, UserPlaningDetInfsDto.ToPagingAndSorting(query), UserPlaningDetInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UserPlaningDetInf = await _unitOfWork.UserPlaningDetInfRepository.GetByIdAsync(id);

            if (UserPlaningDetInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserPlaningDetInfDto = Mapper.Map(UserPlaningDetInf);

            return OkResult( CustomMessage.DefaultMessage , UserPlaningDetInfDto);

        }
    }
}
