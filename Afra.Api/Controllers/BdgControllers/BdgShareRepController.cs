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

namespace Afra.Api.Controllers.BdgShareRepControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgShareRepController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgShareRepController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgShareRepCommand command)
        {
            command.Validate();

            var BdgShareReps = await _unitOfWork.BdgShareRepRepository.FindAsync(c => c.Id == command.Id);

            if (BdgShareReps.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgShareRep = Mapper.Map(command);
            await _unitOfWork.BdgShareRepRepository.AddAsync(newBdgShareRep);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgShareRepCommand command)
        {

            command.Validate();

            var BdgShareRep = await _unitOfWork.BdgShareRepRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgShareRep == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgShareRep = Mapper.Map(BdgShareRep, command);
            BdgShareRep.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgShareRep = await _unitOfWork.BdgShareRepRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgShareRep == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgShareRep.IsActive = false;
            BdgShareRep.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgShareReps = await _unitOfWork.BdgShareRepRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgShareRepsDto = Mapper.Map(BdgShareReps);

            return OkResult(CustomMessage.DefaultMessage, BdgShareRepsDto.ToPagingAndSorting(query), BdgShareRepsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgShareRep = await _unitOfWork.BdgShareRepRepository.GetByIdAsync(id);

            if (BdgShareRep is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgShareRepDto = Mapper.Map(BdgShareRep);

            return OkResult( CustomMessage.DefaultMessage , BdgShareRepDto);

        }
    }
}
