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

namespace Afra.Api.Controllers.InvPartCmrInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvPartCmrInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvPartCmrInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvPartCmrInfCommand command)
        {
            command.Validate();

            var InvPartCmrInfs = await _unitOfWork.InvPartCmrInfRepository.FindAsync(c => c.Id == command.Id);

            if (InvPartCmrInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvPartCmrInf = Mapper.Map(command);
            await _unitOfWork.InvPartCmrInfRepository.AddAsync(newInvPartCmrInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvPartCmrInfCommand command)
        {

            command.Validate();

            var InvPartCmrInf = await _unitOfWork.InvPartCmrInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvPartCmrInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartCmrInf = Mapper.Map(InvPartCmrInf, command);
            InvPartCmrInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvPartCmrInf = await _unitOfWork.InvPartCmrInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvPartCmrInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartCmrInf.IsActive = false;
            InvPartCmrInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvPartCmrInfs = await _unitOfWork.InvPartCmrInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvPartCmrInfsDto = Mapper.Map(InvPartCmrInfs);

            return OkResult(CustomMessage.DefaultMessage, InvPartCmrInfsDto.ToPagingAndSorting(query), InvPartCmrInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvPartCmrInf = await _unitOfWork.InvPartCmrInfRepository.GetByIdAsync(id);

            if (InvPartCmrInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvPartCmrInfDto = Mapper.Map(InvPartCmrInf);

            return OkResult( CustomMessage.DefaultMessage , InvPartCmrInfDto);

        }
    }
}
