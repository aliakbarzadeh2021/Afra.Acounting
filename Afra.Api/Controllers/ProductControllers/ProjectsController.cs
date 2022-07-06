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

namespace Afra.Api.Controllers.ProjectsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProjectsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProjectsCommand command)
        {
            command.Validate();

            var Projectss = await _unitOfWork.ProjectsRepository.FindAsync(c => c.Id == command.Id);

            if (Projectss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newProjects = Mapper.Map(command);
            await _unitOfWork.ProjectsRepository.AddAsync(newProjects);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditProjectsCommand command)
        {

            command.Validate();

            var Projects = await _unitOfWork.ProjectsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Projects == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Projects = Mapper.Map(Projects, command);
            Projects.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Projects = await _unitOfWork.ProjectsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Projects == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Projects.IsActive = false;
            Projects.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Projectss = await _unitOfWork.ProjectsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ProjectssDto = Mapper.Map(Projectss);

            return OkResult(CustomMessage.DefaultMessage, ProjectssDto.ToPagingAndSorting(query), ProjectssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Projects = await _unitOfWork.ProjectsRepository.GetByIdAsync(id);

            if (Projects is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ProjectsDto = Mapper.Map(Projects);

            return OkResult( CustomMessage.DefaultMessage , ProjectsDto);

        }
    }
}
