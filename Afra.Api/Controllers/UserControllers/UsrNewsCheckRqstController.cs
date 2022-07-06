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

namespace Afra.Api.Controllers.UsrNewsCheckRqstControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrNewsCheckRqstController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrNewsCheckRqstController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrNewsCheckRqstCommand command)
        {
            command.Validate();

            var UsrNewsCheckRqsts = await _unitOfWork.UsrNewsCheckRqstRepository.FindAsync(c => c.Id == command.Id);

            if (UsrNewsCheckRqsts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrNewsCheckRqst = Mapper.Map(command);
            await _unitOfWork.UsrNewsCheckRqstRepository.AddAsync(newUsrNewsCheckRqst);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrNewsCheckRqstCommand command)
        {

            command.Validate();

            var UsrNewsCheckRqst = await _unitOfWork.UsrNewsCheckRqstRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrNewsCheckRqst == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrNewsCheckRqst = Mapper.Map(UsrNewsCheckRqst, command);
            UsrNewsCheckRqst.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrNewsCheckRqst = await _unitOfWork.UsrNewsCheckRqstRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrNewsCheckRqst == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrNewsCheckRqst.IsActive = false;
            UsrNewsCheckRqst.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrNewsCheckRqsts = await _unitOfWork.UsrNewsCheckRqstRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrNewsCheckRqstsDto = Mapper.Map(UsrNewsCheckRqsts);

            return OkResult(CustomMessage.DefaultMessage, UsrNewsCheckRqstsDto.ToPagingAndSorting(query), UsrNewsCheckRqstsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrNewsCheckRqst = await _unitOfWork.UsrNewsCheckRqstRepository.GetByIdAsync(id);

            if (UsrNewsCheckRqst is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrNewsCheckRqstDto = Mapper.Map(UsrNewsCheckRqst);

            return OkResult( CustomMessage.DefaultMessage , UsrNewsCheckRqstDto);

        }
    }
}
