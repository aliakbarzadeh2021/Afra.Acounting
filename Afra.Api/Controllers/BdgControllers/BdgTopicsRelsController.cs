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

namespace Afra.Api.Controllers.BdgTopicsRelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgTopicsRelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgTopicsRelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgTopicsRelsCommand command)
        {
            command.Validate();

            var BdgTopicsRelss = await _unitOfWork.BdgTopicsRelsRepository.FindAsync(c => c.Id == command.Id);

            if (BdgTopicsRelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgTopicsRels = Mapper.Map(command);
            await _unitOfWork.BdgTopicsRelsRepository.AddAsync(newBdgTopicsRels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgTopicsRelsCommand command)
        {

            command.Validate();

            var BdgTopicsRels = await _unitOfWork.BdgTopicsRelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgTopicsRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgTopicsRels = Mapper.Map(BdgTopicsRels, command);
            BdgTopicsRels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgTopicsRels = await _unitOfWork.BdgTopicsRelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgTopicsRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgTopicsRels.IsActive = false;
            BdgTopicsRels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgTopicsRelss = await _unitOfWork.BdgTopicsRelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgTopicsRelssDto = Mapper.Map(BdgTopicsRelss);

            return OkResult(CustomMessage.DefaultMessage, BdgTopicsRelssDto.ToPagingAndSorting(query), BdgTopicsRelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgTopicsRels = await _unitOfWork.BdgTopicsRelsRepository.GetByIdAsync(id);

            if (BdgTopicsRels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgTopicsRelsDto = Mapper.Map(BdgTopicsRels);

            return OkResult( CustomMessage.DefaultMessage , BdgTopicsRelsDto);

        }
    }
}
