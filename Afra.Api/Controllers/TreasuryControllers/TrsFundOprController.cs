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

namespace Afra.Api.Controllers.TrsFundOprControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFundOprController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFundOprController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFundOprCommand command)
        {
            command.Validate();

            var TrsFundOprs = await _unitOfWork.TrsFundOprRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFundOprs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFundOpr = Mapper.Map(command);
            await _unitOfWork.TrsFundOprRepository.AddAsync(newTrsFundOpr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFundOprCommand command)
        {

            command.Validate();

            var TrsFundOpr = await _unitOfWork.TrsFundOprRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFundOpr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFundOpr = Mapper.Map(TrsFundOpr, command);
            TrsFundOpr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFundOpr = await _unitOfWork.TrsFundOprRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFundOpr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFundOpr.IsActive = false;
            TrsFundOpr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFundOprs = await _unitOfWork.TrsFundOprRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFundOprsDto = Mapper.Map(TrsFundOprs);

            return OkResult(CustomMessage.DefaultMessage, TrsFundOprsDto.ToPagingAndSorting(query), TrsFundOprsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFundOpr = await _unitOfWork.TrsFundOprRepository.GetByIdAsync(id);

            if (TrsFundOpr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFundOprDto = Mapper.Map(TrsFundOpr);

            return OkResult( CustomMessage.DefaultMessage , TrsFundOprDto);

        }
    }
}
