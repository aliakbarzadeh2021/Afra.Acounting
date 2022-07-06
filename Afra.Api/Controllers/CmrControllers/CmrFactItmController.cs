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

namespace Afra.Api.Controllers.CmrFactItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrFactItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrFactItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrFactItmCommand command)
        {
            command.Validate();

            var CmrFactItms = await _unitOfWork.CmrFactItmRepository.FindAsync(c => c.Id == command.Id);

            if (CmrFactItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrFactItm = Mapper.Map(command);
            await _unitOfWork.CmrFactItmRepository.AddAsync(newCmrFactItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrFactItmCommand command)
        {

            command.Validate();

            var CmrFactItm = await _unitOfWork.CmrFactItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrFactItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrFactItm = Mapper.Map(CmrFactItm, command);
            CmrFactItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrFactItm = await _unitOfWork.CmrFactItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrFactItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrFactItm.IsActive = false;
            CmrFactItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrFactItms = await _unitOfWork.CmrFactItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrFactItmsDto = Mapper.Map(CmrFactItms);

            return OkResult(CustomMessage.DefaultMessage, CmrFactItmsDto.ToPagingAndSorting(query), CmrFactItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrFactItm = await _unitOfWork.CmrFactItmRepository.GetByIdAsync(id);

            if (CmrFactItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrFactItmDto = Mapper.Map(CmrFactItm);

            return OkResult( CustomMessage.DefaultMessage , CmrFactItmDto);

        }
    }
}
