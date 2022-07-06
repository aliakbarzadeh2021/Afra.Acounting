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

namespace Afra.Api.Controllers.SleSrvPrcHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleSrvPrcHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleSrvPrcHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleSrvPrcHdrCommand command)
        {
            command.Validate();

            var SleSrvPrcHdrs = await _unitOfWork.SleSrvPrcHdrRepository.FindAsync(c => c.Id == command.Id);

            if (SleSrvPrcHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleSrvPrcHdr = Mapper.Map(command);
            await _unitOfWork.SleSrvPrcHdrRepository.AddAsync(newSleSrvPrcHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleSrvPrcHdrCommand command)
        {

            command.Validate();

            var SleSrvPrcHdr = await _unitOfWork.SleSrvPrcHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleSrvPrcHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleSrvPrcHdr = Mapper.Map(SleSrvPrcHdr, command);
            SleSrvPrcHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleSrvPrcHdr = await _unitOfWork.SleSrvPrcHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleSrvPrcHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleSrvPrcHdr.IsActive = false;
            SleSrvPrcHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleSrvPrcHdrs = await _unitOfWork.SleSrvPrcHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleSrvPrcHdrsDto = Mapper.Map(SleSrvPrcHdrs);

            return OkResult(CustomMessage.DefaultMessage, SleSrvPrcHdrsDto.ToPagingAndSorting(query), SleSrvPrcHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleSrvPrcHdr = await _unitOfWork.SleSrvPrcHdrRepository.GetByIdAsync(id);

            if (SleSrvPrcHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleSrvPrcHdrDto = Mapper.Map(SleSrvPrcHdr);

            return OkResult( CustomMessage.DefaultMessage , SleSrvPrcHdrDto);

        }
    }
}
