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

namespace Afra.Api.Controllers.BdgContAccDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgContAccDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgContAccDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgContAccDetCommand command)
        {
            command.Validate();

            var BdgContAccDets = await _unitOfWork.BdgContAccDetRepository.FindAsync(c => c.Id == command.Id);

            if (BdgContAccDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgContAccDet = Mapper.Map(command);
            await _unitOfWork.BdgContAccDetRepository.AddAsync(newBdgContAccDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgContAccDetCommand command)
        {

            command.Validate();

            var BdgContAccDet = await _unitOfWork.BdgContAccDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgContAccDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgContAccDet = Mapper.Map(BdgContAccDet, command);
            BdgContAccDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgContAccDet = await _unitOfWork.BdgContAccDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgContAccDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgContAccDet.IsActive = false;
            BdgContAccDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgContAccDets = await _unitOfWork.BdgContAccDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgContAccDetsDto = Mapper.Map(BdgContAccDets);

            return OkResult(CustomMessage.DefaultMessage, BdgContAccDetsDto.ToPagingAndSorting(query), BdgContAccDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgContAccDet = await _unitOfWork.BdgContAccDetRepository.GetByIdAsync(id);

            if (BdgContAccDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgContAccDetDto = Mapper.Map(BdgContAccDet);

            return OkResult( CustomMessage.DefaultMessage , BdgContAccDetDto);

        }
    }
}
