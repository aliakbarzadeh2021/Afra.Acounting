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

namespace Afra.Api.Controllers.BdgElementsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgElementsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgElementsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgElementsCommand command)
        {
            command.Validate();

            var BdgElementss = await _unitOfWork.BdgElementsRepository.FindAsync(c => c.Id == command.Id);

            if (BdgElementss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgElements = Mapper.Map(command);
            await _unitOfWork.BdgElementsRepository.AddAsync(newBdgElements);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgElementsCommand command)
        {

            command.Validate();

            var BdgElements = await _unitOfWork.BdgElementsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgElements == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgElements = Mapper.Map(BdgElements, command);
            BdgElements.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgElements = await _unitOfWork.BdgElementsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgElements == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgElements.IsActive = false;
            BdgElements.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgElementss = await _unitOfWork.BdgElementsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgElementssDto = Mapper.Map(BdgElementss);

            return OkResult(CustomMessage.DefaultMessage, BdgElementssDto.ToPagingAndSorting(query), BdgElementssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgElements = await _unitOfWork.BdgElementsRepository.GetByIdAsync(id);

            if (BdgElements is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgElementsDto = Mapper.Map(BdgElements);

            return OkResult( CustomMessage.DefaultMessage , BdgElementsDto);

        }
    }
}
