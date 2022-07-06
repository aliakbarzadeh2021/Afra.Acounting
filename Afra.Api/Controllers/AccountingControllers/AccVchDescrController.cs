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

namespace Afra.Api.Controllers.AccVchDescrControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccVchDescrController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccVchDescrController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccVchDescrCommand command)
        {
            command.Validate();

            var AccVchDescrs = await _unitOfWork.AccVchDescrRepository.FindAsync(c => c.Id == command.Id);

            if (AccVchDescrs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccVchDescr = Mapper.Map(command);
            await _unitOfWork.AccVchDescrRepository.AddAsync(newAccVchDescr);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccVchDescrCommand command)
        {

            command.Validate();

            var AccVchDescr = await _unitOfWork.AccVchDescrRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccVchDescr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccVchDescr = Mapper.Map(AccVchDescr, command);
            AccVchDescr.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccVchDescr = await _unitOfWork.AccVchDescrRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccVchDescr == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccVchDescr.IsActive = false;
            AccVchDescr.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccVchDescrs = await _unitOfWork.AccVchDescrRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccVchDescrsDto = Mapper.Map(AccVchDescrs);

            return OkResult(CustomMessage.DefaultMessage, AccVchDescrsDto.ToPagingAndSorting(query), AccVchDescrsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccVchDescr = await _unitOfWork.AccVchDescrRepository.GetByIdAsync(id);

            if (AccVchDescr is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccVchDescrDto = Mapper.Map(AccVchDescr);

            return OkResult( CustomMessage.DefaultMessage , AccVchDescrDto);

        }
    }
}
