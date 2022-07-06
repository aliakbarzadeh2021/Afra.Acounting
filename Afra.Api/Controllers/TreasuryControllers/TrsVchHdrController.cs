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

namespace Afra.Api.Controllers.TrsVchHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TrsVchHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrsVchHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTrsVchHdrCommand command)
        {
            command.Validate();

            var TrsVchHdrs = await _unitOfWork.TrsVchHdrRepository.FindAsync(c => c.Id == command.Id);

            if (TrsVchHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTrsVchHdr = Mapper.Map(command);
            await _unitOfWork.TrsVchHdrRepository.AddAsync(newTrsVchHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTrsVchHdrCommand command)
        {

            command.Validate();

            var TrsVchHdr = await _unitOfWork.TrsVchHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TrsVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsVchHdr = Mapper.Map(TrsVchHdr, command);
            TrsVchHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TrsVchHdr = await _unitOfWork.TrsVchHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TrsVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TrsVchHdr.IsActive = false;
            TrsVchHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TrsVchHdrs = await _unitOfWork.TrsVchHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrsVchHdrsDto = Mapper.Map(TrsVchHdrs);

            return OkResult(CustomMessage.DefaultMessage, TrsVchHdrsDto.ToPagingAndSorting(query), TrsVchHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TrsVchHdr = await _unitOfWork.TrsVchHdrRepository.GetByIdAsync(id);

            if (TrsVchHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TrsVchHdrDto = Mapper.Map(TrsVchHdr);

            return OkResult( CustomMessage.DefaultMessage , TrsVchHdrDto);

        }
    }
}
