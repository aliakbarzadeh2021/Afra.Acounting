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

namespace Afra.Api.Controllers.InvPartGrpRelControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvPartGrpRelController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvPartGrpRelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvPartGrpRelCommand command)
        {
            command.Validate();

            var InvPartGrpRels = await _unitOfWork.InvPartGrpRelRepository.FindAsync(c => c.Id == command.Id);

            if (InvPartGrpRels.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvPartGrpRel = Mapper.Map(command);
            await _unitOfWork.InvPartGrpRelRepository.AddAsync(newInvPartGrpRel);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvPartGrpRelCommand command)
        {

            command.Validate();

            var InvPartGrpRel = await _unitOfWork.InvPartGrpRelRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvPartGrpRel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartGrpRel = Mapper.Map(InvPartGrpRel, command);
            InvPartGrpRel.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvPartGrpRel = await _unitOfWork.InvPartGrpRelRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvPartGrpRel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartGrpRel.IsActive = false;
            InvPartGrpRel.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvPartGrpRels = await _unitOfWork.InvPartGrpRelRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvPartGrpRelsDto = Mapper.Map(InvPartGrpRels);

            return OkResult(CustomMessage.DefaultMessage, InvPartGrpRelsDto.ToPagingAndSorting(query), InvPartGrpRelsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvPartGrpRel = await _unitOfWork.InvPartGrpRelRepository.GetByIdAsync(id);

            if (InvPartGrpRel is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvPartGrpRelDto = Mapper.Map(InvPartGrpRel);

            return OkResult( CustomMessage.DefaultMessage , InvPartGrpRelDto);

        }
    }
}
