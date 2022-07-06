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

namespace Afra.Api.Controllers.BdgProjectsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgProjectsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgProjectsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgProjectsCommand command)
        {
            command.Validate();

            var BdgProjectss = await _unitOfWork.BdgProjectsRepository.FindAsync(c => c.Id == command.Id);

            if (BdgProjectss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgProjects = Mapper.Map(command);
            await _unitOfWork.BdgProjectsRepository.AddAsync(newBdgProjects);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgProjectsCommand command)
        {

            command.Validate();

            var BdgProjects = await _unitOfWork.BdgProjectsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgProjects == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProjects = Mapper.Map(BdgProjects, command);
            BdgProjects.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgProjects = await _unitOfWork.BdgProjectsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgProjects == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProjects.IsActive = false;
            BdgProjects.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgProjectss = await _unitOfWork.BdgProjectsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgProjectssDto = Mapper.Map(BdgProjectss);

            return OkResult(CustomMessage.DefaultMessage, BdgProjectssDto.ToPagingAndSorting(query), BdgProjectssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgProjects = await _unitOfWork.BdgProjectsRepository.GetByIdAsync(id);

            if (BdgProjects is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgProjectsDto = Mapper.Map(BdgProjects);

            return OkResult( CustomMessage.DefaultMessage , BdgProjectsDto);

        }
    }
}
