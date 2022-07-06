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

namespace Afra.Api.Controllers.InvFormHdrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvFormHdrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvFormHdrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvFormHdrCommand command)
        {
            command.Validate();

            var InvFormHdrs = await _unitOfWork.InvFormHdrRepository.FindAsync(c => c.Id == command.Id);

            if (InvFormHdrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvFormHdr = Mapper.Map(command);
            await _unitOfWork.InvFormHdrRepository.AddAsync(newInvFormHdr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvFormHdrCommand command)
        {

            command.Validate();

            var InvFormHdr = await _unitOfWork.InvFormHdrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvFormHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvFormHdr = Mapper.Map(InvFormHdr, command);
            InvFormHdr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvFormHdr = await _unitOfWork.InvFormHdrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvFormHdr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvFormHdr.IsActive = false;
            InvFormHdr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvFormHdrs = await _unitOfWork.InvFormHdrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvFormHdrsDto = Mapper.Map(InvFormHdrs);

            return OkResult(CustomMessage.DefaultMessage, InvFormHdrsDto.ToPagingAndSorting(query), InvFormHdrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvFormHdr = await _unitOfWork.InvFormHdrRepository.GetByIdAsync(id);

            if (InvFormHdr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvFormHdrDto = Mapper.Map(InvFormHdr);

            return OkResult( CustomMessage.DefaultMessage , InvFormHdrDto);

        }
    }
}
