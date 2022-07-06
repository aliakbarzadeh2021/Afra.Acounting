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

namespace Afra.Api.Controllers.SleVchHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleVchHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleVchHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleVchHdrCommand command)
        {
            command.Validate();

            var SleVchHdrs = await _unitOfWork.SleVchHdrRepository.FindAsync(c => c.Id == command.Id);

            if (SleVchHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleVchHdr = Mapper.Map(command);
            await _unitOfWork.SleVchHdrRepository.AddAsync(newSleVchHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleVchHdrCommand command)
        {

            command.Validate();

            var SleVchHdr = await _unitOfWork.SleVchHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleVchHdr = Mapper.Map(SleVchHdr, command);
            SleVchHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleVchHdr = await _unitOfWork.SleVchHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleVchHdr.IsActive = false;
            SleVchHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleVchHdrs = await _unitOfWork.SleVchHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleVchHdrsDto = Mapper.Map(SleVchHdrs);

            return OkResult(CustomMessage.DefaultMessage, SleVchHdrsDto.ToPagingAndSorting(query), SleVchHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleVchHdr = await _unitOfWork.SleVchHdrRepository.GetByIdAsync(id);

            if (SleVchHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleVchHdrDto = Mapper.Map(SleVchHdr);

            return OkResult( CustomMessage.DefaultMessage , SleVchHdrDto);

        }
    }
}
