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

namespace Afra.Api.Controllers.CstAccDataControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstAccDataController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstAccDataController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstAccDataCommand command)
        {
            command.Validate();

            var CstAccDatas = await _unitOfWork.CstAccDataRepository.FindAsync(c => c.Id == command.Id);

            if (CstAccDatas.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstAccData = Mapper.Map(command);
            await _unitOfWork.CstAccDataRepository.AddAsync(newCstAccData);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstAccDataCommand command)
        {

            command.Validate();

            var CstAccData = await _unitOfWork.CstAccDataRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstAccData == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstAccData = Mapper.Map(CstAccData, command);
            CstAccData.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstAccData = await _unitOfWork.CstAccDataRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstAccData == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstAccData.IsActive = false;
            CstAccData.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstAccDatas = await _unitOfWork.CstAccDataRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstAccDatasDto = Mapper.Map(CstAccDatas);

            return OkResult(CustomMessage.DefaultMessage, CstAccDatasDto.ToPagingAndSorting(query), CstAccDatasDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstAccData = await _unitOfWork.CstAccDataRepository.GetByIdAsync(id);

            if (CstAccData is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstAccDataDto = Mapper.Map(CstAccData);

            return OkResult( CustomMessage.DefaultMessage , CstAccDataDto);

        }
    }
}
