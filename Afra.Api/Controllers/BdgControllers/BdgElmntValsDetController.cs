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

namespace Afra.Api.Controllers.BdgElmntValsDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgElmntValsDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgElmntValsDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgElmntValsDetCommand command)
        {
            command.Validate();

            var BdgElmntValsDets = await _unitOfWork.BdgElmntValsDetRepository.FindAsync(c => c.Id == command.Id);

            if (BdgElmntValsDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgElmntValsDet = Mapper.Map(command);
            await _unitOfWork.BdgElmntValsDetRepository.AddAsync(newBdgElmntValsDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgElmntValsDetCommand command)
        {

            command.Validate();

            var BdgElmntValsDet = await _unitOfWork.BdgElmntValsDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgElmntValsDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgElmntValsDet = Mapper.Map(BdgElmntValsDet, command);
            BdgElmntValsDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgElmntValsDet = await _unitOfWork.BdgElmntValsDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgElmntValsDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgElmntValsDet.IsActive = false;
            BdgElmntValsDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgElmntValsDets = await _unitOfWork.BdgElmntValsDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgElmntValsDetsDto = Mapper.Map(BdgElmntValsDets);

            return OkResult(CustomMessage.DefaultMessage, BdgElmntValsDetsDto.ToPagingAndSorting(query), BdgElmntValsDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgElmntValsDet = await _unitOfWork.BdgElmntValsDetRepository.GetByIdAsync(id);

            if (BdgElmntValsDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgElmntValsDetDto = Mapper.Map(BdgElmntValsDet);

            return OkResult( CustomMessage.DefaultMessage , BdgElmntValsDetDto);

        }
    }
}
