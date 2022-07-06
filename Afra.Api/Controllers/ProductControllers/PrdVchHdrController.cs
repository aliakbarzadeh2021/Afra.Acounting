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

namespace Afra.Api.Controllers.PrdVchHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdVchHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdVchHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdVchHdrCommand command)
        {
            command.Validate();

            var PrdVchHdrs = await _unitOfWork.PrdVchHdrRepository.FindAsync(c => c.Id == command.Id);

            if (PrdVchHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdVchHdr = Mapper.Map(command);
            await _unitOfWork.PrdVchHdrRepository.AddAsync(newPrdVchHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdVchHdrCommand command)
        {

            command.Validate();

            var PrdVchHdr = await _unitOfWork.PrdVchHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdVchHdr = Mapper.Map(PrdVchHdr, command);
            PrdVchHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdVchHdr = await _unitOfWork.PrdVchHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdVchHdr.IsActive = false;
            PrdVchHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdVchHdrs = await _unitOfWork.PrdVchHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdVchHdrsDto = Mapper.Map(PrdVchHdrs);

            return OkResult(CustomMessage.DefaultMessage, PrdVchHdrsDto.ToPagingAndSorting(query), PrdVchHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdVchHdr = await _unitOfWork.PrdVchHdrRepository.GetByIdAsync(id);

            if (PrdVchHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdVchHdrDto = Mapper.Map(PrdVchHdr);

            return OkResult( CustomMessage.DefaultMessage , PrdVchHdrDto);

        }
    }
}
