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

namespace Afra.Api.Controllers.AccSLControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccSLController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccSLController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccSLCommand command)
        {
            command.Validate();

            var AccSLs = await _unitOfWork.AccSLRepository.FindAsync(c => c.Id == command.Id);

            if (AccSLs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccSL = Mapper.Map(command);
            await _unitOfWork.AccSLRepository.AddAsync(newAccSL);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccSLCommand command)
        {

            command.Validate();

            var AccSL = await _unitOfWork.AccSLRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccSL == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccSL = Mapper.Map(AccSL, command);
            AccSL.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccSL = await _unitOfWork.AccSLRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccSL == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccSL.IsActive = false;
            AccSL.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccSLs = await _unitOfWork.AccSLRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccSLsDto = Mapper.Map(AccSLs);

            return OkResult(CustomMessage.DefaultMessage, AccSLsDto.ToPagingAndSorting(query), AccSLsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccSL = await _unitOfWork.AccSLRepository.GetByIdAsync(id);

            if (AccSL is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccSLDto = Mapper.Map(AccSL);

            return OkResult( CustomMessage.DefaultMessage , AccSLDto);

        }
    }
}
