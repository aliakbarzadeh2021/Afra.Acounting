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

namespace Afra.Api.Controllers.HrmTablesDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmTablesDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmTablesDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmTablesDetCommand command)
        {
            command.Validate();

            var HrmTablesDets = await _unitOfWork.HrmTablesDetRepository.FindAsync(c => c.Id == command.Id);

            if (HrmTablesDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmTablesDet = Mapper.Map(command);
            await _unitOfWork.HrmTablesDetRepository.AddAsync(newHrmTablesDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmTablesDetCommand command)
        {

            command.Validate();

            var HrmTablesDet = await _unitOfWork.HrmTablesDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmTablesDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmTablesDet = Mapper.Map(HrmTablesDet, command);
            HrmTablesDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmTablesDet = await _unitOfWork.HrmTablesDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmTablesDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmTablesDet.IsActive = false;
            HrmTablesDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmTablesDets = await _unitOfWork.HrmTablesDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmTablesDetsDto = Mapper.Map(HrmTablesDets);

            return OkResult(CustomMessage.DefaultMessage, HrmTablesDetsDto.ToPagingAndSorting(query), HrmTablesDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmTablesDet = await _unitOfWork.HrmTablesDetRepository.GetByIdAsync(id);

            if (HrmTablesDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmTablesDetDto = Mapper.Map(HrmTablesDet);

            return OkResult( CustomMessage.DefaultMessage , HrmTablesDetDto);

        }
    }
}
