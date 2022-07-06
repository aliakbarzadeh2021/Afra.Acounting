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

namespace Afra.Api.Controllers.BdgTopicsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgTopicsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgTopicsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgTopicsCommand command)
        {
            command.Validate();

            var BdgTopicss = await _unitOfWork.BdgTopicsRepository.FindAsync(c => c.Id == command.Id);

            if (BdgTopicss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgTopics = Mapper.Map(command);
            await _unitOfWork.BdgTopicsRepository.AddAsync(newBdgTopics);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgTopicsCommand command)
        {

            command.Validate();

            var BdgTopics = await _unitOfWork.BdgTopicsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgTopics == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgTopics = Mapper.Map(BdgTopics, command);
            BdgTopics.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgTopics = await _unitOfWork.BdgTopicsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgTopics == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgTopics.IsActive = false;
            BdgTopics.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgTopicss = await _unitOfWork.BdgTopicsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgTopicssDto = Mapper.Map(BdgTopicss);

            return OkResult(CustomMessage.DefaultMessage, BdgTopicssDto.ToPagingAndSorting(query), BdgTopicssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgTopics = await _unitOfWork.BdgTopicsRepository.GetByIdAsync(id);

            if (BdgTopics is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgTopicsDto = Mapper.Map(BdgTopics);

            return OkResult( CustomMessage.DefaultMessage , BdgTopicsDto);

        }
    }
}
