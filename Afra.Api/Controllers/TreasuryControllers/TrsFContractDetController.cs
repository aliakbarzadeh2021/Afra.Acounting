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

namespace Afra.Api.Controllers.TrsFContractDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFContractDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFContractDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFContractDetCommand command)
        {
            command.Validate();

            var TrsFContractDets = await _unitOfWork.TrsFContractDetRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFContractDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFContractDet = Mapper.Map(command);
            await _unitOfWork.TrsFContractDetRepository.AddAsync(newTrsFContractDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFContractDetCommand command)
        {

            command.Validate();

            var TrsFContractDet = await _unitOfWork.TrsFContractDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFContractDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFContractDet = Mapper.Map(TrsFContractDet, command);
            TrsFContractDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFContractDet = await _unitOfWork.TrsFContractDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFContractDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFContractDet.IsActive = false;
            TrsFContractDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFContractDets = await _unitOfWork.TrsFContractDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFContractDetsDto = Mapper.Map(TrsFContractDets);

            return OkResult(CustomMessage.DefaultMessage, TrsFContractDetsDto.ToPagingAndSorting(query), TrsFContractDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFContractDet = await _unitOfWork.TrsFContractDetRepository.GetByIdAsync(id);

            if (TrsFContractDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFContractDetDto = Mapper.Map(TrsFContractDet);

            return OkResult( CustomMessage.DefaultMessage , TrsFContractDetDto);

        }
    }
}
