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

namespace Afra.Api.Controllers.CntContElmntControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntContElmntController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntContElmntController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntContElmntCommand command)
        {
            command.Validate();

            var CntContElmnts = await _unitOfWork.CntContElmntRepository.FindAsync(c => c.Id == command.Id);

            if (CntContElmnts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntContElmnt = Mapper.Map(command);
            await _unitOfWork.CntContElmntRepository.AddAsync(newCntContElmnt);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntContElmntCommand command)
        {

            command.Validate();

            var CntContElmnt = await _unitOfWork.CntContElmntRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntContElmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContElmnt = Mapper.Map(CntContElmnt, command);
            CntContElmnt.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntContElmnt = await _unitOfWork.CntContElmntRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntContElmnt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContElmnt.IsActive = false;
            CntContElmnt.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntContElmnts = await _unitOfWork.CntContElmntRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntContElmntsDto = Mapper.Map(CntContElmnts);

            return OkResult(CustomMessage.DefaultMessage, CntContElmntsDto.ToPagingAndSorting(query), CntContElmntsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntContElmnt = await _unitOfWork.CntContElmntRepository.GetByIdAsync(id);

            if (CntContElmnt is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntContElmntDto = Mapper.Map(CntContElmnt);

            return OkResult( CustomMessage.DefaultMessage , CntContElmntDto);

        }
    }
}
