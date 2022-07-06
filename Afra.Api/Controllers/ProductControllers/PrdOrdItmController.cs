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

namespace Afra.Api.Controllers.PrdOrdItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdOrdItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdOrdItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdOrdItmCommand command)
        {
            command.Validate();

            var PrdOrdItms = await _unitOfWork.PrdOrdItmRepository.FindAsync(c => c.Id == command.Id);

            if (PrdOrdItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdOrdItm = Mapper.Map(command);
            await _unitOfWork.PrdOrdItmRepository.AddAsync(newPrdOrdItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdOrdItmCommand command)
        {

            command.Validate();

            var PrdOrdItm = await _unitOfWork.PrdOrdItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdOrdItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdOrdItm = Mapper.Map(PrdOrdItm, command);
            PrdOrdItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdOrdItm = await _unitOfWork.PrdOrdItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdOrdItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdOrdItm.IsActive = false;
            PrdOrdItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdOrdItms = await _unitOfWork.PrdOrdItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdOrdItmsDto = Mapper.Map(PrdOrdItms);

            return OkResult(CustomMessage.DefaultMessage, PrdOrdItmsDto.ToPagingAndSorting(query), PrdOrdItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdOrdItm = await _unitOfWork.PrdOrdItmRepository.GetByIdAsync(id);

            if (PrdOrdItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdOrdItmDto = Mapper.Map(PrdOrdItm);

            return OkResult( CustomMessage.DefaultMessage , PrdOrdItmDto);

        }
    }
}
