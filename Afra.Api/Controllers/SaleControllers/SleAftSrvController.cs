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

namespace Afra.Api.Controllers.SleAftSrvControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SleAftSrvController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SleAftSrvController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSleAftSrvCommand command)
        {
            command.Validate();

            var SleAftSrvs = await _unitOfWork.SleAftSrvRepository.FindAsync(c => c.Id == command.Id);

            if (SleAftSrvs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSleAftSrv = Mapper.Map(command);
            await _unitOfWork.SleAftSrvRepository.AddAsync(newSleAftSrv);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSleAftSrvCommand command)
        {

            command.Validate();

            var SleAftSrv = await _unitOfWork.SleAftSrvRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SleAftSrv == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleAftSrv = Mapper.Map(SleAftSrv, command);
            SleAftSrv.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SleAftSrv = await _unitOfWork.SleAftSrvRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SleAftSrv == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SleAftSrv.IsActive = false;
            SleAftSrv.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SleAftSrvs = await _unitOfWork.SleAftSrvRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SleAftSrvsDto = Mapper.Map(SleAftSrvs);

            return OkResult(CustomMessage.DefaultMessage, SleAftSrvsDto.ToPagingAndSorting(query), SleAftSrvsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SleAftSrv = await _unitOfWork.SleAftSrvRepository.GetByIdAsync(id);

            if (SleAftSrv is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SleAftSrvDto = Mapper.Map(SleAftSrv);

            return OkResult( CustomMessage.DefaultMessage , SleAftSrvDto);

        }
    }
}
