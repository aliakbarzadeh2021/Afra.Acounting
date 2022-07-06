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

namespace Afra.Api.Controllers.InvFormTypesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvFormTypesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvFormTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvFormTypesCommand command)
        {
            command.Validate();

            var InvFormTypess = await _unitOfWork.InvFormTypesRepository.FindAsync(c => c.Id == command.Id);

            if (InvFormTypess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvFormTypes = Mapper.Map(command);
            await _unitOfWork.InvFormTypesRepository.AddAsync(newInvFormTypes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvFormTypesCommand command)
        {

            command.Validate();

            var InvFormTypes = await _unitOfWork.InvFormTypesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvFormTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvFormTypes = Mapper.Map(InvFormTypes, command);
            InvFormTypes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvFormTypes = await _unitOfWork.InvFormTypesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvFormTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvFormTypes.IsActive = false;
            InvFormTypes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvFormTypess = await _unitOfWork.InvFormTypesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvFormTypessDto = Mapper.Map(InvFormTypess);

            return OkResult(CustomMessage.DefaultMessage, InvFormTypessDto.ToPagingAndSorting(query), InvFormTypessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvFormTypes = await _unitOfWork.InvFormTypesRepository.GetByIdAsync(id);

            if (InvFormTypes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvFormTypesDto = Mapper.Map(InvFormTypes);

            return OkResult( CustomMessage.DefaultMessage , InvFormTypesDto);

        }
    }
}
