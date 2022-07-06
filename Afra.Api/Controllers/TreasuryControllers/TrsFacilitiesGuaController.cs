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

namespace Afra.Api.Controllers.TrsFacilitiesGuaControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFacilitiesGuaController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFacilitiesGuaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFacilitiesGuaCommand command)
        {
            command.Validate();

            var TrsFacilitiesGuas = await _unitOfWork.TrsFacilitiesGuaRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFacilitiesGuas.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFacilitiesGua = Mapper.Map(command);
            await _unitOfWork.TrsFacilitiesGuaRepository.AddAsync(newTrsFacilitiesGua);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFacilitiesGuaCommand command)
        {

            command.Validate();

            var TrsFacilitiesGua = await _unitOfWork.TrsFacilitiesGuaRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFacilitiesGua == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacilitiesGua = Mapper.Map(TrsFacilitiesGua, command);
            TrsFacilitiesGua.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFacilitiesGua = await _unitOfWork.TrsFacilitiesGuaRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFacilitiesGua == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFacilitiesGua.IsActive = false;
            TrsFacilitiesGua.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFacilitiesGuas = await _unitOfWork.TrsFacilitiesGuaRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFacilitiesGuasDto = Mapper.Map(TrsFacilitiesGuas);

            return OkResult(CustomMessage.DefaultMessage, TrsFacilitiesGuasDto.ToPagingAndSorting(query), TrsFacilitiesGuasDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFacilitiesGua = await _unitOfWork.TrsFacilitiesGuaRepository.GetByIdAsync(id);

            if (TrsFacilitiesGua is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFacilitiesGuaDto = Mapper.Map(TrsFacilitiesGua);

            return OkResult( CustomMessage.DefaultMessage , TrsFacilitiesGuaDto);

        }
    }
}
