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

namespace Afra.Api.Controllers.CmrLCControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrLCController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrLCController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrLCCommand command)
        {
            command.Validate();

            var CmrLCs = await _unitOfWork.CmrLCRepository.FindAsync(c => c.Id == command.Id);

            if (CmrLCs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrLC = Mapper.Map(command);
            await _unitOfWork.CmrLCRepository.AddAsync(newCmrLC);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrLCCommand command)
        {

            command.Validate();

            var CmrLC = await _unitOfWork.CmrLCRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrLC == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrLC = Mapper.Map(CmrLC, command);
            CmrLC.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrLC = await _unitOfWork.CmrLCRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrLC == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrLC.IsActive = false;
            CmrLC.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrLCs = await _unitOfWork.CmrLCRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrLCsDto = Mapper.Map(CmrLCs);

            return OkResult(CustomMessage.DefaultMessage, CmrLCsDto.ToPagingAndSorting(query), CmrLCsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrLC = await _unitOfWork.CmrLCRepository.GetByIdAsync(id);

            if (CmrLC is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrLCDto = Mapper.Map(CmrLC);

            return OkResult( CustomMessage.DefaultMessage , CmrLCDto);

        }
    }
}
