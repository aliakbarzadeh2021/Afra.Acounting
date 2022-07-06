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

namespace Afra.Api.Controllers.AccTransVchControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccTransVchController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccTransVchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccTransVchCommand command)
        {
            command.Validate();

            var AccTransVchs = await _unitOfWork.AccTransVchRepository.FindAsync(c => c.Id == command.Id);

            if (AccTransVchs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccTransVch = Mapper.Map(command);
            await _unitOfWork.AccTransVchRepository.AddAsync(newAccTransVch);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccTransVchCommand command)
        {

            command.Validate();

            var AccTransVch = await _unitOfWork.AccTransVchRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccTransVch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccTransVch = Mapper.Map(AccTransVch, command);
            AccTransVch.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccTransVch = await _unitOfWork.AccTransVchRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccTransVch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccTransVch.IsActive = false;
            AccTransVch.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccTransVchs = await _unitOfWork.AccTransVchRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccTransVchsDto = Mapper.Map(AccTransVchs);

            return OkResult(CustomMessage.DefaultMessage, AccTransVchsDto.ToPagingAndSorting(query), AccTransVchsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccTransVch = await _unitOfWork.AccTransVchRepository.GetByIdAsync(id);

            if (AccTransVch is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccTransVchDto = Mapper.Map(AccTransVch);

            return OkResult( CustomMessage.DefaultMessage , AccTransVchDto);

        }
    }
}
