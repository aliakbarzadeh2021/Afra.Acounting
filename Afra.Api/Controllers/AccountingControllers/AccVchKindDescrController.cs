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

namespace Afra.Api.Controllers.AccVchKindDescrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccVchKindDescrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccVchKindDescrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccVchKindDescrCommand command)
        {
            command.Validate();

            var AccVchKindDescrs = await _unitOfWork.AccVchKindDescrRepository.FindAsync(c => c.Id == command.Id);

            if (AccVchKindDescrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccVchKindDescr = Mapper.Map(command);
            await _unitOfWork.AccVchKindDescrRepository.AddAsync(newAccVchKindDescr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccVchKindDescrCommand command)
        {

            command.Validate();

            var AccVchKindDescr = await _unitOfWork.AccVchKindDescrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccVchKindDescr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccVchKindDescr = Mapper.Map(AccVchKindDescr, command);
            AccVchKindDescr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccVchKindDescr = await _unitOfWork.AccVchKindDescrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccVchKindDescr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccVchKindDescr.IsActive = false;
            AccVchKindDescr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccVchKindDescrs = await _unitOfWork.AccVchKindDescrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccVchKindDescrsDto = Mapper.Map(AccVchKindDescrs);

            return OkResult(CustomMessage.DefaultMessage, AccVchKindDescrsDto.ToPagingAndSorting(query), AccVchKindDescrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccVchKindDescr = await _unitOfWork.AccVchKindDescrRepository.GetByIdAsync(id);

            if (AccVchKindDescr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccVchKindDescrDto = Mapper.Map(AccVchKindDescr);

            return OkResult( CustomMessage.DefaultMessage , AccVchKindDescrDto);

        }
    }
}
