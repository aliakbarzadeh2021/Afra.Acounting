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

namespace Afra.Api.Controllers.GnrProcessDetValsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrProcessDetValsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrProcessDetValsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrProcessDetValsCommand command)
        {
            command.Validate();

            var GnrProcessDetValss = await _unitOfWork.GnrProcessDetValsRepository.FindAsync(c => c.Id == command.Id);

            if (GnrProcessDetValss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrProcessDetVals = Mapper.Map(command);
            await _unitOfWork.GnrProcessDetValsRepository.AddAsync(newGnrProcessDetVals);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrProcessDetValsCommand command)
        {

            command.Validate();

            var GnrProcessDetVals = await _unitOfWork.GnrProcessDetValsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrProcessDetVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrProcessDetVals = Mapper.Map(GnrProcessDetVals, command);
            GnrProcessDetVals.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrProcessDetVals = await _unitOfWork.GnrProcessDetValsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrProcessDetVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrProcessDetVals.IsActive = false;
            GnrProcessDetVals.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrProcessDetValss = await _unitOfWork.GnrProcessDetValsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrProcessDetValssDto = Mapper.Map(GnrProcessDetValss);

            return OkResult(CustomMessage.DefaultMessage, GnrProcessDetValssDto.ToPagingAndSorting(query), GnrProcessDetValssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrProcessDetVals = await _unitOfWork.GnrProcessDetValsRepository.GetByIdAsync(id);

            if (GnrProcessDetVals is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrProcessDetValsDto = Mapper.Map(GnrProcessDetVals);

            return OkResult( CustomMessage.DefaultMessage , GnrProcessDetValsDto);

        }
    }
}
