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

namespace Afra.Api.Controllers.ElementRolesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ElementRolesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ElementRolesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddElementRolesCommand command)
        {
            command.Validate();

            var ElementRoless = await _unitOfWork.ElementRolesRepository.FindAsync(c => c.Id == command.Id);

            if (ElementRoless.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newElementRoles = Mapper.Map(command);
            await _unitOfWork.ElementRolesRepository.AddAsync(newElementRoles);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditElementRolesCommand command)
        {

            command.Validate();

            var ElementRoles = await _unitOfWork.ElementRolesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ElementRoles == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ElementRoles = Mapper.Map(ElementRoles, command);
            ElementRoles.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ElementRoles = await _unitOfWork.ElementRolesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ElementRoles == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ElementRoles.IsActive = false;
            ElementRoles.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ElementRoless = await _unitOfWork.ElementRolesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ElementRolessDto = Mapper.Map(ElementRoless);

            return OkResult(CustomMessage.DefaultMessage, ElementRolessDto.ToPagingAndSorting(query), ElementRolessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ElementRoles = await _unitOfWork.ElementRolesRepository.GetByIdAsync(id);

            if (ElementRoles is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ElementRolesDto = Mapper.Map(ElementRoles);

            return OkResult( CustomMessage.DefaultMessage , ElementRolesDto);

        }
    }
}
