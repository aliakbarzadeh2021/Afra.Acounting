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

namespace Afra.Api.Controllers.SleDebCreHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleDebCreHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleDebCreHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleDebCreHdrCommand command)
        {
            command.Validate();

            var SleDebCreHdrs = await _unitOfWork.SleDebCreHdrRepository.FindAsync(c => c.Id == command.Id);

            if (SleDebCreHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleDebCreHdr = Mapper.Map(command);
            await _unitOfWork.SleDebCreHdrRepository.AddAsync(newSleDebCreHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleDebCreHdrCommand command)
        {

            command.Validate();

            var SleDebCreHdr = await _unitOfWork.SleDebCreHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleDebCreHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleDebCreHdr = Mapper.Map(SleDebCreHdr, command);
            SleDebCreHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleDebCreHdr = await _unitOfWork.SleDebCreHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleDebCreHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleDebCreHdr.IsActive = false;
            SleDebCreHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleDebCreHdrs = await _unitOfWork.SleDebCreHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleDebCreHdrsDto = Mapper.Map(SleDebCreHdrs);

            return OkResult(CustomMessage.DefaultMessage, SleDebCreHdrsDto.ToPagingAndSorting(query), SleDebCreHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleDebCreHdr = await _unitOfWork.SleDebCreHdrRepository.GetByIdAsync(id);

            if (SleDebCreHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleDebCreHdrDto = Mapper.Map(SleDebCreHdr);

            return OkResult( CustomMessage.DefaultMessage , SleDebCreHdrDto);

        }
    }
}
