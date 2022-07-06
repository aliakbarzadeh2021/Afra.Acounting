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

namespace Afra.Api.Controllers.TrsPayChqItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsPayChqItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsPayChqItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsPayChqItmCommand command)
        {
            command.Validate();

            var TrsPayChqItms = await _unitOfWork.TrsPayChqItmRepository.FindAsync(c => c.Id == command.Id);

            if (TrsPayChqItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsPayChqItm = Mapper.Map(command);
            await _unitOfWork.TrsPayChqItmRepository.AddAsync(newTrsPayChqItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsPayChqItmCommand command)
        {

            command.Validate();

            var TrsPayChqItm = await _unitOfWork.TrsPayChqItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsPayChqItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsPayChqItm = Mapper.Map(TrsPayChqItm, command);
            TrsPayChqItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsPayChqItm = await _unitOfWork.TrsPayChqItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsPayChqItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsPayChqItm.IsActive = false;
            TrsPayChqItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsPayChqItms = await _unitOfWork.TrsPayChqItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsPayChqItmsDto = Mapper.Map(TrsPayChqItms);

            return OkResult(CustomMessage.DefaultMessage, TrsPayChqItmsDto.ToPagingAndSorting(query), TrsPayChqItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsPayChqItm = await _unitOfWork.TrsPayChqItmRepository.GetByIdAsync(id);

            if (TrsPayChqItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsPayChqItmDto = Mapper.Map(TrsPayChqItm);

            return OkResult( CustomMessage.DefaultMessage , TrsPayChqItmDto);

        }
    }
}
