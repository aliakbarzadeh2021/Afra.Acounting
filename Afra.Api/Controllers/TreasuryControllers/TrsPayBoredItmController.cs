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

namespace Afra.Api.Controllers.TrsPayBoredItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsPayBoredItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsPayBoredItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsPayBoredItmCommand command)
        {
            command.Validate();

            var TrsPayBoredItms = await _unitOfWork.TrsPayBoredItmRepository.FindAsync(c => c.Id == command.Id);

            if (TrsPayBoredItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsPayBoredItm = Mapper.Map(command);
            await _unitOfWork.TrsPayBoredItmRepository.AddAsync(newTrsPayBoredItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsPayBoredItmCommand command)
        {

            command.Validate();

            var TrsPayBoredItm = await _unitOfWork.TrsPayBoredItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsPayBoredItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsPayBoredItm = Mapper.Map(TrsPayBoredItm, command);
            TrsPayBoredItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsPayBoredItm = await _unitOfWork.TrsPayBoredItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsPayBoredItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsPayBoredItm.IsActive = false;
            TrsPayBoredItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsPayBoredItms = await _unitOfWork.TrsPayBoredItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsPayBoredItmsDto = Mapper.Map(TrsPayBoredItms);

            return OkResult(CustomMessage.DefaultMessage, TrsPayBoredItmsDto.ToPagingAndSorting(query), TrsPayBoredItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsPayBoredItm = await _unitOfWork.TrsPayBoredItmRepository.GetByIdAsync(id);

            if (TrsPayBoredItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsPayBoredItmDto = Mapper.Map(TrsPayBoredItm);

            return OkResult( CustomMessage.DefaultMessage , TrsPayBoredItmDto);

        }
    }
}
