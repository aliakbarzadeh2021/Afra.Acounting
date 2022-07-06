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

namespace Afra.Api.Controllers.PrdStopItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdStopItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdStopItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdStopItmCommand command)
        {
            command.Validate();

            var PrdStopItms = await _unitOfWork.PrdStopItmRepository.FindAsync(c => c.Id == command.Id);

            if (PrdStopItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdStopItm = Mapper.Map(command);
            await _unitOfWork.PrdStopItmRepository.AddAsync(newPrdStopItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdStopItmCommand command)
        {

            command.Validate();

            var PrdStopItm = await _unitOfWork.PrdStopItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdStopItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdStopItm = Mapper.Map(PrdStopItm, command);
            PrdStopItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdStopItm = await _unitOfWork.PrdStopItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdStopItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdStopItm.IsActive = false;
            PrdStopItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdStopItms = await _unitOfWork.PrdStopItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdStopItmsDto = Mapper.Map(PrdStopItms);

            return OkResult(CustomMessage.DefaultMessage, PrdStopItmsDto.ToPagingAndSorting(query), PrdStopItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdStopItm = await _unitOfWork.PrdStopItmRepository.GetByIdAsync(id);

            if (PrdStopItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdStopItmDto = Mapper.Map(PrdStopItm);

            return OkResult( CustomMessage.DefaultMessage , PrdStopItmDto);

        }
    }
}
