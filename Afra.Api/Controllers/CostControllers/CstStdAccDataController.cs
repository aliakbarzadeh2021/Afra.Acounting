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

namespace Afra.Api.Controllers.CstStdAccDataControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstStdAccDataController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstStdAccDataController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstStdAccDataCommand command)
        {
            command.Validate();

            var CstStdAccDatas = await _unitOfWork.CstStdAccDataRepository.FindAsync(c => c.Id == command.Id);

            if (CstStdAccDatas.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstStdAccData = Mapper.Map(command);
            await _unitOfWork.CstStdAccDataRepository.AddAsync(newCstStdAccData);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstStdAccDataCommand command)
        {

            command.Validate();

            var CstStdAccData = await _unitOfWork.CstStdAccDataRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstStdAccData == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstStdAccData = Mapper.Map(CstStdAccData, command);
            CstStdAccData.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstStdAccData = await _unitOfWork.CstStdAccDataRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstStdAccData == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstStdAccData.IsActive = false;
            CstStdAccData.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstStdAccDatas = await _unitOfWork.CstStdAccDataRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstStdAccDatasDto = Mapper.Map(CstStdAccDatas);

            return OkResult(CustomMessage.DefaultMessage, CstStdAccDatasDto.ToPagingAndSorting(query), CstStdAccDatasDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstStdAccData = await _unitOfWork.CstStdAccDataRepository.GetByIdAsync(id);

            if (CstStdAccData is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstStdAccDataDto = Mapper.Map(CstStdAccData);

            return OkResult( CustomMessage.DefaultMessage , CstStdAccDataDto);

        }
    }
}
