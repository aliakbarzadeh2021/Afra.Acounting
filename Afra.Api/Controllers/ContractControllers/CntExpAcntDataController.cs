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

namespace Afra.Api.Controllers.CntExpAcntDataControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntExpAcntDataController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntExpAcntDataController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntExpAcntDataCommand command)
        {
            command.Validate();

            var CntExpAcntDatas = await _unitOfWork.CntExpAcntDataRepository.FindAsync(c => c.Id == command.Id);

            if (CntExpAcntDatas.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntExpAcntData = Mapper.Map(command);
            await _unitOfWork.CntExpAcntDataRepository.AddAsync(newCntExpAcntData);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntExpAcntDataCommand command)
        {

            command.Validate();

            var CntExpAcntData = await _unitOfWork.CntExpAcntDataRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntExpAcntData == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpAcntData = Mapper.Map(CntExpAcntData, command);
            CntExpAcntData.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntExpAcntData = await _unitOfWork.CntExpAcntDataRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntExpAcntData == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpAcntData.IsActive = false;
            CntExpAcntData.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntExpAcntDatas = await _unitOfWork.CntExpAcntDataRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntExpAcntDatasDto = Mapper.Map(CntExpAcntDatas);

            return OkResult(CustomMessage.DefaultMessage, CntExpAcntDatasDto.ToPagingAndSorting(query), CntExpAcntDatasDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntExpAcntData = await _unitOfWork.CntExpAcntDataRepository.GetByIdAsync(id);

            if (CntExpAcntData is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntExpAcntDataDto = Mapper.Map(CntExpAcntData);

            return OkResult( CustomMessage.DefaultMessage , CntExpAcntDataDto);

        }
    }
}
