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

namespace Afra.Api.Controllers.AccCloseHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccCloseHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccCloseHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccCloseHdrCommand command)
        {
            command.Validate();

            var AccCloseHdrs = await _unitOfWork.AccCloseHdrRepository.FindAsync(c => c.Id == command.Id);

            if (AccCloseHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccCloseHdr = Mapper.Map(command);
            await _unitOfWork.AccCloseHdrRepository.AddAsync(newAccCloseHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccCloseHdrCommand command)
        {

            command.Validate();

            var AccCloseHdr = await _unitOfWork.AccCloseHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccCloseHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccCloseHdr = Mapper.Map(AccCloseHdr, command);
            AccCloseHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccCloseHdr = await _unitOfWork.AccCloseHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccCloseHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccCloseHdr.IsActive = false;
            AccCloseHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccCloseHdrs = await _unitOfWork.AccCloseHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccCloseHdrsDto = Mapper.Map(AccCloseHdrs);

            return OkResult(CustomMessage.DefaultMessage, AccCloseHdrsDto.ToPagingAndSorting(query), AccCloseHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccCloseHdr = await _unitOfWork.AccCloseHdrRepository.GetByIdAsync(id);

            if (AccCloseHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccCloseHdrDto = Mapper.Map(AccCloseHdr);

            return OkResult( CustomMessage.DefaultMessage , AccCloseHdrDto);

        }
    }
}
