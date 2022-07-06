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

namespace Afra.Api.Controllers.GnrUserStorageControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrUserStorageController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrUserStorageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrUserStorageCommand command)
        {
            command.Validate();

            var GnrUserStorages = await _unitOfWork.GnrUserStorageRepository.FindAsync(c => c.Id == command.Id);

            if (GnrUserStorages.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrUserStorage = Mapper.Map(command);
            await _unitOfWork.GnrUserStorageRepository.AddAsync(newGnrUserStorage);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrUserStorageCommand command)
        {

            command.Validate();

            var GnrUserStorage = await _unitOfWork.GnrUserStorageRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrUserStorage == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserStorage = Mapper.Map(GnrUserStorage, command);
            GnrUserStorage.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrUserStorage = await _unitOfWork.GnrUserStorageRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrUserStorage == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserStorage.IsActive = false;
            GnrUserStorage.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrUserStorages = await _unitOfWork.GnrUserStorageRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrUserStoragesDto = Mapper.Map(GnrUserStorages);

            return OkResult(CustomMessage.DefaultMessage, GnrUserStoragesDto.ToPagingAndSorting(query), GnrUserStoragesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrUserStorage = await _unitOfWork.GnrUserStorageRepository.GetByIdAsync(id);

            if (GnrUserStorage is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrUserStorageDto = Mapper.Map(GnrUserStorage);

            return OkResult( CustomMessage.DefaultMessage , GnrUserStorageDto);

        }
    }
}
