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

namespace Afra.Api.Controllers.AstDeprVchControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AstDeprVchController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AstDeprVchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAstDeprVchCommand command)
        {
            command.Validate();

            var AstDeprVchs = await _unitOfWork.AstDeprVchRepository.FindAsync(c => c.Id == command.Id);

            if (AstDeprVchs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAstDeprVch = Mapper.Map(command);
            await _unitOfWork.AstDeprVchRepository.AddAsync(newAstDeprVch);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAstDeprVchCommand command)
        {

            command.Validate();

            var AstDeprVch = await _unitOfWork.AstDeprVchRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AstDeprVch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstDeprVch = Mapper.Map(AstDeprVch, command);
            AstDeprVch.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AstDeprVch = await _unitOfWork.AstDeprVchRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AstDeprVch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstDeprVch.IsActive = false;
            AstDeprVch.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AstDeprVchs = await _unitOfWork.AstDeprVchRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AstDeprVchsDto = Mapper.Map(AstDeprVchs);

            return OkResult(CustomMessage.DefaultMessage, AstDeprVchsDto.ToPagingAndSorting(query), AstDeprVchsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AstDeprVch = await _unitOfWork.AstDeprVchRepository.GetByIdAsync(id);

            if (AstDeprVch is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AstDeprVchDto = Mapper.Map(AstDeprVch);

            return OkResult( CustomMessage.DefaultMessage , AstDeprVchDto);

        }
    }
}
