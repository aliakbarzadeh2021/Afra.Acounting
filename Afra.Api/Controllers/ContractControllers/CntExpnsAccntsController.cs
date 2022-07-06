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

namespace Afra.Api.Controllers.CntExpnsAccntsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntExpnsAccntsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntExpnsAccntsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntExpnsAccntsCommand command)
        {
            command.Validate();

            var CntExpnsAccntss = await _unitOfWork.CntExpnsAccntsRepository.FindAsync(c => c.Id == command.Id);

            if (CntExpnsAccntss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntExpnsAccnts = Mapper.Map(command);
            await _unitOfWork.CntExpnsAccntsRepository.AddAsync(newCntExpnsAccnts);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntExpnsAccntsCommand command)
        {

            command.Validate();

            var CntExpnsAccnts = await _unitOfWork.CntExpnsAccntsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntExpnsAccnts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpnsAccnts = Mapper.Map(CntExpnsAccnts, command);
            CntExpnsAccnts.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntExpnsAccnts = await _unitOfWork.CntExpnsAccntsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntExpnsAccnts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpnsAccnts.IsActive = false;
            CntExpnsAccnts.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntExpnsAccntss = await _unitOfWork.CntExpnsAccntsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntExpnsAccntssDto = Mapper.Map(CntExpnsAccntss);

            return OkResult(CustomMessage.DefaultMessage, CntExpnsAccntssDto.ToPagingAndSorting(query), CntExpnsAccntssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntExpnsAccnts = await _unitOfWork.CntExpnsAccntsRepository.GetByIdAsync(id);

            if (CntExpnsAccnts is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntExpnsAccntsDto = Mapper.Map(CntExpnsAccnts);

            return OkResult( CustomMessage.DefaultMessage , CntExpnsAccntsDto);

        }
    }
}
