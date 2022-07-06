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

namespace Afra.Api.Controllers.BdgAssetsDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgAssetsDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgAssetsDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgAssetsDetCommand command)
        {
            command.Validate();

            var BdgAssetsDets = await _unitOfWork.BdgAssetsDetRepository.FindAsync(c => c.Id == command.Id);

            if (BdgAssetsDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgAssetsDet = Mapper.Map(command);
            await _unitOfWork.BdgAssetsDetRepository.AddAsync(newBdgAssetsDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgAssetsDetCommand command)
        {

            command.Validate();

            var BdgAssetsDet = await _unitOfWork.BdgAssetsDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgAssetsDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgAssetsDet = Mapper.Map(BdgAssetsDet, command);
            BdgAssetsDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgAssetsDet = await _unitOfWork.BdgAssetsDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgAssetsDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgAssetsDet.IsActive = false;
            BdgAssetsDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgAssetsDets = await _unitOfWork.BdgAssetsDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgAssetsDetsDto = Mapper.Map(BdgAssetsDets);

            return OkResult(CustomMessage.DefaultMessage, BdgAssetsDetsDto.ToPagingAndSorting(query), BdgAssetsDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgAssetsDet = await _unitOfWork.BdgAssetsDetRepository.GetByIdAsync(id);

            if (BdgAssetsDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgAssetsDetDto = Mapper.Map(BdgAssetsDet);

            return OkResult( CustomMessage.DefaultMessage , BdgAssetsDetDto);

        }
    }
}
