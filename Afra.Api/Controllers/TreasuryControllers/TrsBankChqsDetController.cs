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

namespace Afra.Api.Controllers.TrsBankChqsDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsBankChqsDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsBankChqsDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsBankChqsDetCommand command)
        {
            command.Validate();

            var TrsBankChqsDets = await _unitOfWork.TrsBankChqsDetRepository.FindAsync(c => c.Id == command.Id);

            if (TrsBankChqsDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsBankChqsDet = Mapper.Map(command);
            await _unitOfWork.TrsBankChqsDetRepository.AddAsync(newTrsBankChqsDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsBankChqsDetCommand command)
        {

            command.Validate();

            var TrsBankChqsDet = await _unitOfWork.TrsBankChqsDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsBankChqsDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankChqsDet = Mapper.Map(TrsBankChqsDet, command);
            TrsBankChqsDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsBankChqsDet = await _unitOfWork.TrsBankChqsDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsBankChqsDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsBankChqsDet.IsActive = false;
            TrsBankChqsDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsBankChqsDets = await _unitOfWork.TrsBankChqsDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsBankChqsDetsDto = Mapper.Map(TrsBankChqsDets);

            return OkResult(CustomMessage.DefaultMessage, TrsBankChqsDetsDto.ToPagingAndSorting(query), TrsBankChqsDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsBankChqsDet = await _unitOfWork.TrsBankChqsDetRepository.GetByIdAsync(id);

            if (TrsBankChqsDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsBankChqsDetDto = Mapper.Map(TrsBankChqsDet);

            return OkResult( CustomMessage.DefaultMessage , TrsBankChqsDetDto);

        }
    }
}
