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

namespace Afra.Api.Controllers.TrsVchItmRelControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsVchItmRelController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsVchItmRelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsVchItmRelCommand command)
        {
            command.Validate();

            var TrsVchItmRels = await _unitOfWork.TrsVchItmRelRepository.FindAsync(c => c.Id == command.Id);

            if (TrsVchItmRels.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsVchItmRel = Mapper.Map(command);
            await _unitOfWork.TrsVchItmRelRepository.AddAsync(newTrsVchItmRel);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsVchItmRelCommand command)
        {

            command.Validate();

            var TrsVchItmRel = await _unitOfWork.TrsVchItmRelRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsVchItmRel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsVchItmRel = Mapper.Map(TrsVchItmRel, command);
            TrsVchItmRel.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsVchItmRel = await _unitOfWork.TrsVchItmRelRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsVchItmRel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsVchItmRel.IsActive = false;
            TrsVchItmRel.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsVchItmRels = await _unitOfWork.TrsVchItmRelRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsVchItmRelsDto = Mapper.Map(TrsVchItmRels);

            return OkResult(CustomMessage.DefaultMessage, TrsVchItmRelsDto.ToPagingAndSorting(query), TrsVchItmRelsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsVchItmRel = await _unitOfWork.TrsVchItmRelRepository.GetByIdAsync(id);

            if (TrsVchItmRel is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsVchItmRelDto = Mapper.Map(TrsVchItmRel);

            return OkResult( CustomMessage.DefaultMessage , TrsVchItmRelDto);

        }
    }
}
