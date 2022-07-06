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

namespace Afra.Api.Controllers.CstProductPackDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstProductPackDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstProductPackDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstProductPackDetCommand command)
        {
            command.Validate();

            var CstProductPackDets = await _unitOfWork.CstProductPackDetRepository.FindAsync(c => c.Id == command.Id);

            if (CstProductPackDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstProductPackDet = Mapper.Map(command);
            await _unitOfWork.CstProductPackDetRepository.AddAsync(newCstProductPackDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstProductPackDetCommand command)
        {

            command.Validate();

            var CstProductPackDet = await _unitOfWork.CstProductPackDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstProductPackDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstProductPackDet = Mapper.Map(CstProductPackDet, command);
            CstProductPackDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstProductPackDet = await _unitOfWork.CstProductPackDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstProductPackDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstProductPackDet.IsActive = false;
            CstProductPackDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstProductPackDets = await _unitOfWork.CstProductPackDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstProductPackDetsDto = Mapper.Map(CstProductPackDets);

            return OkResult(CustomMessage.DefaultMessage, CstProductPackDetsDto.ToPagingAndSorting(query), CstProductPackDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstProductPackDet = await _unitOfWork.CstProductPackDetRepository.GetByIdAsync(id);

            if (CstProductPackDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstProductPackDetDto = Mapper.Map(CstProductPackDet);

            return OkResult( CustomMessage.DefaultMessage , CstProductPackDetDto);

        }
    }
}
