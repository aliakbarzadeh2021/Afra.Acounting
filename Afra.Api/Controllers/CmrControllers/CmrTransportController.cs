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

namespace Afra.Api.Controllers.CmrTransportControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrTransportController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrTransportController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrTransportCommand command)
        {
            command.Validate();

            var CmrTransports = await _unitOfWork.CmrTransportRepository.FindAsync(c => c.Id == command.Id);

            if (CmrTransports.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrTransport = Mapper.Map(command);
            await _unitOfWork.CmrTransportRepository.AddAsync(newCmrTransport);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrTransportCommand command)
        {

            command.Validate();

            var CmrTransport = await _unitOfWork.CmrTransportRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrTransport == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrTransport = Mapper.Map(CmrTransport, command);
            CmrTransport.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrTransport = await _unitOfWork.CmrTransportRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrTransport == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrTransport.IsActive = false;
            CmrTransport.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrTransports = await _unitOfWork.CmrTransportRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrTransportsDto = Mapper.Map(CmrTransports);

            return OkResult(CustomMessage.DefaultMessage, CmrTransportsDto.ToPagingAndSorting(query), CmrTransportsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrTransport = await _unitOfWork.CmrTransportRepository.GetByIdAsync(id);

            if (CmrTransport is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrTransportDto = Mapper.Map(CmrTransport);

            return OkResult( CustomMessage.DefaultMessage , CmrTransportDto);

        }
    }
}
