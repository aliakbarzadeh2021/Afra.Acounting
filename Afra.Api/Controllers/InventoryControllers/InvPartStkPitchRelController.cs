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

namespace Afra.Api.Controllers.InvPartStkPitchRelControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvPartStkPitchRelController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvPartStkPitchRelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvPartStkPitchRelCommand command)
        {
            command.Validate();

            var InvPartStkPitchRels = await _unitOfWork.InvPartStkPitchRelRepository.FindAsync(c => c.Id == command.Id);

            if (InvPartStkPitchRels.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvPartStkPitchRel = Mapper.Map(command);
            await _unitOfWork.InvPartStkPitchRelRepository.AddAsync(newInvPartStkPitchRel);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvPartStkPitchRelCommand command)
        {

            command.Validate();

            var InvPartStkPitchRel = await _unitOfWork.InvPartStkPitchRelRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvPartStkPitchRel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartStkPitchRel = Mapper.Map(InvPartStkPitchRel, command);
            InvPartStkPitchRel.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvPartStkPitchRel = await _unitOfWork.InvPartStkPitchRelRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvPartStkPitchRel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartStkPitchRel.IsActive = false;
            InvPartStkPitchRel.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvPartStkPitchRels = await _unitOfWork.InvPartStkPitchRelRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvPartStkPitchRelsDto = Mapper.Map(InvPartStkPitchRels);

            return OkResult(CustomMessage.DefaultMessage, InvPartStkPitchRelsDto.ToPagingAndSorting(query), InvPartStkPitchRelsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvPartStkPitchRel = await _unitOfWork.InvPartStkPitchRelRepository.GetByIdAsync(id);

            if (InvPartStkPitchRel is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvPartStkPitchRelDto = Mapper.Map(InvPartStkPitchRel);

            return OkResult( CustomMessage.DefaultMessage , InvPartStkPitchRelDto);

        }
    }
}
