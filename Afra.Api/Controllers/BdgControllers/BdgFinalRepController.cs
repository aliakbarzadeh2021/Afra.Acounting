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

namespace Afra.Api.Controllers.BdgFinalRepControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgFinalRepController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgFinalRepController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgFinalRepCommand command)
        {
            command.Validate();

            var BdgFinalReps = await _unitOfWork.BdgFinalRepRepository.FindAsync(c => c.Id == command.Id);

            if (BdgFinalReps.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgFinalRep = Mapper.Map(command);
            await _unitOfWork.BdgFinalRepRepository.AddAsync(newBdgFinalRep);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgFinalRepCommand command)
        {

            command.Validate();

            var BdgFinalRep = await _unitOfWork.BdgFinalRepRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgFinalRep == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgFinalRep = Mapper.Map(BdgFinalRep, command);
            BdgFinalRep.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgFinalRep = await _unitOfWork.BdgFinalRepRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgFinalRep == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgFinalRep.IsActive = false;
            BdgFinalRep.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgFinalReps = await _unitOfWork.BdgFinalRepRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgFinalRepsDto = Mapper.Map(BdgFinalReps);

            return OkResult(CustomMessage.DefaultMessage, BdgFinalRepsDto.ToPagingAndSorting(query), BdgFinalRepsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgFinalRep = await _unitOfWork.BdgFinalRepRepository.GetByIdAsync(id);

            if (BdgFinalRep is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgFinalRepDto = Mapper.Map(BdgFinalRep);

            return OkResult( CustomMessage.DefaultMessage , BdgFinalRepDto);

        }
    }
}
