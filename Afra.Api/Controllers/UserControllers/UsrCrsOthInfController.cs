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

namespace Afra.Api.Controllers.UsrCrsOthInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrCrsOthInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrCrsOthInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrCrsOthInfCommand command)
        {
            command.Validate();

            var UsrCrsOthInfs = await _unitOfWork.UsrCrsOthInfRepository.FindAsync(c => c.Id == command.Id);

            if (UsrCrsOthInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrCrsOthInf = Mapper.Map(command);
            await _unitOfWork.UsrCrsOthInfRepository.AddAsync(newUsrCrsOthInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrCrsOthInfCommand command)
        {

            command.Validate();

            var UsrCrsOthInf = await _unitOfWork.UsrCrsOthInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrCrsOthInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrCrsOthInf = Mapper.Map(UsrCrsOthInf, command);
            UsrCrsOthInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrCrsOthInf = await _unitOfWork.UsrCrsOthInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrCrsOthInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrCrsOthInf.IsActive = false;
            UsrCrsOthInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrCrsOthInfs = await _unitOfWork.UsrCrsOthInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrCrsOthInfsDto = Mapper.Map(UsrCrsOthInfs);

            return OkResult(CustomMessage.DefaultMessage, UsrCrsOthInfsDto.ToPagingAndSorting(query), UsrCrsOthInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrCrsOthInf = await _unitOfWork.UsrCrsOthInfRepository.GetByIdAsync(id);

            if (UsrCrsOthInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrCrsOthInfDto = Mapper.Map(UsrCrsOthInf);

            return OkResult( CustomMessage.DefaultMessage , UsrCrsOthInfDto);

        }
    }
}
