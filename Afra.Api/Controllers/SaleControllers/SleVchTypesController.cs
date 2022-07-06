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

namespace Afra.Api.Controllers.SleVchTypesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleVchTypesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleVchTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleVchTypesCommand command)
        {
            command.Validate();

            var SleVchTypess = await _unitOfWork.SleVchTypesRepository.FindAsync(c => c.Id == command.Id);

            if (SleVchTypess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleVchTypes = Mapper.Map(command);
            await _unitOfWork.SleVchTypesRepository.AddAsync(newSleVchTypes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleVchTypesCommand command)
        {

            command.Validate();

            var SleVchTypes = await _unitOfWork.SleVchTypesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleVchTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleVchTypes = Mapper.Map(SleVchTypes, command);
            SleVchTypes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleVchTypes = await _unitOfWork.SleVchTypesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleVchTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleVchTypes.IsActive = false;
            SleVchTypes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleVchTypess = await _unitOfWork.SleVchTypesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleVchTypessDto = Mapper.Map(SleVchTypess);

            return OkResult(CustomMessage.DefaultMessage, SleVchTypessDto.ToPagingAndSorting(query), SleVchTypessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleVchTypes = await _unitOfWork.SleVchTypesRepository.GetByIdAsync(id);

            if (SleVchTypes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleVchTypesDto = Mapper.Map(SleVchTypes);

            return OkResult( CustomMessage.DefaultMessage , SleVchTypesDto);

        }
    }
}
