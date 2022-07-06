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

namespace Afra.Api.Controllers.OtoSysLttrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoSysLttrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoSysLttrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoSysLttrCommand command)
        {
            command.Validate();

            var OtoSysLttrs = await _unitOfWork.OtoSysLttrRepository.FindAsync(c => c.Id == command.Id);

            if (OtoSysLttrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoSysLttr = Mapper.Map(command);
            await _unitOfWork.OtoSysLttrRepository.AddAsync(newOtoSysLttr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoSysLttrCommand command)
        {

            command.Validate();

            var OtoSysLttr = await _unitOfWork.OtoSysLttrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoSysLttr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoSysLttr = Mapper.Map(OtoSysLttr, command);
            OtoSysLttr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoSysLttr = await _unitOfWork.OtoSysLttrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoSysLttr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoSysLttr.IsActive = false;
            OtoSysLttr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoSysLttrs = await _unitOfWork.OtoSysLttrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoSysLttrsDto = Mapper.Map(OtoSysLttrs);

            return OkResult(CustomMessage.DefaultMessage, OtoSysLttrsDto.ToPagingAndSorting(query), OtoSysLttrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoSysLttr = await _unitOfWork.OtoSysLttrRepository.GetByIdAsync(id);

            if (OtoSysLttr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoSysLttrDto = Mapper.Map(OtoSysLttr);

            return OkResult( CustomMessage.DefaultMessage , OtoSysLttrDto);

        }
    }
}
