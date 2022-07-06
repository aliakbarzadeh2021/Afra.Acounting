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

namespace Afra.Api.Controllers.CmrContItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrContItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrContItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrContItmCommand command)
        {
            command.Validate();

            var CmrContItms = await _unitOfWork.CmrContItmRepository.FindAsync(c => c.Id == command.Id);

            if (CmrContItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrContItm = Mapper.Map(command);
            await _unitOfWork.CmrContItmRepository.AddAsync(newCmrContItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrContItmCommand command)
        {

            command.Validate();

            var CmrContItm = await _unitOfWork.CmrContItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrContItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrContItm = Mapper.Map(CmrContItm, command);
            CmrContItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrContItm = await _unitOfWork.CmrContItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrContItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrContItm.IsActive = false;
            CmrContItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrContItms = await _unitOfWork.CmrContItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrContItmsDto = Mapper.Map(CmrContItms);

            return OkResult(CustomMessage.DefaultMessage, CmrContItmsDto.ToPagingAndSorting(query), CmrContItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrContItm = await _unitOfWork.CmrContItmRepository.GetByIdAsync(id);

            if (CmrContItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrContItmDto = Mapper.Map(CmrContItm);

            return OkResult( CustomMessage.DefaultMessage , CmrContItmDto);

        }
    }
}
