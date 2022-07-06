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

namespace Afra.Api.Controllers.UsrTestGridControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrTestGridController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrTestGridController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrTestGridCommand command)
        {
            command.Validate();

            var UsrTestGrids = await _unitOfWork.UsrTestGridRepository.FindAsync(c => c.Id == command.Id);

            if (UsrTestGrids.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrTestGrid = Mapper.Map(command);
            await _unitOfWork.UsrTestGridRepository.AddAsync(newUsrTestGrid);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrTestGridCommand command)
        {

            command.Validate();

            var UsrTestGrid = await _unitOfWork.UsrTestGridRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrTestGrid == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrTestGrid = Mapper.Map(UsrTestGrid, command);
            UsrTestGrid.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrTestGrid = await _unitOfWork.UsrTestGridRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrTestGrid == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrTestGrid.IsActive = false;
            UsrTestGrid.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrTestGrids = await _unitOfWork.UsrTestGridRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrTestGridsDto = Mapper.Map(UsrTestGrids);

            return OkResult(CustomMessage.DefaultMessage, UsrTestGridsDto.ToPagingAndSorting(query), UsrTestGridsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrTestGrid = await _unitOfWork.UsrTestGridRepository.GetByIdAsync(id);

            if (UsrTestGrid is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrTestGridDto = Mapper.Map(UsrTestGrid);

            return OkResult( CustomMessage.DefaultMessage , UsrTestGridDto);

        }
    }
}
