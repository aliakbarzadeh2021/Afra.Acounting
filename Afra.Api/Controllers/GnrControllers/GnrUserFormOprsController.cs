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

namespace Afra.Api.Controllers.GnrUserFormOprsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrUserFormOprsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrUserFormOprsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrUserFormOprsCommand command)
        {
            command.Validate();

            var GnrUserFormOprss = await _unitOfWork.GnrUserFormOprsRepository.FindAsync(c => c.Id == command.Id);

            if (GnrUserFormOprss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrUserFormOprs = Mapper.Map(command);
            await _unitOfWork.GnrUserFormOprsRepository.AddAsync(newGnrUserFormOprs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrUserFormOprsCommand command)
        {

            command.Validate();

            var GnrUserFormOprs = await _unitOfWork.GnrUserFormOprsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrUserFormOprs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserFormOprs = Mapper.Map(GnrUserFormOprs, command);
            GnrUserFormOprs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrUserFormOprs = await _unitOfWork.GnrUserFormOprsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrUserFormOprs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserFormOprs.IsActive = false;
            GnrUserFormOprs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrUserFormOprss = await _unitOfWork.GnrUserFormOprsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrUserFormOprssDto = Mapper.Map(GnrUserFormOprss);

            return OkResult(CustomMessage.DefaultMessage, GnrUserFormOprssDto.ToPagingAndSorting(query), GnrUserFormOprssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrUserFormOprs = await _unitOfWork.GnrUserFormOprsRepository.GetByIdAsync(id);

            if (GnrUserFormOprs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrUserFormOprsDto = Mapper.Map(GnrUserFormOprs);

            return OkResult( CustomMessage.DefaultMessage , GnrUserFormOprsDto);

        }
    }
}
