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

namespace Afra.Api.Controllers.TrsBankChqsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsBankChqsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsBankChqsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsBankChqsCommand command)
        {
            command.Validate();

            var TrsBankChqss = await _unitOfWork.TrsBankChqsRepository.FindAsync(c => c.Id == command.Id);

            if (TrsBankChqss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsBankChqs = Mapper.Map(command);
            await _unitOfWork.TrsBankChqsRepository.AddAsync(newTrsBankChqs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsBankChqsCommand command)
        {

            command.Validate();

            var TrsBankChqs = await _unitOfWork.TrsBankChqsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsBankChqs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankChqs = Mapper.Map(TrsBankChqs, command);
            TrsBankChqs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsBankChqs = await _unitOfWork.TrsBankChqsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsBankChqs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankChqs.IsActive = false;
            TrsBankChqs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsBankChqss = await _unitOfWork.TrsBankChqsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsBankChqssDto = Mapper.Map(TrsBankChqss);

            return OkResult(CustomMessage.DefaultMessage, TrsBankChqssDto.ToPagingAndSorting(query), TrsBankChqssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsBankChqs = await _unitOfWork.TrsBankChqsRepository.GetByIdAsync(id);

            if (TrsBankChqs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsBankChqsDto = Mapper.Map(TrsBankChqs);

            return OkResult( CustomMessage.DefaultMessage , TrsBankChqsDto);

        }
    }
}
