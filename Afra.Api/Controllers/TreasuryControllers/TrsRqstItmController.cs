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

namespace Afra.Api.Controllers.TrsRqstItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsRqstItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsRqstItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsRqstItmCommand command)
        {
            command.Validate();

            var TrsRqstItms = await _unitOfWork.TrsRqstItmRepository.FindAsync(c => c.Id == command.Id);

            if (TrsRqstItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsRqstItm = Mapper.Map(command);
            await _unitOfWork.TrsRqstItmRepository.AddAsync(newTrsRqstItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsRqstItmCommand command)
        {

            command.Validate();

            var TrsRqstItm = await _unitOfWork.TrsRqstItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsRqstItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsRqstItm = Mapper.Map(TrsRqstItm, command);
            TrsRqstItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsRqstItm = await _unitOfWork.TrsRqstItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsRqstItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsRqstItm.IsActive = false;
            TrsRqstItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsRqstItms = await _unitOfWork.TrsRqstItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsRqstItmsDto = Mapper.Map(TrsRqstItms);

            return OkResult(CustomMessage.DefaultMessage, TrsRqstItmsDto.ToPagingAndSorting(query), TrsRqstItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsRqstItm = await _unitOfWork.TrsRqstItmRepository.GetByIdAsync(id);

            if (TrsRqstItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsRqstItmDto = Mapper.Map(TrsRqstItm);

            return OkResult( CustomMessage.DefaultMessage , TrsRqstItmDto);

        }
    }
}
