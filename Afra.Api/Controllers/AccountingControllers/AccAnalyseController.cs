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

namespace Afra.Api.Controllers.AccAnalyseControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccAnalyseController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccAnalyseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccAnalyseCommand command)
        {
            command.Validate();

            var AccAnalyses = await _unitOfWork.AccAnalyseRepository.FindAsync(c => c.Id == command.Id);

            if (AccAnalyses.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccAnalyse = Mapper.Map(command);
            await _unitOfWork.AccAnalyseRepository.AddAsync(newAccAnalyse);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccAnalyseCommand command)
        {

            command.Validate();

            var AccAnalyse = await _unitOfWork.AccAnalyseRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccAnalyse == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccAnalyse = Mapper.Map(AccAnalyse, command);
            AccAnalyse.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccAnalyse = await _unitOfWork.AccAnalyseRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccAnalyse == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccAnalyse.IsActive = false;
            AccAnalyse.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccAnalyses = await _unitOfWork.AccAnalyseRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccAnalysesDto = Mapper.Map(AccAnalyses);

            return OkResult(CustomMessage.DefaultMessage, AccAnalysesDto.ToPagingAndSorting(query), AccAnalysesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccAnalyse = await _unitOfWork.AccAnalyseRepository.GetByIdAsync(id);

            if (AccAnalyse is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccAnalyseDto = Mapper.Map(AccAnalyse);

            return OkResult( CustomMessage.DefaultMessage , AccAnalyseDto);

        }
    }
}
