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

namespace Afra.Api.Controllers.AccPLControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccPLController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccPLController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccPLCommand command)
        {
            command.Validate();

            var AccPLs = await _unitOfWork.AccPLRepository.FindAsync(c => c.Id == command.Id);

            if (AccPLs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccPL = Mapper.Map(command);
            await _unitOfWork.AccPLRepository.AddAsync(newAccPL);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccPLCommand command)
        {

            command.Validate();

            var AccPL = await _unitOfWork.AccPLRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccPL == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccPL = Mapper.Map(AccPL, command);
            AccPL.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccPL = await _unitOfWork.AccPLRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccPL == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccPL.IsActive = false;
            AccPL.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccPLs = await _unitOfWork.AccPLRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccPLsDto = Mapper.Map(AccPLs);

            return OkResult(CustomMessage.DefaultMessage, AccPLsDto.ToPagingAndSorting(query), AccPLsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccPL = await _unitOfWork.AccPLRepository.GetByIdAsync(id);

            if (AccPL is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccPLDto = Mapper.Map(AccPL);

            return OkResult( CustomMessage.DefaultMessage , AccPLDto);

        }
    }
}
