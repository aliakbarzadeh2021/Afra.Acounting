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

namespace Afra.Api.Controllers.PartsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PartsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PartsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPartsCommand command)
        {
            command.Validate();

            var Partss = await _unitOfWork.PartsRepository.FindAsync(c => c.Id == command.Id);

            if (Partss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newParts = Mapper.Map(command);
            await _unitOfWork.PartsRepository.AddAsync(newParts);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPartsCommand command)
        {

            command.Validate();

            var Parts = await _unitOfWork.PartsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Parts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Parts = Mapper.Map(Parts, command);
            Parts.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Parts = await _unitOfWork.PartsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Parts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Parts.IsActive = false;
            Parts.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Partss = await _unitOfWork.PartsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PartssDto = Mapper.Map(Partss);

            return OkResult(CustomMessage.DefaultMessage, PartssDto.ToPagingAndSorting(query), PartssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Parts = await _unitOfWork.PartsRepository.GetByIdAsync(id);

            if (Parts is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PartsDto = Mapper.Map(Parts);

            return OkResult( CustomMessage.DefaultMessage , PartsDto);

        }
    }
}
