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

namespace Afra.Api.Controllers.PrdPOrdItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdPOrdItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdPOrdItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdPOrdItmCommand command)
        {
            command.Validate();

            var PrdPOrdItms = await _unitOfWork.PrdPOrdItmRepository.FindAsync(c => c.Id == command.Id);

            if (PrdPOrdItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdPOrdItm = Mapper.Map(command);
            await _unitOfWork.PrdPOrdItmRepository.AddAsync(newPrdPOrdItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdPOrdItmCommand command)
        {

            command.Validate();

            var PrdPOrdItm = await _unitOfWork.PrdPOrdItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdPOrdItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdPOrdItm = Mapper.Map(PrdPOrdItm, command);
            PrdPOrdItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdPOrdItm = await _unitOfWork.PrdPOrdItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdPOrdItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdPOrdItm.IsActive = false;
            PrdPOrdItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdPOrdItms = await _unitOfWork.PrdPOrdItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdPOrdItmsDto = Mapper.Map(PrdPOrdItms);

            return OkResult(CustomMessage.DefaultMessage, PrdPOrdItmsDto.ToPagingAndSorting(query), PrdPOrdItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdPOrdItm = await _unitOfWork.PrdPOrdItmRepository.GetByIdAsync(id);

            if (PrdPOrdItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdPOrdItmDto = Mapper.Map(PrdPOrdItm);

            return OkResult( CustomMessage.DefaultMessage , PrdPOrdItmDto);

        }
    }
}
