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

namespace Afra.Api.Controllers.InvItmRateDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvItmRateDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvItmRateDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvItmRateDetCommand command)
        {
            command.Validate();

            var InvItmRateDets = await _unitOfWork.InvItmRateDetRepository.FindAsync(c => c.Id == command.Id);

            if (InvItmRateDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvItmRateDet = Mapper.Map(command);
            await _unitOfWork.InvItmRateDetRepository.AddAsync(newInvItmRateDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvItmRateDetCommand command)
        {

            command.Validate();

            var InvItmRateDet = await _unitOfWork.InvItmRateDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvItmRateDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvItmRateDet = Mapper.Map(InvItmRateDet, command);
            InvItmRateDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvItmRateDet = await _unitOfWork.InvItmRateDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvItmRateDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvItmRateDet.IsActive = false;
            InvItmRateDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvItmRateDets = await _unitOfWork.InvItmRateDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvItmRateDetsDto = Mapper.Map(InvItmRateDets);

            return OkResult(CustomMessage.DefaultMessage, InvItmRateDetsDto.ToPagingAndSorting(query), InvItmRateDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvItmRateDet = await _unitOfWork.InvItmRateDetRepository.GetByIdAsync(id);

            if (InvItmRateDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvItmRateDetDto = Mapper.Map(InvItmRateDet);

            return OkResult( CustomMessage.DefaultMessage , InvItmRateDetDto);

        }
    }
}
