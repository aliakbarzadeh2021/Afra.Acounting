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

namespace Afra.Api.Controllers.BdgHrmBaseControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgHrmBaseController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgHrmBaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgHrmBaseCommand command)
        {
            command.Validate();

            var BdgHrmBases = await _unitOfWork.BdgHrmBaseRepository.FindAsync(c => c.Id == command.Id);

            if (BdgHrmBases.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgHrmBase = Mapper.Map(command);
            await _unitOfWork.BdgHrmBaseRepository.AddAsync(newBdgHrmBase);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgHrmBaseCommand command)
        {

            command.Validate();

            var BdgHrmBase = await _unitOfWork.BdgHrmBaseRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgHrmBase == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgHrmBase = Mapper.Map(BdgHrmBase, command);
            BdgHrmBase.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgHrmBase = await _unitOfWork.BdgHrmBaseRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgHrmBase == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgHrmBase.IsActive = false;
            BdgHrmBase.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgHrmBases = await _unitOfWork.BdgHrmBaseRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgHrmBasesDto = Mapper.Map(BdgHrmBases);

            return OkResult(CustomMessage.DefaultMessage, BdgHrmBasesDto.ToPagingAndSorting(query), BdgHrmBasesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgHrmBase = await _unitOfWork.BdgHrmBaseRepository.GetByIdAsync(id);

            if (BdgHrmBase is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgHrmBaseDto = Mapper.Map(BdgHrmBase);

            return OkResult( CustomMessage.DefaultMessage , BdgHrmBaseDto);

        }
    }
}
