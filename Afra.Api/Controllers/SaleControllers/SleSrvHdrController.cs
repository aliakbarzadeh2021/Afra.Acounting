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

namespace Afra.Api.Controllers.SleSrvHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleSrvHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleSrvHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleSrvHdrCommand command)
        {
            command.Validate();

            var SleSrvHdrs = await _unitOfWork.SleSrvHdrRepository.FindAsync(c => c.Id == command.Id);

            if (SleSrvHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleSrvHdr = Mapper.Map(command);
            await _unitOfWork.SleSrvHdrRepository.AddAsync(newSleSrvHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleSrvHdrCommand command)
        {

            command.Validate();

            var SleSrvHdr = await _unitOfWork.SleSrvHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleSrvHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleSrvHdr = Mapper.Map(SleSrvHdr, command);
            SleSrvHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleSrvHdr = await _unitOfWork.SleSrvHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleSrvHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleSrvHdr.IsActive = false;
            SleSrvHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleSrvHdrs = await _unitOfWork.SleSrvHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleSrvHdrsDto = Mapper.Map(SleSrvHdrs);

            return OkResult(CustomMessage.DefaultMessage, SleSrvHdrsDto.ToPagingAndSorting(query), SleSrvHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleSrvHdr = await _unitOfWork.SleSrvHdrRepository.GetByIdAsync(id);

            if (SleSrvHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleSrvHdrDto = Mapper.Map(SleSrvHdr);

            return OkResult( CustomMessage.DefaultMessage , SleSrvHdrDto);

        }
    }
}
