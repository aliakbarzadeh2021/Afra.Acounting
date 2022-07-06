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

namespace Afra.Api.Controllers.AccDLCtgryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccDLCtgryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccDLCtgryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccDLCtgryCommand command)
        {
            command.Validate();

            var AccDLCtgrys = await _unitOfWork.AccDLCtgryRepository.FindAsync(c => c.Id == command.Id);

            if (AccDLCtgrys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccDLCtgry = Mapper.Map(command);
            await _unitOfWork.AccDLCtgryRepository.AddAsync(newAccDLCtgry);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccDLCtgryCommand command)
        {

            command.Validate();

            var AccDLCtgry = await _unitOfWork.AccDLCtgryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccDLCtgry == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccDLCtgry = Mapper.Map(AccDLCtgry, command);
            AccDLCtgry.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccDLCtgry = await _unitOfWork.AccDLCtgryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccDLCtgry == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccDLCtgry.IsActive = false;
            AccDLCtgry.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccDLCtgrys = await _unitOfWork.AccDLCtgryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccDLCtgrysDto = Mapper.Map(AccDLCtgrys);

            return OkResult(CustomMessage.DefaultMessage, AccDLCtgrysDto.ToPagingAndSorting(query), AccDLCtgrysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccDLCtgry = await _unitOfWork.AccDLCtgryRepository.GetByIdAsync(id);

            if (AccDLCtgry is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccDLCtgryDto = Mapper.Map(AccDLCtgry);

            return OkResult( CustomMessage.DefaultMessage , AccDLCtgryDto);

        }
    }
}
