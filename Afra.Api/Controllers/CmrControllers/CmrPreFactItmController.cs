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

namespace Afra.Api.Controllers.CmrPreFactItmControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CmrPreFactItmController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CmrPreFactItmController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCmrPreFactItmCommand command)
        {
            command.Validate();

            var CmrPreFactItms = await _unitOfWork.CmrPreFactItmRepository.FindAsync(c => c.Id == command.Id);

            if (CmrPreFactItms.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCmrPreFactItm = Mapper.Map(command);
            await _unitOfWork.CmrPreFactItmRepository.AddAsync(newCmrPreFactItm);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCmrPreFactItmCommand command)
        {

            command.Validate();

            var CmrPreFactItm = await _unitOfWork.CmrPreFactItmRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CmrPreFactItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrPreFactItm = Mapper.Map(CmrPreFactItm, command);
            CmrPreFactItm.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CmrPreFactItm = await _unitOfWork.CmrPreFactItmRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CmrPreFactItm == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CmrPreFactItm.IsActive = false;
            CmrPreFactItm.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CmrPreFactItms = await _unitOfWork.CmrPreFactItmRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CmrPreFactItmsDto = Mapper.Map(CmrPreFactItms);

            return OkResult(CustomMessage.DefaultMessage, CmrPreFactItmsDto.ToPagingAndSorting(query), CmrPreFactItmsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CmrPreFactItm = await _unitOfWork.CmrPreFactItmRepository.GetByIdAsync(id);

            if (CmrPreFactItm is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CmrPreFactItmDto = Mapper.Map(CmrPreFactItm);

            return OkResult( CustomMessage.DefaultMessage , CmrPreFactItmDto);

        }
    }
}
