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

namespace Afra.Api.Controllers.GnrValidDataControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrValidDataController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrValidDataController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrValidDataCommand command)
        {
            command.Validate();

            var GnrValidDatas = await _unitOfWork.GnrValidDataRepository.FindAsync(c => c.Id == command.Id);

            if (GnrValidDatas.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrValidData = Mapper.Map(command);
            await _unitOfWork.GnrValidDataRepository.AddAsync(newGnrValidData);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrValidDataCommand command)
        {

            command.Validate();

            var GnrValidData = await _unitOfWork.GnrValidDataRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrValidData == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrValidData = Mapper.Map(GnrValidData, command);
            GnrValidData.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrValidData = await _unitOfWork.GnrValidDataRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrValidData == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrValidData.IsActive = false;
            GnrValidData.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrValidDatas = await _unitOfWork.GnrValidDataRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrValidDatasDto = Mapper.Map(GnrValidDatas);

            return OkResult(CustomMessage.DefaultMessage, GnrValidDatasDto.ToPagingAndSorting(query), GnrValidDatasDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrValidData = await _unitOfWork.GnrValidDataRepository.GetByIdAsync(id);

            if (GnrValidData is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrValidDataDto = Mapper.Map(GnrValidData);

            return OkResult( CustomMessage.DefaultMessage , GnrValidDataDto);

        }
    }
}
