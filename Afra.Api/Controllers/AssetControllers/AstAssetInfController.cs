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

namespace Afra.Api.Controllers.AstAssetInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AstAssetInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AstAssetInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAstAssetInfCommand command)
        {
            command.Validate();

            var AstAssetInfs = await _unitOfWork.AstAssetInfRepository.FindAsync(c => c.Id == command.Id);

            if (AstAssetInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAstAssetInf = Mapper.Map(command);
            await _unitOfWork.AstAssetInfRepository.AddAsync(newAstAssetInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAstAssetInfCommand command)
        {

            command.Validate();

            var AstAssetInf = await _unitOfWork.AstAssetInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AstAssetInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstAssetInf = Mapper.Map(AstAssetInf, command);
            AstAssetInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AstAssetInf = await _unitOfWork.AstAssetInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AstAssetInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AstAssetInf.IsActive = false;
            AstAssetInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AstAssetInfs = await _unitOfWork.AstAssetInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AstAssetInfsDto = Mapper.Map(AstAssetInfs);

            return OkResult(CustomMessage.DefaultMessage, AstAssetInfsDto.ToPagingAndSorting(query), AstAssetInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AstAssetInf = await _unitOfWork.AstAssetInfRepository.GetByIdAsync(id);

            if (AstAssetInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AstAssetInfDto = Mapper.Map(AstAssetInf);

            return OkResult( CustomMessage.DefaultMessage , AstAssetInfDto);

        }
    }
}
