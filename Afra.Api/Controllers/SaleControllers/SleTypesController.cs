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

namespace Afra.Api.Controllers.SleTypesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleTypesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleTypesCommand command)
        {
            command.Validate();

            var SleTypess = await _unitOfWork.SleTypesRepository.FindAsync(c => c.Id == command.Id);

            if (SleTypess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleTypes = Mapper.Map(command);
            await _unitOfWork.SleTypesRepository.AddAsync(newSleTypes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleTypesCommand command)
        {

            command.Validate();

            var SleTypes = await _unitOfWork.SleTypesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleTypes = Mapper.Map(SleTypes, command);
            SleTypes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleTypes = await _unitOfWork.SleTypesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleTypes.IsActive = false;
            SleTypes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleTypess = await _unitOfWork.SleTypesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleTypessDto = Mapper.Map(SleTypess);

            return OkResult(CustomMessage.DefaultMessage, SleTypessDto.ToPagingAndSorting(query), SleTypessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleTypes = await _unitOfWork.SleTypesRepository.GetByIdAsync(id);

            if (SleTypes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleTypesDto = Mapper.Map(SleTypes);

            return OkResult( CustomMessage.DefaultMessage , SleTypesDto);

        }
    }
}
