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

namespace Afra.Api.Controllers.PrdOprDetPersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrdOprDetPersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrdOprDetPersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPrdOprDetPersCommand command)
        {
            command.Validate();

            var PrdOprDetPerss = await _unitOfWork.PrdOprDetPersRepository.FindAsync(c => c.Id == command.Id);

            if (PrdOprDetPerss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPrdOprDetPers = Mapper.Map(command);
            await _unitOfWork.PrdOprDetPersRepository.AddAsync(newPrdOprDetPers);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPrdOprDetPersCommand command)
        {

            command.Validate();

            var PrdOprDetPers = await _unitOfWork.PrdOprDetPersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PrdOprDetPers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdOprDetPers = Mapper.Map(PrdOprDetPers, command);
            PrdOprDetPers.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PrdOprDetPers = await _unitOfWork.PrdOprDetPersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PrdOprDetPers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PrdOprDetPers.IsActive = false;
            PrdOprDetPers.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PrdOprDetPerss = await _unitOfWork.PrdOprDetPersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PrdOprDetPerssDto = Mapper.Map(PrdOprDetPerss);

            return OkResult(CustomMessage.DefaultMessage, PrdOprDetPerssDto.ToPagingAndSorting(query), PrdOprDetPerssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PrdOprDetPers = await _unitOfWork.PrdOprDetPersRepository.GetByIdAsync(id);

            if (PrdOprDetPers is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PrdOprDetPersDto = Mapper.Map(PrdOprDetPers);

            return OkResult( CustomMessage.DefaultMessage , PrdOprDetPersDto);

        }
    }
}
