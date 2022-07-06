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

namespace Afra.Api.Controllers.GnrUserRefListDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrUserRefListDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrUserRefListDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrUserRefListDetCommand command)
        {
            command.Validate();

            var GnrUserRefListDets = await _unitOfWork.GnrUserRefListDetRepository.FindAsync(c => c.Id == command.Id);

            if (GnrUserRefListDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrUserRefListDet = Mapper.Map(command);
            await _unitOfWork.GnrUserRefListDetRepository.AddAsync(newGnrUserRefListDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrUserRefListDetCommand command)
        {

            command.Validate();

            var GnrUserRefListDet = await _unitOfWork.GnrUserRefListDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrUserRefListDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserRefListDet = Mapper.Map(GnrUserRefListDet, command);
            GnrUserRefListDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrUserRefListDet = await _unitOfWork.GnrUserRefListDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrUserRefListDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserRefListDet.IsActive = false;
            GnrUserRefListDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrUserRefListDets = await _unitOfWork.GnrUserRefListDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrUserRefListDetsDto = Mapper.Map(GnrUserRefListDets);

            return OkResult(CustomMessage.DefaultMessage, GnrUserRefListDetsDto.ToPagingAndSorting(query), GnrUserRefListDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrUserRefListDet = await _unitOfWork.GnrUserRefListDetRepository.GetByIdAsync(id);

            if (GnrUserRefListDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrUserRefListDetDto = Mapper.Map(GnrUserRefListDet);

            return OkResult( CustomMessage.DefaultMessage , GnrUserRefListDetDto);

        }
    }
}
