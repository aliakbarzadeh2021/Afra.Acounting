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

namespace Afra.Api.Controllers.GnrProcessDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrProcessDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrProcessDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrProcessDetCommand command)
        {
            command.Validate();

            var GnrProcessDets = await _unitOfWork.GnrProcessDetRepository.FindAsync(c => c.Id == command.Id);

            if (GnrProcessDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrProcessDet = Mapper.Map(command);
            await _unitOfWork.GnrProcessDetRepository.AddAsync(newGnrProcessDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrProcessDetCommand command)
        {

            command.Validate();

            var GnrProcessDet = await _unitOfWork.GnrProcessDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrProcessDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrProcessDet = Mapper.Map(GnrProcessDet, command);
            GnrProcessDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrProcessDet = await _unitOfWork.GnrProcessDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrProcessDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrProcessDet.IsActive = false;
            GnrProcessDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrProcessDets = await _unitOfWork.GnrProcessDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrProcessDetsDto = Mapper.Map(GnrProcessDets);

            return OkResult(CustomMessage.DefaultMessage, GnrProcessDetsDto.ToPagingAndSorting(query), GnrProcessDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrProcessDet = await _unitOfWork.GnrProcessDetRepository.GetByIdAsync(id);

            if (GnrProcessDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrProcessDetDto = Mapper.Map(GnrProcessDet);

            return OkResult( CustomMessage.DefaultMessage , GnrProcessDetDto);

        }
    }
}
