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

namespace Afra.Api.Controllers.OtoUserRightControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoUserRightController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoUserRightController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoUserRightCommand command)
        {
            command.Validate();

            var OtoUserRights = await _unitOfWork.OtoUserRightRepository.FindAsync(c => c.Id == command.Id);

            if (OtoUserRights.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoUserRight = Mapper.Map(command);
            await _unitOfWork.OtoUserRightRepository.AddAsync(newOtoUserRight);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoUserRightCommand command)
        {

            command.Validate();

            var OtoUserRight = await _unitOfWork.OtoUserRightRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoUserRight == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoUserRight = Mapper.Map(OtoUserRight, command);
            OtoUserRight.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoUserRight = await _unitOfWork.OtoUserRightRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoUserRight == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoUserRight.IsActive = false;
            OtoUserRight.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoUserRights = await _unitOfWork.OtoUserRightRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoUserRightsDto = Mapper.Map(OtoUserRights);

            return OkResult(CustomMessage.DefaultMessage, OtoUserRightsDto.ToPagingAndSorting(query), OtoUserRightsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoUserRight = await _unitOfWork.OtoUserRightRepository.GetByIdAsync(id);

            if (OtoUserRight is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoUserRightDto = Mapper.Map(OtoUserRight);

            return OkResult( CustomMessage.DefaultMessage , OtoUserRightDto);

        }
    }
}
