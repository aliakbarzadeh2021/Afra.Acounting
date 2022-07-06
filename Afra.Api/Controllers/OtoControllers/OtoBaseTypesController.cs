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

namespace Afra.Api.Controllers.OtoBaseTypesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoBaseTypesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoBaseTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoBaseTypesCommand command)
        {
            command.Validate();

            var OtoBaseTypess = await _unitOfWork.OtoBaseTypesRepository.FindAsync(c => c.Id == command.Id);

            if (OtoBaseTypess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoBaseTypes = Mapper.Map(command);
            await _unitOfWork.OtoBaseTypesRepository.AddAsync(newOtoBaseTypes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoBaseTypesCommand command)
        {

            command.Validate();

            var OtoBaseTypes = await _unitOfWork.OtoBaseTypesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoBaseTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoBaseTypes = Mapper.Map(OtoBaseTypes, command);
            OtoBaseTypes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoBaseTypes = await _unitOfWork.OtoBaseTypesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoBaseTypes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoBaseTypes.IsActive = false;
            OtoBaseTypes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoBaseTypess = await _unitOfWork.OtoBaseTypesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoBaseTypessDto = Mapper.Map(OtoBaseTypess);

            return OkResult(CustomMessage.DefaultMessage, OtoBaseTypessDto.ToPagingAndSorting(query), OtoBaseTypessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoBaseTypes = await _unitOfWork.OtoBaseTypesRepository.GetByIdAsync(id);

            if (OtoBaseTypes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoBaseTypesDto = Mapper.Map(OtoBaseTypes);

            return OkResult( CustomMessage.DefaultMessage , OtoBaseTypesDto);

        }
    }
}
