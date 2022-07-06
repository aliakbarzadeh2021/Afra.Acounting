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

namespace Afra.Api.Controllers.sysdiagramsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class sysdiagramsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public sysdiagramsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddsysdiagramsCommand command)
        {
            command.Validate();

            var sysdiagramss = await _unitOfWork.sysdiagramsRepository.FindAsync(c => c.Id == command.Id);

            if (sysdiagramss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newsysdiagrams = Mapper.Map(command);
            await _unitOfWork.sysdiagramsRepository.AddAsync(newsysdiagrams);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditsysdiagramsCommand command)
        {

            command.Validate();

            var sysdiagrams = await _unitOfWork.sysdiagramsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (sysdiagrams == null)
                return NotFound(CustomMessage.NotFoundMessage);

            sysdiagrams = Mapper.Map(sysdiagrams, command);
            sysdiagrams.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var sysdiagrams = await _unitOfWork.sysdiagramsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (sysdiagrams == null)
                return NotFound(CustomMessage.NotFoundMessage);

            sysdiagrams.IsActive = false;
            sysdiagrams.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var sysdiagramss = await _unitOfWork.sysdiagramsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var sysdiagramssDto = Mapper.Map(sysdiagramss);

            return OkResult(CustomMessage.DefaultMessage, sysdiagramssDto.ToPagingAndSorting(query), sysdiagramssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var sysdiagrams = await _unitOfWork.sysdiagramsRepository.GetByIdAsync(id);

            if (sysdiagrams is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var sysdiagramsDto = Mapper.Map(sysdiagrams);

            return OkResult( CustomMessage.DefaultMessage , sysdiagramsDto);

        }
    }
}
