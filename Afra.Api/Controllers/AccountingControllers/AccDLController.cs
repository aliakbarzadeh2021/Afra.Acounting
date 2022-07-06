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

namespace Afra.Api.Controllers.AccDLControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccDLController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccDLController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccDLCommand command)
        {
            command.Validate();

            var AccDLs = await _unitOfWork.AccDLRepository.FindAsync(c => c.Id == command.Id);

            if (AccDLs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccDL = Mapper.Map(command);
            await _unitOfWork.AccDLRepository.AddAsync(newAccDL);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccDLCommand command)
        {

            command.Validate();

            var AccDL = await _unitOfWork.AccDLRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccDL == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccDL = Mapper.Map(AccDL, command);
            AccDL.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccDL = await _unitOfWork.AccDLRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccDL == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccDL.IsActive = false;
            AccDL.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccDLs = await _unitOfWork.AccDLRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccDLsDto = Mapper.Map(AccDLs);

            return OkResult(CustomMessage.DefaultMessage, AccDLsDto.ToPagingAndSorting(query), AccDLsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccDL = await _unitOfWork.AccDLRepository.GetByIdAsync(id);

            if (AccDL is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccDLDto = Mapper.Map(AccDL);

            return OkResult( CustomMessage.DefaultMessage , AccDLDto);

        }
    }
}
