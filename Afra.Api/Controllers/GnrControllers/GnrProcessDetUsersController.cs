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

namespace Afra.Api.Controllers.GnrProcessDetUsersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrProcessDetUsersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrProcessDetUsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrProcessDetUsersCommand command)
        {
            command.Validate();

            var GnrProcessDetUserss = await _unitOfWork.GnrProcessDetUsersRepository.FindAsync(c => c.Id == command.Id);

            if (GnrProcessDetUserss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrProcessDetUsers = Mapper.Map(command);
            await _unitOfWork.GnrProcessDetUsersRepository.AddAsync(newGnrProcessDetUsers);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrProcessDetUsersCommand command)
        {

            command.Validate();

            var GnrProcessDetUsers = await _unitOfWork.GnrProcessDetUsersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrProcessDetUsers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrProcessDetUsers = Mapper.Map(GnrProcessDetUsers, command);
            GnrProcessDetUsers.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrProcessDetUsers = await _unitOfWork.GnrProcessDetUsersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrProcessDetUsers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrProcessDetUsers.IsActive = false;
            GnrProcessDetUsers.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrProcessDetUserss = await _unitOfWork.GnrProcessDetUsersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrProcessDetUserssDto = Mapper.Map(GnrProcessDetUserss);

            return OkResult(CustomMessage.DefaultMessage, GnrProcessDetUserssDto.ToPagingAndSorting(query), GnrProcessDetUserssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrProcessDetUsers = await _unitOfWork.GnrProcessDetUsersRepository.GetByIdAsync(id);

            if (GnrProcessDetUsers is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrProcessDetUsersDto = Mapper.Map(GnrProcessDetUsers);

            return OkResult( CustomMessage.DefaultMessage , GnrProcessDetUsersDto);

        }
    }
}
