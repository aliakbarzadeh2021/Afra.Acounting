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

namespace Afra.Api.Controllers.BdgElmntRolesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgElmntRolesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgElmntRolesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgElmntRolesCommand command)
        {
            command.Validate();

            var BdgElmntRoless = await _unitOfWork.BdgElmntRolesRepository.FindAsync(c => c.Id == command.Id);

            if (BdgElmntRoless.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgElmntRoles = Mapper.Map(command);
            await _unitOfWork.BdgElmntRolesRepository.AddAsync(newBdgElmntRoles);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgElmntRolesCommand command)
        {

            command.Validate();

            var BdgElmntRoles = await _unitOfWork.BdgElmntRolesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgElmntRoles == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgElmntRoles = Mapper.Map(BdgElmntRoles, command);
            BdgElmntRoles.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgElmntRoles = await _unitOfWork.BdgElmntRolesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgElmntRoles == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgElmntRoles.IsActive = false;
            BdgElmntRoles.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgElmntRoless = await _unitOfWork.BdgElmntRolesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgElmntRolessDto = Mapper.Map(BdgElmntRoless);

            return OkResult(CustomMessage.DefaultMessage, BdgElmntRolessDto.ToPagingAndSorting(query), BdgElmntRolessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgElmntRoles = await _unitOfWork.BdgElmntRolesRepository.GetByIdAsync(id);

            if (BdgElmntRoles is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgElmntRolesDto = Mapper.Map(BdgElmntRoles);

            return OkResult( CustomMessage.DefaultMessage , BdgElmntRolesDto);

        }
    }
}
