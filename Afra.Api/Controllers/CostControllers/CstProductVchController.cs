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

namespace Afra.Api.Controllers.CstProductVchControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstProductVchController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstProductVchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstProductVchCommand command)
        {
            command.Validate();

            var CstProductVchs = await _unitOfWork.CstProductVchRepository.FindAsync(c => c.Id == command.Id);

            if (CstProductVchs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstProductVch = Mapper.Map(command);
            await _unitOfWork.CstProductVchRepository.AddAsync(newCstProductVch);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstProductVchCommand command)
        {

            command.Validate();

            var CstProductVch = await _unitOfWork.CstProductVchRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstProductVch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstProductVch = Mapper.Map(CstProductVch, command);
            CstProductVch.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstProductVch = await _unitOfWork.CstProductVchRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstProductVch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstProductVch.IsActive = false;
            CstProductVch.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstProductVchs = await _unitOfWork.CstProductVchRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstProductVchsDto = Mapper.Map(CstProductVchs);

            return OkResult(CustomMessage.DefaultMessage, CstProductVchsDto.ToPagingAndSorting(query), CstProductVchsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstProductVch = await _unitOfWork.CstProductVchRepository.GetByIdAsync(id);

            if (CstProductVch is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstProductVchDto = Mapper.Map(CstProductVch);

            return OkResult( CustomMessage.DefaultMessage , CstProductVchDto);

        }
    }
}
