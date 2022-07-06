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

namespace Afra.Api.Controllers.GnrNumVchConfigControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrNumVchConfigController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrNumVchConfigController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrNumVchConfigCommand command)
        {
            command.Validate();

            var GnrNumVchConfigs = await _unitOfWork.GnrNumVchConfigRepository.FindAsync(c => c.Id == command.Id);

            if (GnrNumVchConfigs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrNumVchConfig = Mapper.Map(command);
            await _unitOfWork.GnrNumVchConfigRepository.AddAsync(newGnrNumVchConfig);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrNumVchConfigCommand command)
        {

            command.Validate();

            var GnrNumVchConfig = await _unitOfWork.GnrNumVchConfigRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrNumVchConfig == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrNumVchConfig = Mapper.Map(GnrNumVchConfig, command);
            GnrNumVchConfig.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrNumVchConfig = await _unitOfWork.GnrNumVchConfigRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrNumVchConfig == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrNumVchConfig.IsActive = false;
            GnrNumVchConfig.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrNumVchConfigs = await _unitOfWork.GnrNumVchConfigRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrNumVchConfigsDto = Mapper.Map(GnrNumVchConfigs);

            return OkResult(CustomMessage.DefaultMessage, GnrNumVchConfigsDto.ToPagingAndSorting(query), GnrNumVchConfigsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrNumVchConfig = await _unitOfWork.GnrNumVchConfigRepository.GetByIdAsync(id);

            if (GnrNumVchConfig is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrNumVchConfigDto = Mapper.Map(GnrNumVchConfig);

            return OkResult( CustomMessage.DefaultMessage , GnrNumVchConfigDto);

        }
    }
}
