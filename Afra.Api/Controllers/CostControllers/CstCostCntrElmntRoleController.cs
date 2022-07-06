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

namespace Afra.Api.Controllers.CstCostCntrElmntRoleControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstCostCntrElmntRoleController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstCostCntrElmntRoleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstCostCntrElmntRoleCommand command)
        {
            command.Validate();

            var CstCostCntrElmntRoles = await _unitOfWork.CstCostCntrElmntRoleRepository.FindAsync(c => c.Id == command.Id);

            if (CstCostCntrElmntRoles.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstCostCntrElmntRole = Mapper.Map(command);
            await _unitOfWork.CstCostCntrElmntRoleRepository.AddAsync(newCstCostCntrElmntRole);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstCostCntrElmntRoleCommand command)
        {

            command.Validate();

            var CstCostCntrElmntRole = await _unitOfWork.CstCostCntrElmntRoleRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstCostCntrElmntRole == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostCntrElmntRole = Mapper.Map(CstCostCntrElmntRole, command);
            CstCostCntrElmntRole.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstCostCntrElmntRole = await _unitOfWork.CstCostCntrElmntRoleRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstCostCntrElmntRole == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstCostCntrElmntRole.IsActive = false;
            CstCostCntrElmntRole.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstCostCntrElmntRoles = await _unitOfWork.CstCostCntrElmntRoleRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstCostCntrElmntRolesDto = Mapper.Map(CstCostCntrElmntRoles);

            return OkResult(CustomMessage.DefaultMessage, CstCostCntrElmntRolesDto.ToPagingAndSorting(query), CstCostCntrElmntRolesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstCostCntrElmntRole = await _unitOfWork.CstCostCntrElmntRoleRepository.GetByIdAsync(id);

            if (CstCostCntrElmntRole is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstCostCntrElmntRoleDto = Mapper.Map(CstCostCntrElmntRole);

            return OkResult( CustomMessage.DefaultMessage , CstCostCntrElmntRoleDto);

        }
    }
}
