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

namespace Afra.Api.Controllers.BdgContsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgContsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgContsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgContsCommand command)
        {
            command.Validate();

            var BdgContss = await _unitOfWork.BdgContsRepository.FindAsync(c => c.Id == command.Id);

            if (BdgContss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgConts = Mapper.Map(command);
            await _unitOfWork.BdgContsRepository.AddAsync(newBdgConts);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgContsCommand command)
        {

            command.Validate();

            var BdgConts = await _unitOfWork.BdgContsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgConts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgConts = Mapper.Map(BdgConts, command);
            BdgConts.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgConts = await _unitOfWork.BdgContsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgConts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgConts.IsActive = false;
            BdgConts.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgContss = await _unitOfWork.BdgContsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgContssDto = Mapper.Map(BdgContss);

            return OkResult(CustomMessage.DefaultMessage, BdgContssDto.ToPagingAndSorting(query), BdgContssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgConts = await _unitOfWork.BdgContsRepository.GetByIdAsync(id);

            if (BdgConts is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgContsDto = Mapper.Map(BdgConts);

            return OkResult( CustomMessage.DefaultMessage , BdgContsDto);

        }
    }
}
