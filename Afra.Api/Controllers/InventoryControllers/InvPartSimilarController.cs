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

namespace Afra.Api.Controllers.InvPartSimilarControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvPartSimilarController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvPartSimilarController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvPartSimilarCommand command)
        {
            command.Validate();

            var InvPartSimilars = await _unitOfWork.InvPartSimilarRepository.FindAsync(c => c.Id == command.Id);

            if (InvPartSimilars.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvPartSimilar = Mapper.Map(command);
            await _unitOfWork.InvPartSimilarRepository.AddAsync(newInvPartSimilar);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvPartSimilarCommand command)
        {

            command.Validate();

            var InvPartSimilar = await _unitOfWork.InvPartSimilarRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvPartSimilar == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartSimilar = Mapper.Map(InvPartSimilar, command);
            InvPartSimilar.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvPartSimilar = await _unitOfWork.InvPartSimilarRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvPartSimilar == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvPartSimilar.IsActive = false;
            InvPartSimilar.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvPartSimilars = await _unitOfWork.InvPartSimilarRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvPartSimilarsDto = Mapper.Map(InvPartSimilars);

            return OkResult(CustomMessage.DefaultMessage, InvPartSimilarsDto.ToPagingAndSorting(query), InvPartSimilarsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvPartSimilar = await _unitOfWork.InvPartSimilarRepository.GetByIdAsync(id);

            if (InvPartSimilar is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvPartSimilarDto = Mapper.Map(InvPartSimilar);

            return OkResult( CustomMessage.DefaultMessage , InvPartSimilarDto);

        }
    }
}
