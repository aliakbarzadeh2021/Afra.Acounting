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

namespace Afra.Api.Controllers.TrsGuaranteeSecControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsGuaranteeSecController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsGuaranteeSecController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsGuaranteeSecCommand command)
        {
            command.Validate();

            var TrsGuaranteeSecs = await _unitOfWork.TrsGuaranteeSecRepository.FindAsync(c => c.Id == command.Id);

            if (TrsGuaranteeSecs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsGuaranteeSec = Mapper.Map(command);
            await _unitOfWork.TrsGuaranteeSecRepository.AddAsync(newTrsGuaranteeSec);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsGuaranteeSecCommand command)
        {

            command.Validate();

            var TrsGuaranteeSec = await _unitOfWork.TrsGuaranteeSecRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsGuaranteeSec == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsGuaranteeSec = Mapper.Map(TrsGuaranteeSec, command);
            TrsGuaranteeSec.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsGuaranteeSec = await _unitOfWork.TrsGuaranteeSecRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsGuaranteeSec == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsGuaranteeSec.IsActive = false;
            TrsGuaranteeSec.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsGuaranteeSecs = await _unitOfWork.TrsGuaranteeSecRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsGuaranteeSecsDto = Mapper.Map(TrsGuaranteeSecs);

            return OkResult(CustomMessage.DefaultMessage, TrsGuaranteeSecsDto.ToPagingAndSorting(query), TrsGuaranteeSecsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsGuaranteeSec = await _unitOfWork.TrsGuaranteeSecRepository.GetByIdAsync(id);

            if (TrsGuaranteeSec is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsGuaranteeSecDto = Mapper.Map(TrsGuaranteeSec);

            return OkResult( CustomMessage.DefaultMessage , TrsGuaranteeSecDto);

        }
    }
}
