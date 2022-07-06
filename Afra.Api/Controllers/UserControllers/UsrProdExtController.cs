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

namespace Afra.Api.Controllers.UsrProdExtControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrProdExtController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrProdExtController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrProdExtCommand command)
        {
            command.Validate();

            var UsrProdExts = await _unitOfWork.UsrProdExtRepository.FindAsync(c => c.Id == command.Id);

            if (UsrProdExts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrProdExt = Mapper.Map(command);
            await _unitOfWork.UsrProdExtRepository.AddAsync(newUsrProdExt);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrProdExtCommand command)
        {

            command.Validate();

            var UsrProdExt = await _unitOfWork.UsrProdExtRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrProdExt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrProdExt = Mapper.Map(UsrProdExt, command);
            UsrProdExt.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrProdExt = await _unitOfWork.UsrProdExtRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrProdExt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrProdExt.IsActive = false;
            UsrProdExt.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrProdExts = await _unitOfWork.UsrProdExtRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrProdExtsDto = Mapper.Map(UsrProdExts);

            return OkResult(CustomMessage.DefaultMessage, UsrProdExtsDto.ToPagingAndSorting(query), UsrProdExtsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrProdExt = await _unitOfWork.UsrProdExtRepository.GetByIdAsync(id);

            if (UsrProdExt is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrProdExtDto = Mapper.Map(UsrProdExt);

            return OkResult( CustomMessage.DefaultMessage , UsrProdExtDto);

        }
    }
}
