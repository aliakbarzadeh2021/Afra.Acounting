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

namespace Afra.Api.Controllers.PrdConsumItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdConsumItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdConsumItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdConsumItmCommand command)
        {
            command.Validate();

            var PrdConsumItms = await _unitOfWork.PrdConsumItmRepository.FindAsync(c => c.Id == command.Id);

            if (PrdConsumItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdConsumItm = Mapper.Map(command);
            await _unitOfWork.PrdConsumItmRepository.AddAsync(newPrdConsumItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdConsumItmCommand command)
        {

            command.Validate();

            var PrdConsumItm = await _unitOfWork.PrdConsumItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdConsumItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdConsumItm = Mapper.Map(PrdConsumItm, command);
            PrdConsumItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdConsumItm = await _unitOfWork.PrdConsumItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdConsumItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdConsumItm.IsActive = false;
            PrdConsumItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdConsumItms = await _unitOfWork.PrdConsumItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdConsumItmsDto = Mapper.Map(PrdConsumItms);

            return OkResult(CustomMessage.DefaultMessage, PrdConsumItmsDto.ToPagingAndSorting(query), PrdConsumItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdConsumItm = await _unitOfWork.PrdConsumItmRepository.GetByIdAsync(id);

            if (PrdConsumItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdConsumItmDto = Mapper.Map(PrdConsumItm);

            return OkResult( CustomMessage.DefaultMessage , PrdConsumItmDto);

        }
    }
}
