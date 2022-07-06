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

namespace Afra.Api.Controllers.BdgPartsDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgPartsDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgPartsDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgPartsDetCommand command)
        {
            command.Validate();

            var BdgPartsDets = await _unitOfWork.BdgPartsDetRepository.FindAsync(c => c.Id == command.Id);

            if (BdgPartsDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgPartsDet = Mapper.Map(command);
            await _unitOfWork.BdgPartsDetRepository.AddAsync(newBdgPartsDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgPartsDetCommand command)
        {

            command.Validate();

            var BdgPartsDet = await _unitOfWork.BdgPartsDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgPartsDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgPartsDet = Mapper.Map(BdgPartsDet, command);
            BdgPartsDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgPartsDet = await _unitOfWork.BdgPartsDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgPartsDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgPartsDet.IsActive = false;
            BdgPartsDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgPartsDets = await _unitOfWork.BdgPartsDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgPartsDetsDto = Mapper.Map(BdgPartsDets);

            return OkResult(CustomMessage.DefaultMessage, BdgPartsDetsDto.ToPagingAndSorting(query), BdgPartsDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgPartsDet = await _unitOfWork.BdgPartsDetRepository.GetByIdAsync(id);

            if (BdgPartsDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgPartsDetDto = Mapper.Map(BdgPartsDet);

            return OkResult( CustomMessage.DefaultMessage , BdgPartsDetDto);

        }
    }
}
