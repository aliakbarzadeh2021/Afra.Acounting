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

namespace Afra.Api.Controllers.BdgElmntValControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgElmntValController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgElmntValController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgElmntValCommand command)
        {
            command.Validate();

            var BdgElmntVals = await _unitOfWork.BdgElmntValRepository.FindAsync(c => c.Id == command.Id);

            if (BdgElmntVals.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgElmntVal = Mapper.Map(command);
            await _unitOfWork.BdgElmntValRepository.AddAsync(newBdgElmntVal);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgElmntValCommand command)
        {

            command.Validate();

            var BdgElmntVal = await _unitOfWork.BdgElmntValRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgElmntVal == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgElmntVal = Mapper.Map(BdgElmntVal, command);
            BdgElmntVal.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgElmntVal = await _unitOfWork.BdgElmntValRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgElmntVal == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgElmntVal.IsActive = false;
            BdgElmntVal.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgElmntVals = await _unitOfWork.BdgElmntValRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgElmntValsDto = Mapper.Map(BdgElmntVals);

            return OkResult(CustomMessage.DefaultMessage, BdgElmntValsDto.ToPagingAndSorting(query), BdgElmntValsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgElmntVal = await _unitOfWork.BdgElmntValRepository.GetByIdAsync(id);

            if (BdgElmntVal is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgElmntValDto = Mapper.Map(BdgElmntVal);

            return OkResult( CustomMessage.DefaultMessage , BdgElmntValDto);

        }
    }
}
