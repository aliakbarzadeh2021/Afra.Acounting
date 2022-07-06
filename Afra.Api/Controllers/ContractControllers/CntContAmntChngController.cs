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

namespace Afra.Api.Controllers.CntContAmntChngControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntContAmntChngController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntContAmntChngController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntContAmntChngCommand command)
        {
            command.Validate();

            var CntContAmntChngs = await _unitOfWork.CntContAmntChngRepository.FindAsync(c => c.Id == command.Id);

            if (CntContAmntChngs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntContAmntChng = Mapper.Map(command);
            await _unitOfWork.CntContAmntChngRepository.AddAsync(newCntContAmntChng);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntContAmntChngCommand command)
        {

            command.Validate();

            var CntContAmntChng = await _unitOfWork.CntContAmntChngRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntContAmntChng == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContAmntChng = Mapper.Map(CntContAmntChng, command);
            CntContAmntChng.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntContAmntChng = await _unitOfWork.CntContAmntChngRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntContAmntChng == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContAmntChng.IsActive = false;
            CntContAmntChng.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntContAmntChngs = await _unitOfWork.CntContAmntChngRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntContAmntChngsDto = Mapper.Map(CntContAmntChngs);

            return OkResult(CustomMessage.DefaultMessage, CntContAmntChngsDto.ToPagingAndSorting(query), CntContAmntChngsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntContAmntChng = await _unitOfWork.CntContAmntChngRepository.GetByIdAsync(id);

            if (CntContAmntChng is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntContAmntChngDto = Mapper.Map(CntContAmntChng);

            return OkResult( CustomMessage.DefaultMessage , CntContAmntChngDto);

        }
    }
}
