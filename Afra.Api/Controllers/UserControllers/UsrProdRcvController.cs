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

namespace Afra.Api.Controllers.UsrProdRcvControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrProdRcvController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrProdRcvController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrProdRcvCommand command)
        {
            command.Validate();

            var UsrProdRcvs = await _unitOfWork.UsrProdRcvRepository.FindAsync(c => c.Id == command.Id);

            if (UsrProdRcvs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrProdRcv = Mapper.Map(command);
            await _unitOfWork.UsrProdRcvRepository.AddAsync(newUsrProdRcv);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrProdRcvCommand command)
        {

            command.Validate();

            var UsrProdRcv = await _unitOfWork.UsrProdRcvRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrProdRcv == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrProdRcv = Mapper.Map(UsrProdRcv, command);
            UsrProdRcv.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrProdRcv = await _unitOfWork.UsrProdRcvRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrProdRcv == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrProdRcv.IsActive = false;
            UsrProdRcv.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrProdRcvs = await _unitOfWork.UsrProdRcvRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrProdRcvsDto = Mapper.Map(UsrProdRcvs);

            return OkResult(CustomMessage.DefaultMessage, UsrProdRcvsDto.ToPagingAndSorting(query), UsrProdRcvsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrProdRcv = await _unitOfWork.UsrProdRcvRepository.GetByIdAsync(id);

            if (UsrProdRcv is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrProdRcvDto = Mapper.Map(UsrProdRcv);

            return OkResult( CustomMessage.DefaultMessage , UsrProdRcvDto);

        }
    }
}
