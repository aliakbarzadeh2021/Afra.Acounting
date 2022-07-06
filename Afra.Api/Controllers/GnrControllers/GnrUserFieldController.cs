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

namespace Afra.Api.Controllers.GnrUserFieldControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrUserFieldController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrUserFieldController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrUserFieldCommand command)
        {
            command.Validate();

            var GnrUserFields = await _unitOfWork.GnrUserFieldRepository.FindAsync(c => c.Id == command.Id);

            if (GnrUserFields.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrUserField = Mapper.Map(command);
            await _unitOfWork.GnrUserFieldRepository.AddAsync(newGnrUserField);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrUserFieldCommand command)
        {

            command.Validate();

            var GnrUserField = await _unitOfWork.GnrUserFieldRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrUserField == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserField = Mapper.Map(GnrUserField, command);
            GnrUserField.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrUserField = await _unitOfWork.GnrUserFieldRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrUserField == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserField.IsActive = false;
            GnrUserField.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrUserFields = await _unitOfWork.GnrUserFieldRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrUserFieldsDto = Mapper.Map(GnrUserFields);

            return OkResult(CustomMessage.DefaultMessage, GnrUserFieldsDto.ToPagingAndSorting(query), GnrUserFieldsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrUserField = await _unitOfWork.GnrUserFieldRepository.GetByIdAsync(id);

            if (GnrUserField is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrUserFieldDto = Mapper.Map(GnrUserField);

            return OkResult( CustomMessage.DefaultMessage , GnrUserFieldDto);

        }
    }
}
