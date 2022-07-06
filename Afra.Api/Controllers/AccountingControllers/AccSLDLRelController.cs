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

namespace Afra.Api.Controllers.AccSLDLRelControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccSLDLRelController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccSLDLRelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccSLDLRelCommand command)
        {
            command.Validate();

            var AccSLDLRels = await _unitOfWork.AccSLDLRelRepository.FindAsync(c => c.Id == command.Id);

            if (AccSLDLRels.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccSLDLRel = Mapper.Map(command);
            await _unitOfWork.AccSLDLRelRepository.AddAsync(newAccSLDLRel);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccSLDLRelCommand command)
        {

            command.Validate();

            var AccSLDLRel = await _unitOfWork.AccSLDLRelRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccSLDLRel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccSLDLRel = Mapper.Map(AccSLDLRel, command);
            AccSLDLRel.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccSLDLRel = await _unitOfWork.AccSLDLRelRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccSLDLRel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccSLDLRel.IsActive = false;
            AccSLDLRel.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccSLDLRels = await _unitOfWork.AccSLDLRelRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccSLDLRelsDto = Mapper.Map(AccSLDLRels);

            return OkResult(CustomMessage.DefaultMessage, AccSLDLRelsDto.ToPagingAndSorting(query), AccSLDLRelsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccSLDLRel = await _unitOfWork.AccSLDLRelRepository.GetByIdAsync(id);

            if (AccSLDLRel is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccSLDLRelDto = Mapper.Map(AccSLDLRel);

            return OkResult( CustomMessage.DefaultMessage , AccSLDLRelDto);

        }
    }
}
