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

namespace Afra.Api.Controllers.ElmntMethodRolesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ElmntMethodRolesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ElmntMethodRolesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddElmntMethodRolesCommand command)
        {
            command.Validate();

            var ElmntMethodRoless = await _unitOfWork.ElmntMethodRolesRepository.FindAsync(c => c.Id == command.Id);

            if (ElmntMethodRoless.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newElmntMethodRoles = Mapper.Map(command);
            await _unitOfWork.ElmntMethodRolesRepository.AddAsync(newElmntMethodRoles);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditElmntMethodRolesCommand command)
        {

            command.Validate();

            var ElmntMethodRoles = await _unitOfWork.ElmntMethodRolesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ElmntMethodRoles == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ElmntMethodRoles = Mapper.Map(ElmntMethodRoles, command);
            ElmntMethodRoles.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ElmntMethodRoles = await _unitOfWork.ElmntMethodRolesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ElmntMethodRoles == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ElmntMethodRoles.IsActive = false;
            ElmntMethodRoles.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ElmntMethodRoless = await _unitOfWork.ElmntMethodRolesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ElmntMethodRolessDto = Mapper.Map(ElmntMethodRoless);

            return OkResult(CustomMessage.DefaultMessage, ElmntMethodRolessDto.ToPagingAndSorting(query), ElmntMethodRolessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ElmntMethodRoles = await _unitOfWork.ElmntMethodRolesRepository.GetByIdAsync(id);

            if (ElmntMethodRoles is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ElmntMethodRolesDto = Mapper.Map(ElmntMethodRoles);

            return OkResult( CustomMessage.DefaultMessage , ElmntMethodRolesDto);

        }
    }
}
