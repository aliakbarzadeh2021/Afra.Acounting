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

namespace Afra.Api.Controllers.GnrSysFormsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrSysFormsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrSysFormsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrSysFormsCommand command)
        {
            command.Validate();

            var GnrSysFormss = await _unitOfWork.GnrSysFormsRepository.FindAsync(c => c.Id == command.Id);

            if (GnrSysFormss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrSysForms = Mapper.Map(command);
            await _unitOfWork.GnrSysFormsRepository.AddAsync(newGnrSysForms);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrSysFormsCommand command)
        {

            command.Validate();

            var GnrSysForms = await _unitOfWork.GnrSysFormsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrSysForms == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysForms = Mapper.Map(GnrSysForms, command);
            GnrSysForms.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrSysForms = await _unitOfWork.GnrSysFormsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrSysForms == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysForms.IsActive = false;
            GnrSysForms.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrSysFormss = await _unitOfWork.GnrSysFormsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrSysFormssDto = Mapper.Map(GnrSysFormss);

            return OkResult(CustomMessage.DefaultMessage, GnrSysFormssDto.ToPagingAndSorting(query), GnrSysFormssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrSysForms = await _unitOfWork.GnrSysFormsRepository.GetByIdAsync(id);

            if (GnrSysForms is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrSysFormsDto = Mapper.Map(GnrSysForms);

            return OkResult( CustomMessage.DefaultMessage , GnrSysFormsDto);

        }
    }
}
