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

namespace Afra.Api.Controllers.CstElmntRolesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstElmntRolesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstElmntRolesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstElmntRolesCommand command)
        {
            command.Validate();

            var CstElmntRoless = await _unitOfWork.CstElmntRolesRepository.FindAsync(c => c.Id == command.Id);

            if (CstElmntRoless.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstElmntRoles = Mapper.Map(command);
            await _unitOfWork.CstElmntRolesRepository.AddAsync(newCstElmntRoles);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstElmntRolesCommand command)
        {

            command.Validate();

            var CstElmntRoles = await _unitOfWork.CstElmntRolesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstElmntRoles == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstElmntRoles = Mapper.Map(CstElmntRoles, command);
            CstElmntRoles.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstElmntRoles = await _unitOfWork.CstElmntRolesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstElmntRoles == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstElmntRoles.IsActive = false;
            CstElmntRoles.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstElmntRoless = await _unitOfWork.CstElmntRolesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstElmntRolessDto = Mapper.Map(CstElmntRoless);

            return OkResult(CustomMessage.DefaultMessage, CstElmntRolessDto.ToPagingAndSorting(query), CstElmntRolessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstElmntRoles = await _unitOfWork.CstElmntRolesRepository.GetByIdAsync(id);

            if (CstElmntRoles is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstElmntRolesDto = Mapper.Map(CstElmntRoles);

            return OkResult( CustomMessage.DefaultMessage , CstElmntRolesDto);

        }
    }
}
