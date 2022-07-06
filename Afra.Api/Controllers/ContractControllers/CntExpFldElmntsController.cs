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

namespace Afra.Api.Controllers.CntExpFldElmntsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntExpFldElmntsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntExpFldElmntsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntExpFldElmntsCommand command)
        {
            command.Validate();

            var CntExpFldElmntss = await _unitOfWork.CntExpFldElmntsRepository.FindAsync(c => c.Id == command.Id);

            if (CntExpFldElmntss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntExpFldElmnts = Mapper.Map(command);
            await _unitOfWork.CntExpFldElmntsRepository.AddAsync(newCntExpFldElmnts);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntExpFldElmntsCommand command)
        {

            command.Validate();

            var CntExpFldElmnts = await _unitOfWork.CntExpFldElmntsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntExpFldElmnts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpFldElmnts = Mapper.Map(CntExpFldElmnts, command);
            CntExpFldElmnts.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntExpFldElmnts = await _unitOfWork.CntExpFldElmntsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntExpFldElmnts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpFldElmnts.IsActive = false;
            CntExpFldElmnts.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntExpFldElmntss = await _unitOfWork.CntExpFldElmntsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntExpFldElmntssDto = Mapper.Map(CntExpFldElmntss);

            return OkResult(CustomMessage.DefaultMessage, CntExpFldElmntssDto.ToPagingAndSorting(query), CntExpFldElmntssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntExpFldElmnts = await _unitOfWork.CntExpFldElmntsRepository.GetByIdAsync(id);

            if (CntExpFldElmnts is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntExpFldElmntsDto = Mapper.Map(CntExpFldElmnts);

            return OkResult( CustomMessage.DefaultMessage , CntExpFldElmntsDto);

        }
    }
}
