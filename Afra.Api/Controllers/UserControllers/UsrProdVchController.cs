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

namespace Afra.Api.Controllers.UsrProdVchControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrProdVchController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrProdVchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrProdVchCommand command)
        {
            command.Validate();

            var UsrProdVchs = await _unitOfWork.UsrProdVchRepository.FindAsync(c => c.Id == command.Id);

            if (UsrProdVchs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrProdVch = Mapper.Map(command);
            await _unitOfWork.UsrProdVchRepository.AddAsync(newUsrProdVch);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrProdVchCommand command)
        {

            command.Validate();

            var UsrProdVch = await _unitOfWork.UsrProdVchRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrProdVch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrProdVch = Mapper.Map(UsrProdVch, command);
            UsrProdVch.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrProdVch = await _unitOfWork.UsrProdVchRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrProdVch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrProdVch.IsActive = false;
            UsrProdVch.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrProdVchs = await _unitOfWork.UsrProdVchRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrProdVchsDto = Mapper.Map(UsrProdVchs);

            return OkResult(CustomMessage.DefaultMessage, UsrProdVchsDto.ToPagingAndSorting(query), UsrProdVchsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrProdVch = await _unitOfWork.UsrProdVchRepository.GetByIdAsync(id);

            if (UsrProdVch is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrProdVchDto = Mapper.Map(UsrProdVch);

            return OkResult( CustomMessage.DefaultMessage , UsrProdVchDto);

        }
    }
}
