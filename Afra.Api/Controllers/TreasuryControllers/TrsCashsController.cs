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

namespace Afra.Api.Controllers.TrsCashsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsCashsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsCashsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsCashsCommand command)
        {
            command.Validate();

            var TrsCashss = await _unitOfWork.TrsCashsRepository.FindAsync(c => c.Id == command.Id);

            if (TrsCashss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsCashs = Mapper.Map(command);
            await _unitOfWork.TrsCashsRepository.AddAsync(newTrsCashs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsCashsCommand command)
        {

            command.Validate();

            var TrsCashs = await _unitOfWork.TrsCashsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsCashs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsCashs = Mapper.Map(TrsCashs, command);
            TrsCashs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsCashs = await _unitOfWork.TrsCashsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsCashs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsCashs.IsActive = false;
            TrsCashs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsCashss = await _unitOfWork.TrsCashsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsCashssDto = Mapper.Map(TrsCashss);

            return OkResult(CustomMessage.DefaultMessage, TrsCashssDto.ToPagingAndSorting(query), TrsCashssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsCashs = await _unitOfWork.TrsCashsRepository.GetByIdAsync(id);

            if (TrsCashs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsCashsDto = Mapper.Map(TrsCashs);

            return OkResult( CustomMessage.DefaultMessage , TrsCashsDto);

        }
    }
}
