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

namespace Afra.Api.Controllers.InvPartDLInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvPartDLInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvPartDLInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvPartDLInfCommand command)
        {
            command.Validate();

            var InvPartDLInfs = await _unitOfWork.InvPartDLInfRepository.FindAsync(c => c.Id == command.Id);

            if (InvPartDLInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvPartDLInf = Mapper.Map(command);
            await _unitOfWork.InvPartDLInfRepository.AddAsync(newInvPartDLInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvPartDLInfCommand command)
        {

            command.Validate();

            var InvPartDLInf = await _unitOfWork.InvPartDLInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvPartDLInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartDLInf = Mapper.Map(InvPartDLInf, command);
            InvPartDLInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvPartDLInf = await _unitOfWork.InvPartDLInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvPartDLInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartDLInf.IsActive = false;
            InvPartDLInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvPartDLInfs = await _unitOfWork.InvPartDLInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvPartDLInfsDto = Mapper.Map(InvPartDLInfs);

            return OkResult(CustomMessage.DefaultMessage, InvPartDLInfsDto.ToPagingAndSorting(query), InvPartDLInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvPartDLInf = await _unitOfWork.InvPartDLInfRepository.GetByIdAsync(id);

            if (InvPartDLInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvPartDLInfDto = Mapper.Map(InvPartDLInf);

            return OkResult( CustomMessage.DefaultMessage , InvPartDLInfDto);

        }
    }
}
