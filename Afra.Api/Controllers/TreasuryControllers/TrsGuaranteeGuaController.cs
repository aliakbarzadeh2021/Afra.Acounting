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

namespace Afra.Api.Controllers.TrsGuaranteeGuaControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsGuaranteeGuaController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsGuaranteeGuaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsGuaranteeGuaCommand command)
        {
            command.Validate();

            var TrsGuaranteeGuas = await _unitOfWork.TrsGuaranteeGuaRepository.FindAsync(c => c.Id == command.Id);

            if (TrsGuaranteeGuas.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsGuaranteeGua = Mapper.Map(command);
            await _unitOfWork.TrsGuaranteeGuaRepository.AddAsync(newTrsGuaranteeGua);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsGuaranteeGuaCommand command)
        {

            command.Validate();

            var TrsGuaranteeGua = await _unitOfWork.TrsGuaranteeGuaRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsGuaranteeGua == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsGuaranteeGua = Mapper.Map(TrsGuaranteeGua, command);
            TrsGuaranteeGua.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsGuaranteeGua = await _unitOfWork.TrsGuaranteeGuaRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsGuaranteeGua == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsGuaranteeGua.IsActive = false;
            TrsGuaranteeGua.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsGuaranteeGuas = await _unitOfWork.TrsGuaranteeGuaRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsGuaranteeGuasDto = Mapper.Map(TrsGuaranteeGuas);

            return OkResult(CustomMessage.DefaultMessage, TrsGuaranteeGuasDto.ToPagingAndSorting(query), TrsGuaranteeGuasDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsGuaranteeGua = await _unitOfWork.TrsGuaranteeGuaRepository.GetByIdAsync(id);

            if (TrsGuaranteeGua is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsGuaranteeGuaDto = Mapper.Map(TrsGuaranteeGua);

            return OkResult( CustomMessage.DefaultMessage , TrsGuaranteeGuaDto);

        }
    }
}
