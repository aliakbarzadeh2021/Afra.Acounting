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

namespace Afra.Api.Controllers.CstElementsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstElementsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstElementsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstElementsCommand command)
        {
            command.Validate();

            var CstElementss = await _unitOfWork.CstElementsRepository.FindAsync(c => c.Id == command.Id);

            if (CstElementss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstElements = Mapper.Map(command);
            await _unitOfWork.CstElementsRepository.AddAsync(newCstElements);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstElementsCommand command)
        {

            command.Validate();

            var CstElements = await _unitOfWork.CstElementsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstElements == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstElements = Mapper.Map(CstElements, command);
            CstElements.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstElements = await _unitOfWork.CstElementsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstElements == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstElements.IsActive = false;
            CstElements.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstElementss = await _unitOfWork.CstElementsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstElementssDto = Mapper.Map(CstElementss);

            return OkResult(CustomMessage.DefaultMessage, CstElementssDto.ToPagingAndSorting(query), CstElementssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstElements = await _unitOfWork.CstElementsRepository.GetByIdAsync(id);

            if (CstElements is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstElementsDto = Mapper.Map(CstElements);

            return OkResult( CustomMessage.DefaultMessage , CstElementsDto);

        }
    }
}
