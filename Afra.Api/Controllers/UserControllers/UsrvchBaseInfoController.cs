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

namespace Afra.Api.Controllers.UsrvchBaseInfoControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrvchBaseInfoController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrvchBaseInfoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrvchBaseInfoCommand command)
        {
            command.Validate();

            var UsrvchBaseInfos = await _unitOfWork.UsrvchBaseInfoRepository.FindAsync(c => c.Id == command.Id);

            if (UsrvchBaseInfos.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrvchBaseInfo = Mapper.Map(command);
            await _unitOfWork.UsrvchBaseInfoRepository.AddAsync(newUsrvchBaseInfo);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrvchBaseInfoCommand command)
        {

            command.Validate();

            var UsrvchBaseInfo = await _unitOfWork.UsrvchBaseInfoRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrvchBaseInfo == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrvchBaseInfo = Mapper.Map(UsrvchBaseInfo, command);
            UsrvchBaseInfo.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrvchBaseInfo = await _unitOfWork.UsrvchBaseInfoRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrvchBaseInfo == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrvchBaseInfo.IsActive = false;
            UsrvchBaseInfo.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrvchBaseInfos = await _unitOfWork.UsrvchBaseInfoRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrvchBaseInfosDto = Mapper.Map(UsrvchBaseInfos);

            return OkResult(CustomMessage.DefaultMessage, UsrvchBaseInfosDto.ToPagingAndSorting(query), UsrvchBaseInfosDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrvchBaseInfo = await _unitOfWork.UsrvchBaseInfoRepository.GetByIdAsync(id);

            if (UsrvchBaseInfo is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrvchBaseInfoDto = Mapper.Map(UsrvchBaseInfo);

            return OkResult( CustomMessage.DefaultMessage , UsrvchBaseInfoDto);

        }
    }
}
