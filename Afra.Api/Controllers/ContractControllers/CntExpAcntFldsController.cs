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

namespace Afra.Api.Controllers.CntExpAcntFldsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntExpAcntFldsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntExpAcntFldsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntExpAcntFldsCommand command)
        {
            command.Validate();

            var CntExpAcntFldss = await _unitOfWork.CntExpAcntFldsRepository.FindAsync(c => c.Id == command.Id);

            if (CntExpAcntFldss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntExpAcntFlds = Mapper.Map(command);
            await _unitOfWork.CntExpAcntFldsRepository.AddAsync(newCntExpAcntFlds);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntExpAcntFldsCommand command)
        {

            command.Validate();

            var CntExpAcntFlds = await _unitOfWork.CntExpAcntFldsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntExpAcntFlds == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpAcntFlds = Mapper.Map(CntExpAcntFlds, command);
            CntExpAcntFlds.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntExpAcntFlds = await _unitOfWork.CntExpAcntFldsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntExpAcntFlds == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpAcntFlds.IsActive = false;
            CntExpAcntFlds.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntExpAcntFldss = await _unitOfWork.CntExpAcntFldsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntExpAcntFldssDto = Mapper.Map(CntExpAcntFldss);

            return OkResult(CustomMessage.DefaultMessage, CntExpAcntFldssDto.ToPagingAndSorting(query), CntExpAcntFldssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntExpAcntFlds = await _unitOfWork.CntExpAcntFldsRepository.GetByIdAsync(id);

            if (CntExpAcntFlds is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntExpAcntFldsDto = Mapper.Map(CntExpAcntFlds);

            return OkResult( CustomMessage.DefaultMessage , CntExpAcntFldsDto);

        }
    }
}
