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

namespace Afra.Api.Controllers.SleChngVchHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleChngVchHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleChngVchHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleChngVchHdrCommand command)
        {
            command.Validate();

            var SleChngVchHdrs = await _unitOfWork.SleChngVchHdrRepository.FindAsync(c => c.Id == command.Id);

            if (SleChngVchHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleChngVchHdr = Mapper.Map(command);
            await _unitOfWork.SleChngVchHdrRepository.AddAsync(newSleChngVchHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleChngVchHdrCommand command)
        {

            command.Validate();

            var SleChngVchHdr = await _unitOfWork.SleChngVchHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleChngVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleChngVchHdr = Mapper.Map(SleChngVchHdr, command);
            SleChngVchHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleChngVchHdr = await _unitOfWork.SleChngVchHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleChngVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleChngVchHdr.IsActive = false;
            SleChngVchHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleChngVchHdrs = await _unitOfWork.SleChngVchHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleChngVchHdrsDto = Mapper.Map(SleChngVchHdrs);

            return OkResult(CustomMessage.DefaultMessage, SleChngVchHdrsDto.ToPagingAndSorting(query), SleChngVchHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleChngVchHdr = await _unitOfWork.SleChngVchHdrRepository.GetByIdAsync(id);

            if (SleChngVchHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleChngVchHdrDto = Mapper.Map(SleChngVchHdr);

            return OkResult( CustomMessage.DefaultMessage , SleChngVchHdrDto);

        }
    }
}
