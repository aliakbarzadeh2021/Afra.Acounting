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

namespace Afra.Api.Controllers.GnrNumVchCfgDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrNumVchCfgDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrNumVchCfgDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrNumVchCfgDetCommand command)
        {
            command.Validate();

            var GnrNumVchCfgDets = await _unitOfWork.GnrNumVchCfgDetRepository.FindAsync(c => c.Id == command.Id);

            if (GnrNumVchCfgDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrNumVchCfgDet = Mapper.Map(command);
            await _unitOfWork.GnrNumVchCfgDetRepository.AddAsync(newGnrNumVchCfgDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrNumVchCfgDetCommand command)
        {

            command.Validate();

            var GnrNumVchCfgDet = await _unitOfWork.GnrNumVchCfgDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrNumVchCfgDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrNumVchCfgDet = Mapper.Map(GnrNumVchCfgDet, command);
            GnrNumVchCfgDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrNumVchCfgDet = await _unitOfWork.GnrNumVchCfgDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrNumVchCfgDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrNumVchCfgDet.IsActive = false;
            GnrNumVchCfgDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrNumVchCfgDets = await _unitOfWork.GnrNumVchCfgDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrNumVchCfgDetsDto = Mapper.Map(GnrNumVchCfgDets);

            return OkResult(CustomMessage.DefaultMessage, GnrNumVchCfgDetsDto.ToPagingAndSorting(query), GnrNumVchCfgDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrNumVchCfgDet = await _unitOfWork.GnrNumVchCfgDetRepository.GetByIdAsync(id);

            if (GnrNumVchCfgDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrNumVchCfgDetDto = Mapper.Map(GnrNumVchCfgDet);

            return OkResult( CustomMessage.DefaultMessage , GnrNumVchCfgDetDto);

        }
    }
}
