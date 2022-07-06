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

namespace Afra.Api.Controllers.GnrProcessDetArchControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrProcessDetArchController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrProcessDetArchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrProcessDetArchCommand command)
        {
            command.Validate();

            var GnrProcessDetArchs = await _unitOfWork.GnrProcessDetArchRepository.FindAsync(c => c.Id == command.Id);

            if (GnrProcessDetArchs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrProcessDetArch = Mapper.Map(command);
            await _unitOfWork.GnrProcessDetArchRepository.AddAsync(newGnrProcessDetArch);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrProcessDetArchCommand command)
        {

            command.Validate();

            var GnrProcessDetArch = await _unitOfWork.GnrProcessDetArchRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrProcessDetArch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrProcessDetArch = Mapper.Map(GnrProcessDetArch, command);
            GnrProcessDetArch.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrProcessDetArch = await _unitOfWork.GnrProcessDetArchRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrProcessDetArch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrProcessDetArch.IsActive = false;
            GnrProcessDetArch.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrProcessDetArchs = await _unitOfWork.GnrProcessDetArchRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrProcessDetArchsDto = Mapper.Map(GnrProcessDetArchs);

            return OkResult(CustomMessage.DefaultMessage, GnrProcessDetArchsDto.ToPagingAndSorting(query), GnrProcessDetArchsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrProcessDetArch = await _unitOfWork.GnrProcessDetArchRepository.GetByIdAsync(id);

            if (GnrProcessDetArch is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrProcessDetArchDto = Mapper.Map(GnrProcessDetArch);

            return OkResult( CustomMessage.DefaultMessage , GnrProcessDetArchDto);

        }
    }
}
