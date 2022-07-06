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

namespace Afra.Api.Controllers.InvVchTypesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvVchTypesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvVchTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvVchTypesCommand command)
        {
            command.Validate();

            var InvVchTypess = await _unitOfWork.InvVchTypesRepository.FindAsync(c => c.Id == command.Id);

            if (InvVchTypess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvVchTypes = Mapper.Map(command);
            await _unitOfWork.InvVchTypesRepository.AddAsync(newInvVchTypes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvVchTypesCommand command)
        {

            command.Validate();

            var InvVchTypes = await _unitOfWork.InvVchTypesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvVchTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvVchTypes = Mapper.Map(InvVchTypes, command);
            InvVchTypes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvVchTypes = await _unitOfWork.InvVchTypesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvVchTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvVchTypes.IsActive = false;
            InvVchTypes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvVchTypess = await _unitOfWork.InvVchTypesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvVchTypessDto = Mapper.Map(InvVchTypess);

            return OkResult(CustomMessage.DefaultMessage, InvVchTypessDto.ToPagingAndSorting(query), InvVchTypessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvVchTypes = await _unitOfWork.InvVchTypesRepository.GetByIdAsync(id);

            if (InvVchTypes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvVchTypesDto = Mapper.Map(InvVchTypes);

            return OkResult( CustomMessage.DefaultMessage , InvVchTypesDto);

        }
    }
}
