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

namespace Afra.Api.Controllers.TrsFundItmDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFundItmDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFundItmDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFundItmDetCommand command)
        {
            command.Validate();

            var TrsFundItmDets = await _unitOfWork.TrsFundItmDetRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFundItmDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFundItmDet = Mapper.Map(command);
            await _unitOfWork.TrsFundItmDetRepository.AddAsync(newTrsFundItmDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFundItmDetCommand command)
        {

            command.Validate();

            var TrsFundItmDet = await _unitOfWork.TrsFundItmDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFundItmDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFundItmDet = Mapper.Map(TrsFundItmDet, command);
            TrsFundItmDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFundItmDet = await _unitOfWork.TrsFundItmDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFundItmDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFundItmDet.IsActive = false;
            TrsFundItmDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFundItmDets = await _unitOfWork.TrsFundItmDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFundItmDetsDto = Mapper.Map(TrsFundItmDets);

            return OkResult(CustomMessage.DefaultMessage, TrsFundItmDetsDto.ToPagingAndSorting(query), TrsFundItmDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFundItmDet = await _unitOfWork.TrsFundItmDetRepository.GetByIdAsync(id);

            if (TrsFundItmDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFundItmDetDto = Mapper.Map(TrsFundItmDet);

            return OkResult( CustomMessage.DefaultMessage , TrsFundItmDetDto);

        }
    }
}
