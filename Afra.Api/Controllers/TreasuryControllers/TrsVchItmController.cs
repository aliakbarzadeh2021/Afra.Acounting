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

namespace Afra.Api.Controllers.TrsVchItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsVchItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsVchItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsVchItmCommand command)
        {
            command.Validate();

            var TrsVchItms = await _unitOfWork.TrsVchItmRepository.FindAsync(c => c.Id == command.Id);

            if (TrsVchItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsVchItm = Mapper.Map(command);
            await _unitOfWork.TrsVchItmRepository.AddAsync(newTrsVchItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsVchItmCommand command)
        {

            command.Validate();

            var TrsVchItm = await _unitOfWork.TrsVchItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsVchItm = Mapper.Map(TrsVchItm, command);
            TrsVchItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsVchItm = await _unitOfWork.TrsVchItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsVchItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsVchItm.IsActive = false;
            TrsVchItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsVchItms = await _unitOfWork.TrsVchItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsVchItmsDto = Mapper.Map(TrsVchItms);

            return OkResult(CustomMessage.DefaultMessage, TrsVchItmsDto.ToPagingAndSorting(query), TrsVchItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsVchItm = await _unitOfWork.TrsVchItmRepository.GetByIdAsync(id);

            if (TrsVchItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsVchItmDto = Mapper.Map(TrsVchItm);

            return OkResult( CustomMessage.DefaultMessage , TrsVchItmDto);

        }
    }
}
