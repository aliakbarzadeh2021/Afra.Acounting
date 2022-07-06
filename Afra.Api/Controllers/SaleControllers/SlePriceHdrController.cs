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

namespace Afra.Api.Controllers.SlePriceHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SlePriceHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SlePriceHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSlePriceHdrCommand command)
        {
            command.Validate();

            var SlePriceHdrs = await _unitOfWork.SlePriceHdrRepository.FindAsync(c => c.Id == command.Id);

            if (SlePriceHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSlePriceHdr = Mapper.Map(command);
            await _unitOfWork.SlePriceHdrRepository.AddAsync(newSlePriceHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSlePriceHdrCommand command)
        {

            command.Validate();

            var SlePriceHdr = await _unitOfWork.SlePriceHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SlePriceHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SlePriceHdr = Mapper.Map(SlePriceHdr, command);
            SlePriceHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SlePriceHdr = await _unitOfWork.SlePriceHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SlePriceHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SlePriceHdr.IsActive = false;
            SlePriceHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SlePriceHdrs = await _unitOfWork.SlePriceHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SlePriceHdrsDto = Mapper.Map(SlePriceHdrs);

            return OkResult(CustomMessage.DefaultMessage, SlePriceHdrsDto.ToPagingAndSorting(query), SlePriceHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SlePriceHdr = await _unitOfWork.SlePriceHdrRepository.GetByIdAsync(id);

            if (SlePriceHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SlePriceHdrDto = Mapper.Map(SlePriceHdr);

            return OkResult( CustomMessage.DefaultMessage , SlePriceHdrDto);

        }
    }
}
