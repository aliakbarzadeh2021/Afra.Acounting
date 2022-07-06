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

namespace Afra.Api.Controllers.GnrUserFormsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrUserFormsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrUserFormsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrUserFormsCommand command)
        {
            command.Validate();

            var GnrUserFormss = await _unitOfWork.GnrUserFormsRepository.FindAsync(c => c.Id == command.Id);

            if (GnrUserFormss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrUserForms = Mapper.Map(command);
            await _unitOfWork.GnrUserFormsRepository.AddAsync(newGnrUserForms);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrUserFormsCommand command)
        {

            command.Validate();

            var GnrUserForms = await _unitOfWork.GnrUserFormsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrUserForms == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserForms = Mapper.Map(GnrUserForms, command);
            GnrUserForms.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrUserForms = await _unitOfWork.GnrUserFormsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrUserForms == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserForms.IsActive = false;
            GnrUserForms.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrUserFormss = await _unitOfWork.GnrUserFormsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrUserFormssDto = Mapper.Map(GnrUserFormss);

            return OkResult(CustomMessage.DefaultMessage, GnrUserFormssDto.ToPagingAndSorting(query), GnrUserFormssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrUserForms = await _unitOfWork.GnrUserFormsRepository.GetByIdAsync(id);

            if (GnrUserForms is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrUserFormsDto = Mapper.Map(GnrUserForms);

            return OkResult( CustomMessage.DefaultMessage , GnrUserFormsDto);

        }
    }
}
