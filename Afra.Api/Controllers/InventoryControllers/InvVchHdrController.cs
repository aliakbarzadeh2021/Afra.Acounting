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

namespace Afra.Api.Controllers.InvVchHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvVchHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvVchHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvVchHdrCommand command)
        {
            command.Validate();

            var InvVchHdrs = await _unitOfWork.InvVchHdrRepository.FindAsync(c => c.Id == command.Id);

            if (InvVchHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvVchHdr = Mapper.Map(command);
            await _unitOfWork.InvVchHdrRepository.AddAsync(newInvVchHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvVchHdrCommand command)
        {

            command.Validate();

            var InvVchHdr = await _unitOfWork.InvVchHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvVchHdr = Mapper.Map(InvVchHdr, command);
            InvVchHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvVchHdr = await _unitOfWork.InvVchHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvVchHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvVchHdr.IsActive = false;
            InvVchHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvVchHdrs = await _unitOfWork.InvVchHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvVchHdrsDto = Mapper.Map(InvVchHdrs);

            return OkResult(CustomMessage.DefaultMessage, InvVchHdrsDto.ToPagingAndSorting(query), InvVchHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvVchHdr = await _unitOfWork.InvVchHdrRepository.GetByIdAsync(id);

            if (InvVchHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvVchHdrDto = Mapper.Map(InvVchHdr);

            return OkResult( CustomMessage.DefaultMessage , InvVchHdrDto);

        }
    }
}
