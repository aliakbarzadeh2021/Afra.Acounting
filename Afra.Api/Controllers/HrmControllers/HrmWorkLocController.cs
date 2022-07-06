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

namespace Afra.Api.Controllers.HrmWorkLocControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmWorkLocController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmWorkLocController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmWorkLocCommand command)
        {
            command.Validate();

            var HrmWorkLocs = await _unitOfWork.HrmWorkLocRepository.FindAsync(c => c.Id == command.Id);

            if (HrmWorkLocs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmWorkLoc = Mapper.Map(command);
            await _unitOfWork.HrmWorkLocRepository.AddAsync(newHrmWorkLoc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmWorkLocCommand command)
        {

            command.Validate();

            var HrmWorkLoc = await _unitOfWork.HrmWorkLocRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmWorkLoc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmWorkLoc = Mapper.Map(HrmWorkLoc, command);
            HrmWorkLoc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmWorkLoc = await _unitOfWork.HrmWorkLocRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmWorkLoc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmWorkLoc.IsActive = false;
            HrmWorkLoc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmWorkLocs = await _unitOfWork.HrmWorkLocRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmWorkLocsDto = Mapper.Map(HrmWorkLocs);

            return OkResult(CustomMessage.DefaultMessage, HrmWorkLocsDto.ToPagingAndSorting(query), HrmWorkLocsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmWorkLoc = await _unitOfWork.HrmWorkLocRepository.GetByIdAsync(id);

            if (HrmWorkLoc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmWorkLocDto = Mapper.Map(HrmWorkLoc);

            return OkResult( CustomMessage.DefaultMessage , HrmWorkLocDto);

        }
    }
}
