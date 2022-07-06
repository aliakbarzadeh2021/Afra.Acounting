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

namespace Afra.Api.Controllers.PrdVchItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdVchItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdVchItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdVchItmCommand command)
        {
            command.Validate();

            var PrdVchItms = await _unitOfWork.PrdVchItmRepository.FindAsync(c => c.Id == command.Id);

            if (PrdVchItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdVchItm = Mapper.Map(command);
            await _unitOfWork.PrdVchItmRepository.AddAsync(newPrdVchItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdVchItmCommand command)
        {

            command.Validate();

            var PrdVchItm = await _unitOfWork.PrdVchItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdVchItm = Mapper.Map(PrdVchItm, command);
            PrdVchItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdVchItm = await _unitOfWork.PrdVchItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdVchItm.IsActive = false;
            PrdVchItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdVchItms = await _unitOfWork.PrdVchItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdVchItmsDto = Mapper.Map(PrdVchItms);

            return OkResult(CustomMessage.DefaultMessage, PrdVchItmsDto.ToPagingAndSorting(query), PrdVchItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdVchItm = await _unitOfWork.PrdVchItmRepository.GetByIdAsync(id);

            if (PrdVchItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdVchItmDto = Mapper.Map(PrdVchItm);

            return OkResult( CustomMessage.DefaultMessage , PrdVchItmDto);

        }
    }
}
