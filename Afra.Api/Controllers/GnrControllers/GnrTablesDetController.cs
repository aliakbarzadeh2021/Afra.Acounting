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

namespace Afra.Api.Controllers.GnrTablesDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrTablesDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrTablesDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrTablesDetCommand command)
        {
            command.Validate();

            var GnrTablesDets = await _unitOfWork.GnrTablesDetRepository.FindAsync(c => c.Id == command.Id);

            if (GnrTablesDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrTablesDet = Mapper.Map(command);
            await _unitOfWork.GnrTablesDetRepository.AddAsync(newGnrTablesDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrTablesDetCommand command)
        {

            command.Validate();

            var GnrTablesDet = await _unitOfWork.GnrTablesDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrTablesDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrTablesDet = Mapper.Map(GnrTablesDet, command);
            GnrTablesDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrTablesDet = await _unitOfWork.GnrTablesDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrTablesDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrTablesDet.IsActive = false;
            GnrTablesDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrTablesDets = await _unitOfWork.GnrTablesDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrTablesDetsDto = Mapper.Map(GnrTablesDets);

            return OkResult(CustomMessage.DefaultMessage, GnrTablesDetsDto.ToPagingAndSorting(query), GnrTablesDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrTablesDet = await _unitOfWork.GnrTablesDetRepository.GetByIdAsync(id);

            if (GnrTablesDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrTablesDetDto = Mapper.Map(GnrTablesDet);

            return OkResult( CustomMessage.DefaultMessage , GnrTablesDetDto);

        }
    }
}
