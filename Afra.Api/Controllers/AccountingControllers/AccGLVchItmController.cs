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

namespace Afra.Api.Controllers.AccGLVchItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccGLVchItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccGLVchItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccGLVchItmCommand command)
        {
            command.Validate();

            var AccGLVchItms = await _unitOfWork.AccGLVchItmRepository.FindAsync(c => c.Id == command.Id);

            if (AccGLVchItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccGLVchItm = Mapper.Map(command);
            await _unitOfWork.AccGLVchItmRepository.AddAsync(newAccGLVchItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccGLVchItmCommand command)
        {

            command.Validate();

            var AccGLVchItm = await _unitOfWork.AccGLVchItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccGLVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccGLVchItm = Mapper.Map(AccGLVchItm, command);
            AccGLVchItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccGLVchItm = await _unitOfWork.AccGLVchItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccGLVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccGLVchItm.IsActive = false;
            AccGLVchItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccGLVchItms = await _unitOfWork.AccGLVchItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccGLVchItmsDto = Mapper.Map(AccGLVchItms);

            return OkResult(CustomMessage.DefaultMessage, AccGLVchItmsDto.ToPagingAndSorting(query), AccGLVchItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccGLVchItm = await _unitOfWork.AccGLVchItmRepository.GetByIdAsync(id);

            if (AccGLVchItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccGLVchItmDto = Mapper.Map(AccGLVchItm);

            return OkResult( CustomMessage.DefaultMessage , AccGLVchItmDto);

        }
    }
}
