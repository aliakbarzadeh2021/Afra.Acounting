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

namespace Afra.Api.Controllers.OtoBaseTypeValsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoBaseTypeValsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoBaseTypeValsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoBaseTypeValsCommand command)
        {
            command.Validate();

            var OtoBaseTypeValss = await _unitOfWork.OtoBaseTypeValsRepository.FindAsync(c => c.Id == command.Id);

            if (OtoBaseTypeValss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoBaseTypeVals = Mapper.Map(command);
            await _unitOfWork.OtoBaseTypeValsRepository.AddAsync(newOtoBaseTypeVals);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoBaseTypeValsCommand command)
        {

            command.Validate();

            var OtoBaseTypeVals = await _unitOfWork.OtoBaseTypeValsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoBaseTypeVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoBaseTypeVals = Mapper.Map(OtoBaseTypeVals, command);
            OtoBaseTypeVals.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoBaseTypeVals = await _unitOfWork.OtoBaseTypeValsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoBaseTypeVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoBaseTypeVals.IsActive = false;
            OtoBaseTypeVals.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoBaseTypeValss = await _unitOfWork.OtoBaseTypeValsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoBaseTypeValssDto = Mapper.Map(OtoBaseTypeValss);

            return OkResult(CustomMessage.DefaultMessage, OtoBaseTypeValssDto.ToPagingAndSorting(query), OtoBaseTypeValssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoBaseTypeVals = await _unitOfWork.OtoBaseTypeValsRepository.GetByIdAsync(id);

            if (OtoBaseTypeVals is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoBaseTypeValsDto = Mapper.Map(OtoBaseTypeVals);

            return OkResult( CustomMessage.DefaultMessage , OtoBaseTypeValsDto);

        }
    }
}
