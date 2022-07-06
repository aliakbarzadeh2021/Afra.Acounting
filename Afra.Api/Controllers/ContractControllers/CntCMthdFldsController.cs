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

namespace Afra.Api.Controllers.CntCMthdFldsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntCMthdFldsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntCMthdFldsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntCMthdFldsCommand command)
        {
            command.Validate();

            var CntCMthdFldss = await _unitOfWork.CntCMthdFldsRepository.FindAsync(c => c.Id == command.Id);

            if (CntCMthdFldss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntCMthdFlds = Mapper.Map(command);
            await _unitOfWork.CntCMthdFldsRepository.AddAsync(newCntCMthdFlds);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntCMthdFldsCommand command)
        {

            command.Validate();

            var CntCMthdFlds = await _unitOfWork.CntCMthdFldsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntCMthdFlds == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntCMthdFlds = Mapper.Map(CntCMthdFlds, command);
            CntCMthdFlds.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntCMthdFlds = await _unitOfWork.CntCMthdFldsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntCMthdFlds == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntCMthdFlds.IsActive = false;
            CntCMthdFlds.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntCMthdFldss = await _unitOfWork.CntCMthdFldsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntCMthdFldssDto = Mapper.Map(CntCMthdFldss);

            return OkResult(CustomMessage.DefaultMessage, CntCMthdFldssDto.ToPagingAndSorting(query), CntCMthdFldssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntCMthdFlds = await _unitOfWork.CntCMthdFldsRepository.GetByIdAsync(id);

            if (CntCMthdFlds is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntCMthdFldsDto = Mapper.Map(CntCMthdFlds);

            return OkResult( CustomMessage.DefaultMessage , CntCMthdFldsDto);

        }
    }
}
