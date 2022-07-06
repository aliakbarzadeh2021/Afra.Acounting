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

namespace Afra.Api.Controllers.GnrProcessDetTransControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrProcessDetTransController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrProcessDetTransController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrProcessDetTransCommand command)
        {
            command.Validate();

            var GnrProcessDetTranss = await _unitOfWork.GnrProcessDetTransRepository.FindAsync(c => c.Id == command.Id);

            if (GnrProcessDetTranss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrProcessDetTrans = Mapper.Map(command);
            await _unitOfWork.GnrProcessDetTransRepository.AddAsync(newGnrProcessDetTrans);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrProcessDetTransCommand command)
        {

            command.Validate();

            var GnrProcessDetTrans = await _unitOfWork.GnrProcessDetTransRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrProcessDetTrans == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrProcessDetTrans = Mapper.Map(GnrProcessDetTrans, command);
            GnrProcessDetTrans.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrProcessDetTrans = await _unitOfWork.GnrProcessDetTransRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrProcessDetTrans == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrProcessDetTrans.IsActive = false;
            GnrProcessDetTrans.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrProcessDetTranss = await _unitOfWork.GnrProcessDetTransRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrProcessDetTranssDto = Mapper.Map(GnrProcessDetTranss);

            return OkResult(CustomMessage.DefaultMessage, GnrProcessDetTranssDto.ToPagingAndSorting(query), GnrProcessDetTranssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrProcessDetTrans = await _unitOfWork.GnrProcessDetTransRepository.GetByIdAsync(id);

            if (GnrProcessDetTrans is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrProcessDetTransDto = Mapper.Map(GnrProcessDetTrans);

            return OkResult( CustomMessage.DefaultMessage , GnrProcessDetTransDto);

        }
    }
}
