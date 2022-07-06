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

namespace Afra.Api.Controllers.BdgProjElmntControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgProjElmntController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgProjElmntController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgProjElmntCommand command)
        {
            command.Validate();

            var BdgProjElmnts = await _unitOfWork.BdgProjElmntRepository.FindAsync(c => c.Id == command.Id);

            if (BdgProjElmnts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgProjElmnt = Mapper.Map(command);
            await _unitOfWork.BdgProjElmntRepository.AddAsync(newBdgProjElmnt);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgProjElmntCommand command)
        {

            command.Validate();

            var BdgProjElmnt = await _unitOfWork.BdgProjElmntRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgProjElmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProjElmnt = Mapper.Map(BdgProjElmnt, command);
            BdgProjElmnt.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgProjElmnt = await _unitOfWork.BdgProjElmntRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgProjElmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProjElmnt.IsActive = false;
            BdgProjElmnt.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgProjElmnts = await _unitOfWork.BdgProjElmntRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgProjElmntsDto = Mapper.Map(BdgProjElmnts);

            return OkResult(CustomMessage.DefaultMessage, BdgProjElmntsDto.ToPagingAndSorting(query), BdgProjElmntsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgProjElmnt = await _unitOfWork.BdgProjElmntRepository.GetByIdAsync(id);

            if (BdgProjElmnt is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgProjElmntDto = Mapper.Map(BdgProjElmnt);

            return OkResult( CustomMessage.DefaultMessage , BdgProjElmntDto);

        }
    }
}
