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

namespace Afra.Api.Controllers.UsrContInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrContInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrContInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrContInfCommand command)
        {
            command.Validate();

            var UsrContInfs = await _unitOfWork.UsrContInfRepository.FindAsync(c => c.Id == command.Id);

            if (UsrContInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrContInf = Mapper.Map(command);
            await _unitOfWork.UsrContInfRepository.AddAsync(newUsrContInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrContInfCommand command)
        {

            command.Validate();

            var UsrContInf = await _unitOfWork.UsrContInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrContInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrContInf = Mapper.Map(UsrContInf, command);
            UsrContInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrContInf = await _unitOfWork.UsrContInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrContInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrContInf.IsActive = false;
            UsrContInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrContInfs = await _unitOfWork.UsrContInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrContInfsDto = Mapper.Map(UsrContInfs);

            return OkResult(CustomMessage.DefaultMessage, UsrContInfsDto.ToPagingAndSorting(query), UsrContInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrContInf = await _unitOfWork.UsrContInfRepository.GetByIdAsync(id);

            if (UsrContInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrContInfDto = Mapper.Map(UsrContInf);

            return OkResult( CustomMessage.DefaultMessage , UsrContInfDto);

        }
    }
}
