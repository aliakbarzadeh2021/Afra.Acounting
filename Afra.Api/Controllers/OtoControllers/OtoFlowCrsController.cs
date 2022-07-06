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

namespace Afra.Api.Controllers.OtoFlowCrsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OtoFlowCrsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OtoFlowCrsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOtoFlowCrsCommand command)
        {
            command.Validate();

            var OtoFlowCrss = await _unitOfWork.OtoFlowCrsRepository.FindAsync(c => c.Id == command.Id);

            if (OtoFlowCrss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOtoFlowCrs = Mapper.Map(command);
            await _unitOfWork.OtoFlowCrsRepository.AddAsync(newOtoFlowCrs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOtoFlowCrsCommand command)
        {

            command.Validate();

            var OtoFlowCrs = await _unitOfWork.OtoFlowCrsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OtoFlowCrs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoFlowCrs = Mapper.Map(OtoFlowCrs, command);
            OtoFlowCrs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OtoFlowCrs = await _unitOfWork.OtoFlowCrsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OtoFlowCrs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OtoFlowCrs.IsActive = false;
            OtoFlowCrs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OtoFlowCrss = await _unitOfWork.OtoFlowCrsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OtoFlowCrssDto = Mapper.Map(OtoFlowCrss);

            return OkResult(CustomMessage.DefaultMessage, OtoFlowCrssDto.ToPagingAndSorting(query), OtoFlowCrssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OtoFlowCrs = await _unitOfWork.OtoFlowCrsRepository.GetByIdAsync(id);

            if (OtoFlowCrs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OtoFlowCrsDto = Mapper.Map(OtoFlowCrs);

            return OkResult( CustomMessage.DefaultMessage , OtoFlowCrsDto);

        }
    }
}
