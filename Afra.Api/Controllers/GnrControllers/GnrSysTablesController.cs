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

namespace Afra.Api.Controllers.GnrSysTablesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrSysTablesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrSysTablesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrSysTablesCommand command)
        {
            command.Validate();

            var GnrSysTabless = await _unitOfWork.GnrSysTablesRepository.FindAsync(c => c.Id == command.Id);

            if (GnrSysTabless.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrSysTables = Mapper.Map(command);
            await _unitOfWork.GnrSysTablesRepository.AddAsync(newGnrSysTables);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrSysTablesCommand command)
        {

            command.Validate();

            var GnrSysTables = await _unitOfWork.GnrSysTablesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrSysTables == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysTables = Mapper.Map(GnrSysTables, command);
            GnrSysTables.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrSysTables = await _unitOfWork.GnrSysTablesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrSysTables == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrSysTables.IsActive = false;
            GnrSysTables.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrSysTabless = await _unitOfWork.GnrSysTablesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrSysTablessDto = Mapper.Map(GnrSysTabless);

            return OkResult(CustomMessage.DefaultMessage, GnrSysTablessDto.ToPagingAndSorting(query), GnrSysTablessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrSysTables = await _unitOfWork.GnrSysTablesRepository.GetByIdAsync(id);

            if (GnrSysTables is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrSysTablesDto = Mapper.Map(GnrSysTables);

            return OkResult( CustomMessage.DefaultMessage , GnrSysTablesDto);

        }
    }
}
