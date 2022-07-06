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

namespace Afra.Api.Controllers.BdgLevelDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgLevelDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgLevelDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgLevelDetCommand command)
        {
            command.Validate();

            var BdgLevelDets = await _unitOfWork.BdgLevelDetRepository.FindAsync(c => c.Id == command.Id);

            if (BdgLevelDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgLevelDet = Mapper.Map(command);
            await _unitOfWork.BdgLevelDetRepository.AddAsync(newBdgLevelDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgLevelDetCommand command)
        {

            command.Validate();

            var BdgLevelDet = await _unitOfWork.BdgLevelDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgLevelDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgLevelDet = Mapper.Map(BdgLevelDet, command);
            BdgLevelDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgLevelDet = await _unitOfWork.BdgLevelDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgLevelDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgLevelDet.IsActive = false;
            BdgLevelDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgLevelDets = await _unitOfWork.BdgLevelDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgLevelDetsDto = Mapper.Map(BdgLevelDets);

            return OkResult(CustomMessage.DefaultMessage, BdgLevelDetsDto.ToPagingAndSorting(query), BdgLevelDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgLevelDet = await _unitOfWork.BdgLevelDetRepository.GetByIdAsync(id);

            if (BdgLevelDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgLevelDetDto = Mapper.Map(BdgLevelDet);

            return OkResult( CustomMessage.DefaultMessage , BdgLevelDetDto);

        }
    }
}
