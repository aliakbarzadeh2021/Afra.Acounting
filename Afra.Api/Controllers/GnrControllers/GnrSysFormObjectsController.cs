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

namespace Afra.Api.Controllers.GnrSysFormObjectsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrSysFormObjectsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrSysFormObjectsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrSysFormObjectsCommand command)
        {
            command.Validate();

            var GnrSysFormObjectss = await _unitOfWork.GnrSysFormObjectsRepository.FindAsync(c => c.Id == command.Id);

            if (GnrSysFormObjectss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrSysFormObjects = Mapper.Map(command);
            await _unitOfWork.GnrSysFormObjectsRepository.AddAsync(newGnrSysFormObjects);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrSysFormObjectsCommand command)
        {

            command.Validate();

            var GnrSysFormObjects = await _unitOfWork.GnrSysFormObjectsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrSysFormObjects == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysFormObjects = Mapper.Map(GnrSysFormObjects, command);
            GnrSysFormObjects.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrSysFormObjects = await _unitOfWork.GnrSysFormObjectsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrSysFormObjects == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysFormObjects.IsActive = false;
            GnrSysFormObjects.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrSysFormObjectss = await _unitOfWork.GnrSysFormObjectsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrSysFormObjectssDto = Mapper.Map(GnrSysFormObjectss);

            return OkResult(CustomMessage.DefaultMessage, GnrSysFormObjectssDto.ToPagingAndSorting(query), GnrSysFormObjectssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrSysFormObjects = await _unitOfWork.GnrSysFormObjectsRepository.GetByIdAsync(id);

            if (GnrSysFormObjects is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrSysFormObjectsDto = Mapper.Map(GnrSysFormObjects);

            return OkResult( CustomMessage.DefaultMessage , GnrSysFormObjectsDto);

        }
    }
}
