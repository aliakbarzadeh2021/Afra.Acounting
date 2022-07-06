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

namespace Afra.Api.Controllers.CmrOrdItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrOrdItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrOrdItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrOrdItmCommand command)
        {
            command.Validate();

            var CmrOrdItms = await _unitOfWork.CmrOrdItmRepository.FindAsync(c => c.Id == command.Id);

            if (CmrOrdItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrOrdItm = Mapper.Map(command);
            await _unitOfWork.CmrOrdItmRepository.AddAsync(newCmrOrdItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrOrdItmCommand command)
        {

            command.Validate();

            var CmrOrdItm = await _unitOfWork.CmrOrdItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrOrdItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrOrdItm = Mapper.Map(CmrOrdItm, command);
            CmrOrdItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrOrdItm = await _unitOfWork.CmrOrdItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrOrdItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrOrdItm.IsActive = false;
            CmrOrdItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrOrdItms = await _unitOfWork.CmrOrdItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrOrdItmsDto = Mapper.Map(CmrOrdItms);

            return OkResult(CustomMessage.DefaultMessage, CmrOrdItmsDto.ToPagingAndSorting(query), CmrOrdItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrOrdItm = await _unitOfWork.CmrOrdItmRepository.GetByIdAsync(id);

            if (CmrOrdItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrOrdItmDto = Mapper.Map(CmrOrdItm);

            return OkResult( CustomMessage.DefaultMessage , CmrOrdItmDto);

        }
    }
}
