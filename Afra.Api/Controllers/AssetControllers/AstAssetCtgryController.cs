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

namespace Afra.Api.Controllers.AstAssetCtgryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AstAssetCtgryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AstAssetCtgryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAstAssetCtgryCommand command)
        {
            command.Validate();

            var AstAssetCtgrys = await _unitOfWork.AstAssetCtgryRepository.FindAsync(c => c.Id == command.Id);

            if (AstAssetCtgrys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAstAssetCtgry = Mapper.Map(command);
            await _unitOfWork.AstAssetCtgryRepository.AddAsync(newAstAssetCtgry);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAstAssetCtgryCommand command)
        {

            command.Validate();

            var AstAssetCtgry = await _unitOfWork.AstAssetCtgryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AstAssetCtgry == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstAssetCtgry = Mapper.Map(AstAssetCtgry, command);
            AstAssetCtgry.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AstAssetCtgry = await _unitOfWork.AstAssetCtgryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AstAssetCtgry == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstAssetCtgry.IsActive = false;
            AstAssetCtgry.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AstAssetCtgrys = await _unitOfWork.AstAssetCtgryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AstAssetCtgrysDto = Mapper.Map(AstAssetCtgrys);

            return OkResult(CustomMessage.DefaultMessage, AstAssetCtgrysDto.ToPagingAndSorting(query), AstAssetCtgrysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AstAssetCtgry = await _unitOfWork.AstAssetCtgryRepository.GetByIdAsync(id);

            if (AstAssetCtgry is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AstAssetCtgryDto = Mapper.Map(AstAssetCtgry);

            return OkResult( CustomMessage.DefaultMessage , AstAssetCtgryDto);

        }
    }
}
