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

namespace Afra.Api.Controllers.GnrFormRepRelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrFormRepRelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrFormRepRelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrFormRepRelsCommand command)
        {
            command.Validate();

            var GnrFormRepRelss = await _unitOfWork.GnrFormRepRelsRepository.FindAsync(c => c.Id == command.Id);

            if (GnrFormRepRelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrFormRepRels = Mapper.Map(command);
            await _unitOfWork.GnrFormRepRelsRepository.AddAsync(newGnrFormRepRels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrFormRepRelsCommand command)
        {

            command.Validate();

            var GnrFormRepRels = await _unitOfWork.GnrFormRepRelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrFormRepRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrFormRepRels = Mapper.Map(GnrFormRepRels, command);
            GnrFormRepRels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrFormRepRels = await _unitOfWork.GnrFormRepRelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrFormRepRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrFormRepRels.IsActive = false;
            GnrFormRepRels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrFormRepRelss = await _unitOfWork.GnrFormRepRelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrFormRepRelssDto = Mapper.Map(GnrFormRepRelss);

            return OkResult(CustomMessage.DefaultMessage, GnrFormRepRelssDto.ToPagingAndSorting(query), GnrFormRepRelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrFormRepRels = await _unitOfWork.GnrFormRepRelsRepository.GetByIdAsync(id);

            if (GnrFormRepRels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrFormRepRelsDto = Mapper.Map(GnrFormRepRels);

            return OkResult( CustomMessage.DefaultMessage , GnrFormRepRelsDto);

        }
    }
}
