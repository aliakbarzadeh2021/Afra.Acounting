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

namespace Afra.Api.Controllers.TrsFundBillItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsFundBillItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsFundBillItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsFundBillItmCommand command)
        {
            command.Validate();

            var TrsFundBillItms = await _unitOfWork.TrsFundBillItmRepository.FindAsync(c => c.Id == command.Id);

            if (TrsFundBillItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsFundBillItm = Mapper.Map(command);
            await _unitOfWork.TrsFundBillItmRepository.AddAsync(newTrsFundBillItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsFundBillItmCommand command)
        {

            command.Validate();

            var TrsFundBillItm = await _unitOfWork.TrsFundBillItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsFundBillItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFundBillItm = Mapper.Map(TrsFundBillItm, command);
            TrsFundBillItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsFundBillItm = await _unitOfWork.TrsFundBillItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsFundBillItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsFundBillItm.IsActive = false;
            TrsFundBillItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsFundBillItms = await _unitOfWork.TrsFundBillItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsFundBillItmsDto = Mapper.Map(TrsFundBillItms);

            return OkResult(CustomMessage.DefaultMessage, TrsFundBillItmsDto.ToPagingAndSorting(query), TrsFundBillItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsFundBillItm = await _unitOfWork.TrsFundBillItmRepository.GetByIdAsync(id);

            if (TrsFundBillItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsFundBillItmDto = Mapper.Map(TrsFundBillItm);

            return OkResult( CustomMessage.DefaultMessage , TrsFundBillItmDto);

        }
    }
}
