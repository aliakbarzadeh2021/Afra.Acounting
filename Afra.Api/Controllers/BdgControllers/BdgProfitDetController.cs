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

namespace Afra.Api.Controllers.BdgProfitDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgProfitDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgProfitDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgProfitDetCommand command)
        {
            command.Validate();

            var BdgProfitDets = await _unitOfWork.BdgProfitDetRepository.FindAsync(c => c.Id == command.Id);

            if (BdgProfitDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgProfitDet = Mapper.Map(command);
            await _unitOfWork.BdgProfitDetRepository.AddAsync(newBdgProfitDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgProfitDetCommand command)
        {

            command.Validate();

            var BdgProfitDet = await _unitOfWork.BdgProfitDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgProfitDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProfitDet = Mapper.Map(BdgProfitDet, command);
            BdgProfitDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgProfitDet = await _unitOfWork.BdgProfitDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgProfitDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgProfitDet.IsActive = false;
            BdgProfitDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgProfitDets = await _unitOfWork.BdgProfitDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgProfitDetsDto = Mapper.Map(BdgProfitDets);

            return OkResult(CustomMessage.DefaultMessage, BdgProfitDetsDto.ToPagingAndSorting(query), BdgProfitDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgProfitDet = await _unitOfWork.BdgProfitDetRepository.GetByIdAsync(id);

            if (BdgProfitDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgProfitDetDto = Mapper.Map(BdgProfitDet);

            return OkResult( CustomMessage.DefaultMessage , BdgProfitDetDto);

        }
    }
}
