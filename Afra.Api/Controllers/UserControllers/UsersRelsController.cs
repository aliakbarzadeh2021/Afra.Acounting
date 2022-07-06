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

namespace Afra.Api.Controllers.UsersRelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsersRelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsersRelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsersRelsCommand command)
        {
            command.Validate();

            var UsersRelss = await _unitOfWork.UsersRelsRepository.FindAsync(c => c.Id == command.Id);

            if (UsersRelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsersRels = Mapper.Map(command);
            await _unitOfWork.UsersRelsRepository.AddAsync(newUsersRels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsersRelsCommand command)
        {

            command.Validate();

            var UsersRels = await _unitOfWork.UsersRelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsersRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsersRels = Mapper.Map(UsersRels, command);
            UsersRels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsersRels = await _unitOfWork.UsersRelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsersRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsersRels.IsActive = false;
            UsersRels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsersRelss = await _unitOfWork.UsersRelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsersRelssDto = Mapper.Map(UsersRelss);

            return OkResult(CustomMessage.DefaultMessage, UsersRelssDto.ToPagingAndSorting(query), UsersRelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsersRels = await _unitOfWork.UsersRelsRepository.GetByIdAsync(id);

            if (UsersRels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsersRelsDto = Mapper.Map(UsersRels);

            return OkResult( CustomMessage.DefaultMessage , UsersRelsDto);

        }
    }
}
