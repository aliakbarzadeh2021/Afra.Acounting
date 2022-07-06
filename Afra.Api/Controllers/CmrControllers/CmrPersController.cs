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

namespace Afra.Api.Controllers.CmrPersControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrPersController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrPersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrPersCommand command)
        {
            command.Validate();

            var CmrPerss = await _unitOfWork.CmrPersRepository.FindAsync(c => c.Id == command.Id);

            if (CmrPerss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrPers = Mapper.Map(command);
            await _unitOfWork.CmrPersRepository.AddAsync(newCmrPers);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrPersCommand command)
        {

            command.Validate();

            var CmrPers = await _unitOfWork.CmrPersRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrPers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrPers = Mapper.Map(CmrPers, command);
            CmrPers.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrPers = await _unitOfWork.CmrPersRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrPers == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrPers.IsActive = false;
            CmrPers.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrPerss = await _unitOfWork.CmrPersRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrPerssDto = Mapper.Map(CmrPerss);

            return OkResult(CustomMessage.DefaultMessage, CmrPerssDto.ToPagingAndSorting(query), CmrPerssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrPers = await _unitOfWork.CmrPersRepository.GetByIdAsync(id);

            if (CmrPers is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrPersDto = Mapper.Map(CmrPers);

            return OkResult( CustomMessage.DefaultMessage , CmrPersDto);

        }
    }
}
