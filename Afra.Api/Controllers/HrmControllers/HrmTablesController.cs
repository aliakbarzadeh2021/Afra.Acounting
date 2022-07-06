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

namespace Afra.Api.Controllers.HrmTablesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmTablesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmTablesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmTablesCommand command)
        {
            command.Validate();

            var HrmTabless = await _unitOfWork.HrmTablesRepository.FindAsync(c => c.Id == command.Id);

            if (HrmTabless.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmTables = Mapper.Map(command);
            await _unitOfWork.HrmTablesRepository.AddAsync(newHrmTables);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmTablesCommand command)
        {

            command.Validate();

            var HrmTables = await _unitOfWork.HrmTablesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmTables == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmTables = Mapper.Map(HrmTables, command);
            HrmTables.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmTables = await _unitOfWork.HrmTablesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmTables == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmTables.IsActive = false;
            HrmTables.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmTabless = await _unitOfWork.HrmTablesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmTablessDto = Mapper.Map(HrmTabless);

            return OkResult(CustomMessage.DefaultMessage, HrmTablessDto.ToPagingAndSorting(query), HrmTablessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmTables = await _unitOfWork.HrmTablesRepository.GetByIdAsync(id);

            if (HrmTables is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmTablesDto = Mapper.Map(HrmTables);

            return OkResult( CustomMessage.DefaultMessage , HrmTablesDto);

        }
    }
}
