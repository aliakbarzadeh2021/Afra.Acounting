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

namespace Afra.Api.Controllers.ElementsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ElementsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ElementsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddElementsCommand command)
        {
            command.Validate();

            var Elementss = await _unitOfWork.ElementsRepository.FindAsync(c => c.Id == command.Id);

            if (Elementss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newElements = Mapper.Map(command);
            await _unitOfWork.ElementsRepository.AddAsync(newElements);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditElementsCommand command)
        {

            command.Validate();

            var Elements = await _unitOfWork.ElementsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Elements == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Elements = Mapper.Map(Elements, command);
            Elements.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Elements = await _unitOfWork.ElementsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Elements == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Elements.IsActive = false;
            Elements.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Elementss = await _unitOfWork.ElementsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ElementssDto = Mapper.Map(Elementss);

            return OkResult(CustomMessage.DefaultMessage, ElementssDto.ToPagingAndSorting(query), ElementssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Elements = await _unitOfWork.ElementsRepository.GetByIdAsync(id);

            if (Elements is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ElementsDto = Mapper.Map(Elements);

            return OkResult( CustomMessage.DefaultMessage , ElementsDto);

        }
    }
}
