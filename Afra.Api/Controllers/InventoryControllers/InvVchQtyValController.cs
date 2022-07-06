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

namespace Afra.Api.Controllers.InvVchQtyValControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvVchQtyValController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvVchQtyValController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvVchQtyValCommand command)
        {
            command.Validate();

            var InvVchQtyVals = await _unitOfWork.InvVchQtyValRepository.FindAsync(c => c.Id == command.Id);

            if (InvVchQtyVals.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvVchQtyVal = Mapper.Map(command);
            await _unitOfWork.InvVchQtyValRepository.AddAsync(newInvVchQtyVal);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvVchQtyValCommand command)
        {

            command.Validate();

            var InvVchQtyVal = await _unitOfWork.InvVchQtyValRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvVchQtyVal == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvVchQtyVal = Mapper.Map(InvVchQtyVal, command);
            InvVchQtyVal.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvVchQtyVal = await _unitOfWork.InvVchQtyValRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvVchQtyVal == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvVchQtyVal.IsActive = false;
            InvVchQtyVal.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvVchQtyVals = await _unitOfWork.InvVchQtyValRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvVchQtyValsDto = Mapper.Map(InvVchQtyVals);

            return OkResult(CustomMessage.DefaultMessage, InvVchQtyValsDto.ToPagingAndSorting(query), InvVchQtyValsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvVchQtyVal = await _unitOfWork.InvVchQtyValRepository.GetByIdAsync(id);

            if (InvVchQtyVal is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvVchQtyValDto = Mapper.Map(InvVchQtyVal);

            return OkResult( CustomMessage.DefaultMessage , InvVchQtyValDto);

        }
    }
}
