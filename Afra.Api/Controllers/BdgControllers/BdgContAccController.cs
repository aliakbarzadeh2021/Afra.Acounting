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

namespace Afra.Api.Controllers.BdgContAccControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgContAccController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgContAccController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgContAccCommand command)
        {
            command.Validate();

            var BdgContAccs = await _unitOfWork.BdgContAccRepository.FindAsync(c => c.Id == command.Id);

            if (BdgContAccs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgContAcc = Mapper.Map(command);
            await _unitOfWork.BdgContAccRepository.AddAsync(newBdgContAcc);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgContAccCommand command)
        {

            command.Validate();

            var BdgContAcc = await _unitOfWork.BdgContAccRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgContAcc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgContAcc = Mapper.Map(BdgContAcc, command);
            BdgContAcc.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgContAcc = await _unitOfWork.BdgContAccRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgContAcc == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgContAcc.IsActive = false;
            BdgContAcc.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgContAccs = await _unitOfWork.BdgContAccRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgContAccsDto = Mapper.Map(BdgContAccs);

            return OkResult(CustomMessage.DefaultMessage, BdgContAccsDto.ToPagingAndSorting(query), BdgContAccsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgContAcc = await _unitOfWork.BdgContAccRepository.GetByIdAsync(id);

            if (BdgContAcc is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgContAccDto = Mapper.Map(BdgContAcc);

            return OkResult( CustomMessage.DefaultMessage , BdgContAccDto);

        }
    }
}
