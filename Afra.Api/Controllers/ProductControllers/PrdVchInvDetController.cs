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

namespace Afra.Api.Controllers.PrdVchInvDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdVchInvDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdVchInvDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdVchInvDetCommand command)
        {
            command.Validate();

            var PrdVchInvDets = await _unitOfWork.PrdVchInvDetRepository.FindAsync(c => c.Id == command.Id);

            if (PrdVchInvDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdVchInvDet = Mapper.Map(command);
            await _unitOfWork.PrdVchInvDetRepository.AddAsync(newPrdVchInvDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdVchInvDetCommand command)
        {

            command.Validate();

            var PrdVchInvDet = await _unitOfWork.PrdVchInvDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdVchInvDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdVchInvDet = Mapper.Map(PrdVchInvDet, command);
            PrdVchInvDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdVchInvDet = await _unitOfWork.PrdVchInvDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdVchInvDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdVchInvDet.IsActive = false;
            PrdVchInvDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdVchInvDets = await _unitOfWork.PrdVchInvDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdVchInvDetsDto = Mapper.Map(PrdVchInvDets);

            return OkResult(CustomMessage.DefaultMessage, PrdVchInvDetsDto.ToPagingAndSorting(query), PrdVchInvDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdVchInvDet = await _unitOfWork.PrdVchInvDetRepository.GetByIdAsync(id);

            if (PrdVchInvDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdVchInvDetDto = Mapper.Map(PrdVchInvDet);

            return OkResult( CustomMessage.DefaultMessage , PrdVchInvDetDto);

        }
    }
}
