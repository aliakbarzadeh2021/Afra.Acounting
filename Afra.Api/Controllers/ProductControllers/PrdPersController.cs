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

namespace Afra.Api.Controllers.PrdPersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdPersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdPersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdPersCommand command)
        {
            command.Validate();

            var PrdPerss = await _unitOfWork.PrdPersRepository.FindAsync(c => c.Id == command.Id);

            if (PrdPerss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdPers = Mapper.Map(command);
            await _unitOfWork.PrdPersRepository.AddAsync(newPrdPers);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdPersCommand command)
        {

            command.Validate();

            var PrdPers = await _unitOfWork.PrdPersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdPers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdPers = Mapper.Map(PrdPers, command);
            PrdPers.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdPers = await _unitOfWork.PrdPersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdPers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdPers.IsActive = false;
            PrdPers.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdPerss = await _unitOfWork.PrdPersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdPerssDto = Mapper.Map(PrdPerss);

            return OkResult(CustomMessage.DefaultMessage, PrdPerssDto.ToPagingAndSorting(query), PrdPerssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdPers = await _unitOfWork.PrdPersRepository.GetByIdAsync(id);

            if (PrdPers is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdPersDto = Mapper.Map(PrdPers);

            return OkResult( CustomMessage.DefaultMessage , PrdPersDto);

        }
    }
}
