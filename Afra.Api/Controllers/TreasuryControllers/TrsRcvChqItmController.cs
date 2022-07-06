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

namespace Afra.Api.Controllers.TrsRcvChqItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsRcvChqItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsRcvChqItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsRcvChqItmCommand command)
        {
            command.Validate();

            var TrsRcvChqItms = await _unitOfWork.TrsRcvChqItmRepository.FindAsync(c => c.Id == command.Id);

            if (TrsRcvChqItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsRcvChqItm = Mapper.Map(command);
            await _unitOfWork.TrsRcvChqItmRepository.AddAsync(newTrsRcvChqItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsRcvChqItmCommand command)
        {

            command.Validate();

            var TrsRcvChqItm = await _unitOfWork.TrsRcvChqItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsRcvChqItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsRcvChqItm = Mapper.Map(TrsRcvChqItm, command);
            TrsRcvChqItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsRcvChqItm = await _unitOfWork.TrsRcvChqItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsRcvChqItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsRcvChqItm.IsActive = false;
            TrsRcvChqItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsRcvChqItms = await _unitOfWork.TrsRcvChqItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsRcvChqItmsDto = Mapper.Map(TrsRcvChqItms);

            return OkResult(CustomMessage.DefaultMessage, TrsRcvChqItmsDto.ToPagingAndSorting(query), TrsRcvChqItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsRcvChqItm = await _unitOfWork.TrsRcvChqItmRepository.GetByIdAsync(id);

            if (TrsRcvChqItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsRcvChqItmDto = Mapper.Map(TrsRcvChqItm);

            return OkResult( CustomMessage.DefaultMessage , TrsRcvChqItmDto);

        }
    }
}
