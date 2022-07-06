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

namespace Afra.Api.Controllers.CntContRatioControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntContRatioController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntContRatioController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntContRatioCommand command)
        {
            command.Validate();

            var CntContRatios = await _unitOfWork.CntContRatioRepository.FindAsync(c => c.Id == command.Id);

            if (CntContRatios.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntContRatio = Mapper.Map(command);
            await _unitOfWork.CntContRatioRepository.AddAsync(newCntContRatio);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntContRatioCommand command)
        {

            command.Validate();

            var CntContRatio = await _unitOfWork.CntContRatioRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntContRatio == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContRatio = Mapper.Map(CntContRatio, command);
            CntContRatio.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntContRatio = await _unitOfWork.CntContRatioRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntContRatio == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContRatio.IsActive = false;
            CntContRatio.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntContRatios = await _unitOfWork.CntContRatioRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntContRatiosDto = Mapper.Map(CntContRatios);

            return OkResult(CustomMessage.DefaultMessage, CntContRatiosDto.ToPagingAndSorting(query), CntContRatiosDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntContRatio = await _unitOfWork.CntContRatioRepository.GetByIdAsync(id);

            if (CntContRatio is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntContRatioDto = Mapper.Map(CntContRatio);

            return OkResult( CustomMessage.DefaultMessage , CntContRatioDto);

        }
    }
}
