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

namespace Afra.Api.Controllers.GnrUFCtgryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrUFCtgryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrUFCtgryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrUFCtgryCommand command)
        {
            command.Validate();

            var GnrUFCtgrys = await _unitOfWork.GnrUFCtgryRepository.FindAsync(c => c.Id == command.Id);

            if (GnrUFCtgrys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrUFCtgry = Mapper.Map(command);
            await _unitOfWork.GnrUFCtgryRepository.AddAsync(newGnrUFCtgry);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrUFCtgryCommand command)
        {

            command.Validate();

            var GnrUFCtgry = await _unitOfWork.GnrUFCtgryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrUFCtgry == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUFCtgry = Mapper.Map(GnrUFCtgry, command);
            GnrUFCtgry.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrUFCtgry = await _unitOfWork.GnrUFCtgryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrUFCtgry == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUFCtgry.IsActive = false;
            GnrUFCtgry.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrUFCtgrys = await _unitOfWork.GnrUFCtgryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrUFCtgrysDto = Mapper.Map(GnrUFCtgrys);

            return OkResult(CustomMessage.DefaultMessage, GnrUFCtgrysDto.ToPagingAndSorting(query), GnrUFCtgrysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrUFCtgry = await _unitOfWork.GnrUFCtgryRepository.GetByIdAsync(id);

            if (GnrUFCtgry is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrUFCtgryDto = Mapper.Map(GnrUFCtgry);

            return OkResult( CustomMessage.DefaultMessage , GnrUFCtgryDto);

        }
    }
}
