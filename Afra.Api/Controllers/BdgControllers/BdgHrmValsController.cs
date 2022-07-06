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

namespace Afra.Api.Controllers.BdgHrmValsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgHrmValsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgHrmValsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgHrmValsCommand command)
        {
            command.Validate();

            var BdgHrmValss = await _unitOfWork.BdgHrmValsRepository.FindAsync(c => c.Id == command.Id);

            if (BdgHrmValss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgHrmVals = Mapper.Map(command);
            await _unitOfWork.BdgHrmValsRepository.AddAsync(newBdgHrmVals);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgHrmValsCommand command)
        {

            command.Validate();

            var BdgHrmVals = await _unitOfWork.BdgHrmValsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgHrmVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgHrmVals = Mapper.Map(BdgHrmVals, command);
            BdgHrmVals.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgHrmVals = await _unitOfWork.BdgHrmValsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgHrmVals == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgHrmVals.IsActive = false;
            BdgHrmVals.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgHrmValss = await _unitOfWork.BdgHrmValsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgHrmValssDto = Mapper.Map(BdgHrmValss);

            return OkResult(CustomMessage.DefaultMessage, BdgHrmValssDto.ToPagingAndSorting(query), BdgHrmValssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgHrmVals = await _unitOfWork.BdgHrmValsRepository.GetByIdAsync(id);

            if (BdgHrmVals is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgHrmValsDto = Mapper.Map(BdgHrmVals);

            return OkResult( CustomMessage.DefaultMessage , BdgHrmValsDto);

        }
    }
}
