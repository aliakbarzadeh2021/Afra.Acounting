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

namespace Afra.Api.Controllers.CntContDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntContDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntContDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntContDetCommand command)
        {
            command.Validate();

            var CntContDets = await _unitOfWork.CntContDetRepository.FindAsync(c => c.Id == command.Id);

            if (CntContDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntContDet = Mapper.Map(command);
            await _unitOfWork.CntContDetRepository.AddAsync(newCntContDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntContDetCommand command)
        {

            command.Validate();

            var CntContDet = await _unitOfWork.CntContDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntContDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContDet = Mapper.Map(CntContDet, command);
            CntContDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntContDet = await _unitOfWork.CntContDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntContDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContDet.IsActive = false;
            CntContDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntContDets = await _unitOfWork.CntContDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntContDetsDto = Mapper.Map(CntContDets);

            return OkResult(CustomMessage.DefaultMessage, CntContDetsDto.ToPagingAndSorting(query), CntContDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntContDet = await _unitOfWork.CntContDetRepository.GetByIdAsync(id);

            if (CntContDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntContDetDto = Mapper.Map(CntContDet);

            return OkResult( CustomMessage.DefaultMessage , CntContDetDto);

        }
    }
}
