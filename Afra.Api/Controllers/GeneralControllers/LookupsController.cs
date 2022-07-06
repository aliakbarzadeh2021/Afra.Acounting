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

namespace Afra.Api.Controllers.LookupsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class LookupsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public LookupsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddLookupsCommand command)
        {
            command.Validate();

            var Lookupss = await _unitOfWork.LookupsRepository.FindAsync(c => c.Id == command.Id);

            if (Lookupss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newLookups = Mapper.Map(command);
            await _unitOfWork.LookupsRepository.AddAsync(newLookups);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditLookupsCommand command)
        {

            command.Validate();

            var Lookups = await _unitOfWork.LookupsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Lookups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Lookups = Mapper.Map(Lookups, command);
            Lookups.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Lookups = await _unitOfWork.LookupsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Lookups == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Lookups.IsActive = false;
            Lookups.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Lookupss = await _unitOfWork.LookupsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var LookupssDto = Mapper.Map(Lookupss);

            return OkResult(CustomMessage.DefaultMessage, LookupssDto.ToPagingAndSorting(query), LookupssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Lookups = await _unitOfWork.LookupsRepository.GetByIdAsync(id);

            if (Lookups is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var LookupsDto = Mapper.Map(Lookups);

            return OkResult( CustomMessage.DefaultMessage , LookupsDto);

        }
    }
}
