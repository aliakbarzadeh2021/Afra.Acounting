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

namespace Afra.Api.Controllers.UsrTrsRqstBankInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrTrsRqstBankInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrTrsRqstBankInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrTrsRqstBankInfCommand command)
        {
            command.Validate();

            var UsrTrsRqstBankInfs = await _unitOfWork.UsrTrsRqstBankInfRepository.FindAsync(c => c.Id == command.Id);

            if (UsrTrsRqstBankInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrTrsRqstBankInf = Mapper.Map(command);
            await _unitOfWork.UsrTrsRqstBankInfRepository.AddAsync(newUsrTrsRqstBankInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrTrsRqstBankInfCommand command)
        {

            command.Validate();

            var UsrTrsRqstBankInf = await _unitOfWork.UsrTrsRqstBankInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrTrsRqstBankInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrTrsRqstBankInf = Mapper.Map(UsrTrsRqstBankInf, command);
            UsrTrsRqstBankInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrTrsRqstBankInf = await _unitOfWork.UsrTrsRqstBankInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrTrsRqstBankInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrTrsRqstBankInf.IsActive = false;
            UsrTrsRqstBankInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrTrsRqstBankInfs = await _unitOfWork.UsrTrsRqstBankInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrTrsRqstBankInfsDto = Mapper.Map(UsrTrsRqstBankInfs);

            return OkResult(CustomMessage.DefaultMessage, UsrTrsRqstBankInfsDto.ToPagingAndSorting(query), UsrTrsRqstBankInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrTrsRqstBankInf = await _unitOfWork.UsrTrsRqstBankInfRepository.GetByIdAsync(id);

            if (UsrTrsRqstBankInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrTrsRqstBankInfDto = Mapper.Map(UsrTrsRqstBankInf);

            return OkResult( CustomMessage.DefaultMessage , UsrTrsRqstBankInfDto);

        }
    }
}
