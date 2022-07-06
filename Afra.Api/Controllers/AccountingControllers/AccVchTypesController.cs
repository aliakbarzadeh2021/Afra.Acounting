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

namespace Afra.Api.Controllers.AccVchTypesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccVchTypesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccVchTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccVchTypesCommand command)
        {
            command.Validate();

            var AccVchTypess = await _unitOfWork.AccVchTypesRepository.FindAsync(c => c.Id == command.Id);

            if (AccVchTypess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccVchTypes = Mapper.Map(command);
            await _unitOfWork.AccVchTypesRepository.AddAsync(newAccVchTypes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccVchTypesCommand command)
        {

            command.Validate();

            var AccVchTypes = await _unitOfWork.AccVchTypesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccVchTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccVchTypes = Mapper.Map(AccVchTypes, command);
            AccVchTypes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccVchTypes = await _unitOfWork.AccVchTypesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccVchTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccVchTypes.IsActive = false;
            AccVchTypes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccVchTypess = await _unitOfWork.AccVchTypesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccVchTypessDto = Mapper.Map(AccVchTypess);

            return OkResult(CustomMessage.DefaultMessage, AccVchTypessDto.ToPagingAndSorting(query), AccVchTypessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccVchTypes = await _unitOfWork.AccVchTypesRepository.GetByIdAsync(id);

            if (AccVchTypes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccVchTypesDto = Mapper.Map(AccVchTypes);

            return OkResult( CustomMessage.DefaultMessage , AccVchTypesDto);

        }
    }
}
