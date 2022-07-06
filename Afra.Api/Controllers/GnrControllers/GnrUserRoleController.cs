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

namespace Afra.Api.Controllers.GnrUserRoleControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrUserRoleController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrUserRoleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrUserRoleCommand command)
        {
            command.Validate();

            var GnrUserRoles = await _unitOfWork.GnrUserRoleRepository.FindAsync(c => c.Id == command.Id);

            if (GnrUserRoles.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrUserRole = Mapper.Map(command);
            await _unitOfWork.GnrUserRoleRepository.AddAsync(newGnrUserRole);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrUserRoleCommand command)
        {

            command.Validate();

            var GnrUserRole = await _unitOfWork.GnrUserRoleRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrUserRole == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserRole = Mapper.Map(GnrUserRole, command);
            GnrUserRole.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrUserRole = await _unitOfWork.GnrUserRoleRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrUserRole == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserRole.IsActive = false;
            GnrUserRole.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrUserRoles = await _unitOfWork.GnrUserRoleRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrUserRolesDto = Mapper.Map(GnrUserRoles);

            return OkResult(CustomMessage.DefaultMessage, GnrUserRolesDto.ToPagingAndSorting(query), GnrUserRolesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrUserRole = await _unitOfWork.GnrUserRoleRepository.GetByIdAsync(id);

            if (GnrUserRole is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrUserRoleDto = Mapper.Map(GnrUserRole);

            return OkResult( CustomMessage.DefaultMessage , GnrUserRoleDto);

        }
    }
}
