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

namespace Afra.Api.Controllers.AccGLControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccGLController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccGLController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccGLCommand command)
        {
            command.Validate();

            var AccGLs = await _unitOfWork.AccGLRepository.FindAsync(c => c.Id == command.Id);

            if (AccGLs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccGL = Mapper.Map(command);
            await _unitOfWork.AccGLRepository.AddAsync(newAccGL);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccGLCommand command)
        {

            command.Validate();

            var AccGL = await _unitOfWork.AccGLRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccGL == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccGL = Mapper.Map(AccGL, command);
            AccGL.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccGL = await _unitOfWork.AccGLRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccGL == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccGL.IsActive = false;
            AccGL.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccGLs = await _unitOfWork.AccGLRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccGLsDto = Mapper.Map(AccGLs);

            return OkResult(CustomMessage.DefaultMessage, AccGLsDto.ToPagingAndSorting(query), AccGLsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccGL = await _unitOfWork.AccGLRepository.GetByIdAsync(id);

            if (AccGL is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccGLDto = Mapper.Map(AccGL);

            return OkResult( CustomMessage.DefaultMessage , AccGLDto);

        }
    }
}
