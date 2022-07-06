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

namespace Afra.Api.Controllers.HrmAimFormsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmAimFormsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmAimFormsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmAimFormsCommand command)
        {
            command.Validate();

            var HrmAimFormss = await _unitOfWork.HrmAimFormsRepository.FindAsync(c => c.Id == command.Id);

            if (HrmAimFormss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmAimForms = Mapper.Map(command);
            await _unitOfWork.HrmAimFormsRepository.AddAsync(newHrmAimForms);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmAimFormsCommand command)
        {

            command.Validate();

            var HrmAimForms = await _unitOfWork.HrmAimFormsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmAimForms == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmAimForms = Mapper.Map(HrmAimForms, command);
            HrmAimForms.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmAimForms = await _unitOfWork.HrmAimFormsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmAimForms == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmAimForms.IsActive = false;
            HrmAimForms.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmAimFormss = await _unitOfWork.HrmAimFormsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmAimFormssDto = Mapper.Map(HrmAimFormss);

            return OkResult(CustomMessage.DefaultMessage, HrmAimFormssDto.ToPagingAndSorting(query), HrmAimFormssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmAimForms = await _unitOfWork.HrmAimFormsRepository.GetByIdAsync(id);

            if (HrmAimForms is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmAimFormsDto = Mapper.Map(HrmAimForms);

            return OkResult( CustomMessage.DefaultMessage , HrmAimFormsDto);

        }
    }
}
