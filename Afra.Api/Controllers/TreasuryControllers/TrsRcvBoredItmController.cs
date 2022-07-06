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

namespace Afra.Api.Controllers.TrsRcvBoredItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsRcvBoredItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsRcvBoredItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsRcvBoredItmCommand command)
        {
            command.Validate();

            var TrsRcvBoredItms = await _unitOfWork.TrsRcvBoredItmRepository.FindAsync(c => c.Id == command.Id);

            if (TrsRcvBoredItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsRcvBoredItm = Mapper.Map(command);
            await _unitOfWork.TrsRcvBoredItmRepository.AddAsync(newTrsRcvBoredItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsRcvBoredItmCommand command)
        {

            command.Validate();

            var TrsRcvBoredItm = await _unitOfWork.TrsRcvBoredItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsRcvBoredItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsRcvBoredItm = Mapper.Map(TrsRcvBoredItm, command);
            TrsRcvBoredItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsRcvBoredItm = await _unitOfWork.TrsRcvBoredItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsRcvBoredItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsRcvBoredItm.IsActive = false;
            TrsRcvBoredItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsRcvBoredItms = await _unitOfWork.TrsRcvBoredItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsRcvBoredItmsDto = Mapper.Map(TrsRcvBoredItms);

            return OkResult(CustomMessage.DefaultMessage, TrsRcvBoredItmsDto.ToPagingAndSorting(query), TrsRcvBoredItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsRcvBoredItm = await _unitOfWork.TrsRcvBoredItmRepository.GetByIdAsync(id);

            if (TrsRcvBoredItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsRcvBoredItmDto = Mapper.Map(TrsRcvBoredItm);

            return OkResult( CustomMessage.DefaultMessage , TrsRcvBoredItmDto);

        }
    }
}
