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

namespace Afra.Api.Controllers.CntMasterFactDataControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntMasterFactDataController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntMasterFactDataController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntMasterFactDataCommand command)
        {
            command.Validate();

            var CntMasterFactDatas = await _unitOfWork.CntMasterFactDataRepository.FindAsync(c => c.Id == command.Id);

            if (CntMasterFactDatas.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntMasterFactData = Mapper.Map(command);
            await _unitOfWork.CntMasterFactDataRepository.AddAsync(newCntMasterFactData);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntMasterFactDataCommand command)
        {

            command.Validate();

            var CntMasterFactData = await _unitOfWork.CntMasterFactDataRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntMasterFactData == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntMasterFactData = Mapper.Map(CntMasterFactData, command);
            CntMasterFactData.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntMasterFactData = await _unitOfWork.CntMasterFactDataRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntMasterFactData == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntMasterFactData.IsActive = false;
            CntMasterFactData.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntMasterFactDatas = await _unitOfWork.CntMasterFactDataRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntMasterFactDatasDto = Mapper.Map(CntMasterFactDatas);

            return OkResult(CustomMessage.DefaultMessage, CntMasterFactDatasDto.ToPagingAndSorting(query), CntMasterFactDatasDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntMasterFactData = await _unitOfWork.CntMasterFactDataRepository.GetByIdAsync(id);

            if (CntMasterFactData is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntMasterFactDataDto = Mapper.Map(CntMasterFactData);

            return OkResult( CustomMessage.DefaultMessage , CntMasterFactDataDto);

        }
    }
}
