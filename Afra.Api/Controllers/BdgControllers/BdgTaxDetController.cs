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

namespace Afra.Api.Controllers.BdgTaxDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgTaxDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgTaxDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgTaxDetCommand command)
        {
            command.Validate();

            var BdgTaxDets = await _unitOfWork.BdgTaxDetRepository.FindAsync(c => c.Id == command.Id);

            if (BdgTaxDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgTaxDet = Mapper.Map(command);
            await _unitOfWork.BdgTaxDetRepository.AddAsync(newBdgTaxDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgTaxDetCommand command)
        {

            command.Validate();

            var BdgTaxDet = await _unitOfWork.BdgTaxDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgTaxDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgTaxDet = Mapper.Map(BdgTaxDet, command);
            BdgTaxDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgTaxDet = await _unitOfWork.BdgTaxDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgTaxDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgTaxDet.IsActive = false;
            BdgTaxDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgTaxDets = await _unitOfWork.BdgTaxDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgTaxDetsDto = Mapper.Map(BdgTaxDets);

            return OkResult(CustomMessage.DefaultMessage, BdgTaxDetsDto.ToPagingAndSorting(query), BdgTaxDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgTaxDet = await _unitOfWork.BdgTaxDetRepository.GetByIdAsync(id);

            if (BdgTaxDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgTaxDetDto = Mapper.Map(BdgTaxDet);

            return OkResult( CustomMessage.DefaultMessage , BdgTaxDetDto);

        }
    }
}
