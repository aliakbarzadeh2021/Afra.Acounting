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

namespace Afra.Api.Controllers.AstCostDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AstCostDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AstCostDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAstCostDetCommand command)
        {
            command.Validate();

            var AstCostDets = await _unitOfWork.AstCostDetRepository.FindAsync(c => c.Id == command.Id);

            if (AstCostDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAstCostDet = Mapper.Map(command);
            await _unitOfWork.AstCostDetRepository.AddAsync(newAstCostDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAstCostDetCommand command)
        {

            command.Validate();

            var AstCostDet = await _unitOfWork.AstCostDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AstCostDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstCostDet = Mapper.Map(AstCostDet, command);
            AstCostDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AstCostDet = await _unitOfWork.AstCostDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AstCostDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstCostDet.IsActive = false;
            AstCostDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AstCostDets = await _unitOfWork.AstCostDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AstCostDetsDto = Mapper.Map(AstCostDets);

            return OkResult(CustomMessage.DefaultMessage, AstCostDetsDto.ToPagingAndSorting(query), AstCostDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AstCostDet = await _unitOfWork.AstCostDetRepository.GetByIdAsync(id);

            if (AstCostDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AstCostDetDto = Mapper.Map(AstCostDet);

            return OkResult( CustomMessage.DefaultMessage , AstCostDetDto);

        }
    }
}
