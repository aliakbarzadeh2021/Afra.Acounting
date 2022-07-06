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

namespace Afra.Api.Controllers.AccGroupsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccGroupsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccGroupsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccGroupsCommand command)
        {
            command.Validate();

            var AccGroupss = await _unitOfWork.AccGroupsRepository.FindAsync(c => c.Id == command.Id);

            if (AccGroupss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccGroups = Mapper.Map(command);
            await _unitOfWork.AccGroupsRepository.AddAsync(newAccGroups);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccGroupsCommand command)
        {

            command.Validate();

            var AccGroups = await _unitOfWork.AccGroupsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccGroups = Mapper.Map(AccGroups, command);
            AccGroups.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccGroups = await _unitOfWork.AccGroupsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccGroups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccGroups.IsActive = false;
            AccGroups.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccGroupss = await _unitOfWork.AccGroupsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccGroupssDto = Mapper.Map(AccGroupss);

            return OkResult(CustomMessage.DefaultMessage, AccGroupssDto.ToPagingAndSorting(query), AccGroupssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccGroups = await _unitOfWork.AccGroupsRepository.GetByIdAsync(id);

            if (AccGroups is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccGroupsDto = Mapper.Map(AccGroups);

            return OkResult( CustomMessage.DefaultMessage , AccGroupsDto);

        }
    }
}
