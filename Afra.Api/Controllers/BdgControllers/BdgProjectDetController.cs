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

namespace Afra.Api.Controllers.BdgProjectDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgProjectDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgProjectDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgProjectDetCommand command)
        {
            command.Validate();

            var BdgProjectDets = await _unitOfWork.BdgProjectDetRepository.FindAsync(c => c.Id == command.Id);

            if (BdgProjectDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgProjectDet = Mapper.Map(command);
            await _unitOfWork.BdgProjectDetRepository.AddAsync(newBdgProjectDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgProjectDetCommand command)
        {

            command.Validate();

            var BdgProjectDet = await _unitOfWork.BdgProjectDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgProjectDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProjectDet = Mapper.Map(BdgProjectDet, command);
            BdgProjectDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgProjectDet = await _unitOfWork.BdgProjectDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgProjectDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProjectDet.IsActive = false;
            BdgProjectDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgProjectDets = await _unitOfWork.BdgProjectDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgProjectDetsDto = Mapper.Map(BdgProjectDets);

            return OkResult(CustomMessage.DefaultMessage, BdgProjectDetsDto.ToPagingAndSorting(query), BdgProjectDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgProjectDet = await _unitOfWork.BdgProjectDetRepository.GetByIdAsync(id);

            if (BdgProjectDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgProjectDetDto = Mapper.Map(BdgProjectDet);

            return OkResult( CustomMessage.DefaultMessage , BdgProjectDetDto);

        }
    }
}
