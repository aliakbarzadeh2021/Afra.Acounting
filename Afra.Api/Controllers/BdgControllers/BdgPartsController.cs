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

namespace Afra.Api.Controllers.BdgPartsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgPartsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgPartsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgPartsCommand command)
        {
            command.Validate();

            var BdgPartss = await _unitOfWork.BdgPartsRepository.FindAsync(c => c.Id == command.Id);

            if (BdgPartss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgParts = Mapper.Map(command);
            await _unitOfWork.BdgPartsRepository.AddAsync(newBdgParts);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgPartsCommand command)
        {

            command.Validate();

            var BdgParts = await _unitOfWork.BdgPartsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgParts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgParts = Mapper.Map(BdgParts, command);
            BdgParts.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgParts = await _unitOfWork.BdgPartsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgParts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgParts.IsActive = false;
            BdgParts.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgPartss = await _unitOfWork.BdgPartsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgPartssDto = Mapper.Map(BdgPartss);

            return OkResult(CustomMessage.DefaultMessage, BdgPartssDto.ToPagingAndSorting(query), BdgPartssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgParts = await _unitOfWork.BdgPartsRepository.GetByIdAsync(id);

            if (BdgParts is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgPartsDto = Mapper.Map(BdgParts);

            return OkResult( CustomMessage.DefaultMessage , BdgPartsDto);

        }
    }
}
