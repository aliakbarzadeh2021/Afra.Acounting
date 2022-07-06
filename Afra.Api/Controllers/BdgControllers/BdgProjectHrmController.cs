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

namespace Afra.Api.Controllers.BdgProjectHrmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgProjectHrmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgProjectHrmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgProjectHrmCommand command)
        {
            command.Validate();

            var BdgProjectHrms = await _unitOfWork.BdgProjectHrmRepository.FindAsync(c => c.Id == command.Id);

            if (BdgProjectHrms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgProjectHrm = Mapper.Map(command);
            await _unitOfWork.BdgProjectHrmRepository.AddAsync(newBdgProjectHrm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgProjectHrmCommand command)
        {

            command.Validate();

            var BdgProjectHrm = await _unitOfWork.BdgProjectHrmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgProjectHrm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProjectHrm = Mapper.Map(BdgProjectHrm, command);
            BdgProjectHrm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgProjectHrm = await _unitOfWork.BdgProjectHrmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgProjectHrm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProjectHrm.IsActive = false;
            BdgProjectHrm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgProjectHrms = await _unitOfWork.BdgProjectHrmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgProjectHrmsDto = Mapper.Map(BdgProjectHrms);

            return OkResult(CustomMessage.DefaultMessage, BdgProjectHrmsDto.ToPagingAndSorting(query), BdgProjectHrmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgProjectHrm = await _unitOfWork.BdgProjectHrmRepository.GetByIdAsync(id);

            if (BdgProjectHrm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgProjectHrmDto = Mapper.Map(BdgProjectHrm);

            return OkResult( CustomMessage.DefaultMessage , BdgProjectHrmDto);

        }
    }
}
