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

namespace Afra.Api.Controllers.PrdSendItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdSendItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdSendItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdSendItmCommand command)
        {
            command.Validate();

            var PrdSendItms = await _unitOfWork.PrdSendItmRepository.FindAsync(c => c.Id == command.Id);

            if (PrdSendItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdSendItm = Mapper.Map(command);
            await _unitOfWork.PrdSendItmRepository.AddAsync(newPrdSendItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdSendItmCommand command)
        {

            command.Validate();

            var PrdSendItm = await _unitOfWork.PrdSendItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdSendItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdSendItm = Mapper.Map(PrdSendItm, command);
            PrdSendItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdSendItm = await _unitOfWork.PrdSendItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdSendItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdSendItm.IsActive = false;
            PrdSendItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdSendItms = await _unitOfWork.PrdSendItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdSendItmsDto = Mapper.Map(PrdSendItms);

            return OkResult(CustomMessage.DefaultMessage, PrdSendItmsDto.ToPagingAndSorting(query), PrdSendItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdSendItm = await _unitOfWork.PrdSendItmRepository.GetByIdAsync(id);

            if (PrdSendItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdSendItmDto = Mapper.Map(PrdSendItm);

            return OkResult( CustomMessage.DefaultMessage , PrdSendItmDto);

        }
    }
}
