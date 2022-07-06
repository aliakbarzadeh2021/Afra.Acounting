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

namespace Afra.Api.Controllers.AssetsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AssetsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AssetsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAssetsCommand command)
        {
            command.Validate();

            var Assetss = await _unitOfWork.AssetsRepository.FindAsync(c => c.Id == command.Id);

            if (Assetss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAssets = Mapper.Map(command);
            await _unitOfWork.AssetsRepository.AddAsync(newAssets);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAssetsCommand command)
        {

            command.Validate();

            var Assets = await _unitOfWork.AssetsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Assets == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Assets = Mapper.Map(Assets, command);
            Assets.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Assets = await _unitOfWork.AssetsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Assets == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Assets.IsActive = false;
            Assets.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Assetss = await _unitOfWork.AssetsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AssetssDto = Mapper.Map(Assetss);

            return OkResult(CustomMessage.DefaultMessage, AssetssDto.ToPagingAndSorting(query), AssetssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Assets = await _unitOfWork.AssetsRepository.GetByIdAsync(id);

            if (Assets is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AssetsDto = Mapper.Map(Assets);

            return OkResult( CustomMessage.DefaultMessage , AssetsDto);

        }
    }
}
