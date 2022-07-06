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

namespace Afra.Api.Controllers.PartFrmlOutControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PartFrmlOutController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PartFrmlOutController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPartFrmlOutCommand command)
        {
            command.Validate();

            var PartFrmlOuts = await _unitOfWork.PartFrmlOutRepository.FindAsync(c => c.Id == command.Id);

            if (PartFrmlOuts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPartFrmlOut = Mapper.Map(command);
            await _unitOfWork.PartFrmlOutRepository.AddAsync(newPartFrmlOut);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPartFrmlOutCommand command)
        {

            command.Validate();

            var PartFrmlOut = await _unitOfWork.PartFrmlOutRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PartFrmlOut == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartFrmlOut = Mapper.Map(PartFrmlOut, command);
            PartFrmlOut.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PartFrmlOut = await _unitOfWork.PartFrmlOutRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PartFrmlOut == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartFrmlOut.IsActive = false;
            PartFrmlOut.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PartFrmlOuts = await _unitOfWork.PartFrmlOutRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PartFrmlOutsDto = Mapper.Map(PartFrmlOuts);

            return OkResult(CustomMessage.DefaultMessage, PartFrmlOutsDto.ToPagingAndSorting(query), PartFrmlOutsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PartFrmlOut = await _unitOfWork.PartFrmlOutRepository.GetByIdAsync(id);

            if (PartFrmlOut is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PartFrmlOutDto = Mapper.Map(PartFrmlOut);

            return OkResult( CustomMessage.DefaultMessage , PartFrmlOutDto);

        }
    }
}
