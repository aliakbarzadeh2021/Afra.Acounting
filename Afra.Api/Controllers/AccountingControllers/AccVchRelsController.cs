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

namespace Afra.Api.Controllers.AccVchRelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccVchRelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccVchRelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccVchRelsCommand command)
        {
            command.Validate();

            var AccVchRelss = await _unitOfWork.AccVchRelsRepository.FindAsync(c => c.Id == command.Id);

            if (AccVchRelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccVchRels = Mapper.Map(command);
            await _unitOfWork.AccVchRelsRepository.AddAsync(newAccVchRels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccVchRelsCommand command)
        {

            command.Validate();

            var AccVchRels = await _unitOfWork.AccVchRelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccVchRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccVchRels = Mapper.Map(AccVchRels, command);
            AccVchRels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccVchRels = await _unitOfWork.AccVchRelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccVchRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccVchRels.IsActive = false;
            AccVchRels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccVchRelss = await _unitOfWork.AccVchRelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccVchRelssDto = Mapper.Map(AccVchRelss);

            return OkResult(CustomMessage.DefaultMessage, AccVchRelssDto.ToPagingAndSorting(query), AccVchRelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccVchRels = await _unitOfWork.AccVchRelsRepository.GetByIdAsync(id);

            if (AccVchRels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccVchRelsDto = Mapper.Map(AccVchRels);

            return OkResult( CustomMessage.DefaultMessage , AccVchRelsDto);

        }
    }
}
