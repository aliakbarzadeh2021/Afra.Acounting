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

namespace Afra.Api.Controllers.BdgAssetsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BdgAssetsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BdgAssetsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBdgAssetsCommand command)
        {
            command.Validate();

            var BdgAssetss = await _unitOfWork.BdgAssetsRepository.FindAsync(c => c.Id == command.Id);

            if (BdgAssetss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBdgAssets = Mapper.Map(command);
            await _unitOfWork.BdgAssetsRepository.AddAsync(newBdgAssets);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBdgAssetsCommand command)
        {

            command.Validate();

            var BdgAssets = await _unitOfWork.BdgAssetsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BdgAssets == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgAssets = Mapper.Map(BdgAssets, command);
            BdgAssets.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BdgAssets = await _unitOfWork.BdgAssetsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BdgAssets == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BdgAssets.IsActive = false;
            BdgAssets.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BdgAssetss = await _unitOfWork.BdgAssetsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BdgAssetssDto = Mapper.Map(BdgAssetss);

            return OkResult(CustomMessage.DefaultMessage, BdgAssetssDto.ToPagingAndSorting(query), BdgAssetssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BdgAssets = await _unitOfWork.BdgAssetsRepository.GetByIdAsync(id);

            if (BdgAssets is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BdgAssetsDto = Mapper.Map(BdgAssets);

            return OkResult( CustomMessage.DefaultMessage , BdgAssetsDto);

        }
    }
}
