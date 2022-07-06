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

namespace Afra.Api.Controllers.BdgProjElmntValsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgProjElmntValsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgProjElmntValsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgProjElmntValsCommand command)
        {
            command.Validate();

            var BdgProjElmntValss = await _unitOfWork.BdgProjElmntValsRepository.FindAsync(c => c.Id == command.Id);

            if (BdgProjElmntValss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgProjElmntVals = Mapper.Map(command);
            await _unitOfWork.BdgProjElmntValsRepository.AddAsync(newBdgProjElmntVals);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgProjElmntValsCommand command)
        {

            command.Validate();

            var BdgProjElmntVals = await _unitOfWork.BdgProjElmntValsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgProjElmntVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProjElmntVals = Mapper.Map(BdgProjElmntVals, command);
            BdgProjElmntVals.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgProjElmntVals = await _unitOfWork.BdgProjElmntValsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgProjElmntVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProjElmntVals.IsActive = false;
            BdgProjElmntVals.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgProjElmntValss = await _unitOfWork.BdgProjElmntValsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgProjElmntValssDto = Mapper.Map(BdgProjElmntValss);

            return OkResult(CustomMessage.DefaultMessage, BdgProjElmntValssDto.ToPagingAndSorting(query), BdgProjElmntValssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgProjElmntVals = await _unitOfWork.BdgProjElmntValsRepository.GetByIdAsync(id);

            if (BdgProjElmntVals is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgProjElmntValsDto = Mapper.Map(BdgProjElmntVals);

            return OkResult( CustomMessage.DefaultMessage , BdgProjElmntValsDto);

        }
    }
}
