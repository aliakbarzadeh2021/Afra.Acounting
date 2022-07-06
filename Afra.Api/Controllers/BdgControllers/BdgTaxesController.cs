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

namespace Afra.Api.Controllers.BdgTaxesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgTaxesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgTaxesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgTaxesCommand command)
        {
            command.Validate();

            var BdgTaxess = await _unitOfWork.BdgTaxesRepository.FindAsync(c => c.Id == command.Id);

            if (BdgTaxess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgTaxes = Mapper.Map(command);
            await _unitOfWork.BdgTaxesRepository.AddAsync(newBdgTaxes);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgTaxesCommand command)
        {

            command.Validate();

            var BdgTaxes = await _unitOfWork.BdgTaxesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgTaxes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgTaxes = Mapper.Map(BdgTaxes, command);
            BdgTaxes.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgTaxes = await _unitOfWork.BdgTaxesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgTaxes == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgTaxes.IsActive = false;
            BdgTaxes.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgTaxess = await _unitOfWork.BdgTaxesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgTaxessDto = Mapper.Map(BdgTaxess);

            return OkResult(CustomMessage.DefaultMessage, BdgTaxessDto.ToPagingAndSorting(query), BdgTaxessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgTaxes = await _unitOfWork.BdgTaxesRepository.GetByIdAsync(id);

            if (BdgTaxes is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgTaxesDto = Mapper.Map(BdgTaxes);

            return OkResult( CustomMessage.DefaultMessage , BdgTaxesDto);

        }
    }
}
