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

namespace Afra.Api.Controllers.PartFrmlMachControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PartFrmlMachController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PartFrmlMachController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPartFrmlMachCommand command)
        {
            command.Validate();

            var PartFrmlMachs = await _unitOfWork.PartFrmlMachRepository.FindAsync(c => c.Id == command.Id);

            if (PartFrmlMachs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPartFrmlMach = Mapper.Map(command);
            await _unitOfWork.PartFrmlMachRepository.AddAsync(newPartFrmlMach);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPartFrmlMachCommand command)
        {

            command.Validate();

            var PartFrmlMach = await _unitOfWork.PartFrmlMachRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PartFrmlMach == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartFrmlMach = Mapper.Map(PartFrmlMach, command);
            PartFrmlMach.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PartFrmlMach = await _unitOfWork.PartFrmlMachRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PartFrmlMach == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartFrmlMach.IsActive = false;
            PartFrmlMach.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PartFrmlMachs = await _unitOfWork.PartFrmlMachRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PartFrmlMachsDto = Mapper.Map(PartFrmlMachs);

            return OkResult(CustomMessage.DefaultMessage, PartFrmlMachsDto.ToPagingAndSorting(query), PartFrmlMachsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PartFrmlMach = await _unitOfWork.PartFrmlMachRepository.GetByIdAsync(id);

            if (PartFrmlMach is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PartFrmlMachDto = Mapper.Map(PartFrmlMach);

            return OkResult( CustomMessage.DefaultMessage , PartFrmlMachDto);

        }
    }
}
