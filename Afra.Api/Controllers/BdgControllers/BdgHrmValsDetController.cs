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

namespace Afra.Api.Controllers.BdgHrmValsDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgHrmValsDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgHrmValsDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgHrmValsDetCommand command)
        {
            command.Validate();

            var BdgHrmValsDets = await _unitOfWork.BdgHrmValsDetRepository.FindAsync(c => c.Id == command.Id);

            if (BdgHrmValsDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgHrmValsDet = Mapper.Map(command);
            await _unitOfWork.BdgHrmValsDetRepository.AddAsync(newBdgHrmValsDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgHrmValsDetCommand command)
        {

            command.Validate();

            var BdgHrmValsDet = await _unitOfWork.BdgHrmValsDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgHrmValsDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgHrmValsDet = Mapper.Map(BdgHrmValsDet, command);
            BdgHrmValsDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgHrmValsDet = await _unitOfWork.BdgHrmValsDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgHrmValsDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgHrmValsDet.IsActive = false;
            BdgHrmValsDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgHrmValsDets = await _unitOfWork.BdgHrmValsDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgHrmValsDetsDto = Mapper.Map(BdgHrmValsDets);

            return OkResult(CustomMessage.DefaultMessage, BdgHrmValsDetsDto.ToPagingAndSorting(query), BdgHrmValsDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgHrmValsDet = await _unitOfWork.BdgHrmValsDetRepository.GetByIdAsync(id);

            if (BdgHrmValsDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgHrmValsDetDto = Mapper.Map(BdgHrmValsDet);

            return OkResult( CustomMessage.DefaultMessage , BdgHrmValsDetDto);

        }
    }
}
