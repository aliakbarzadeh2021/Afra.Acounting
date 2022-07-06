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

namespace Afra.Api.Controllers.GnrLimitGroupControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrLimitGroupController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrLimitGroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrLimitGroupCommand command)
        {
            command.Validate();

            var GnrLimitGroups = await _unitOfWork.GnrLimitGroupRepository.FindAsync(c => c.Id == command.Id);

            if (GnrLimitGroups.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrLimitGroup = Mapper.Map(command);
            await _unitOfWork.GnrLimitGroupRepository.AddAsync(newGnrLimitGroup);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrLimitGroupCommand command)
        {

            command.Validate();

            var GnrLimitGroup = await _unitOfWork.GnrLimitGroupRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrLimitGroup == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrLimitGroup = Mapper.Map(GnrLimitGroup, command);
            GnrLimitGroup.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrLimitGroup = await _unitOfWork.GnrLimitGroupRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrLimitGroup == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrLimitGroup.IsActive = false;
            GnrLimitGroup.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrLimitGroups = await _unitOfWork.GnrLimitGroupRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrLimitGroupsDto = Mapper.Map(GnrLimitGroups);

            return OkResult(CustomMessage.DefaultMessage, GnrLimitGroupsDto.ToPagingAndSorting(query), GnrLimitGroupsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrLimitGroup = await _unitOfWork.GnrLimitGroupRepository.GetByIdAsync(id);

            if (GnrLimitGroup is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrLimitGroupDto = Mapper.Map(GnrLimitGroup);

            return OkResult( CustomMessage.DefaultMessage , GnrLimitGroupDto);

        }
    }
}
