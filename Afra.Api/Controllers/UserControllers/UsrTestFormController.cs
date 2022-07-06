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

namespace Afra.Api.Controllers.UsrTestFormControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrTestFormController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrTestFormController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrTestFormCommand command)
        {
            command.Validate();

            var UsrTestForms = await _unitOfWork.UsrTestFormRepository.FindAsync(c => c.Id == command.Id);

            if (UsrTestForms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrTestForm = Mapper.Map(command);
            await _unitOfWork.UsrTestFormRepository.AddAsync(newUsrTestForm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrTestFormCommand command)
        {

            command.Validate();

            var UsrTestForm = await _unitOfWork.UsrTestFormRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrTestForm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrTestForm = Mapper.Map(UsrTestForm, command);
            UsrTestForm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrTestForm = await _unitOfWork.UsrTestFormRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrTestForm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrTestForm.IsActive = false;
            UsrTestForm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrTestForms = await _unitOfWork.UsrTestFormRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrTestFormsDto = Mapper.Map(UsrTestForms);

            return OkResult(CustomMessage.DefaultMessage, UsrTestFormsDto.ToPagingAndSorting(query), UsrTestFormsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrTestForm = await _unitOfWork.UsrTestFormRepository.GetByIdAsync(id);

            if (UsrTestForm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrTestFormDto = Mapper.Map(UsrTestForm);

            return OkResult( CustomMessage.DefaultMessage , UsrTestFormDto);

        }
    }
}
