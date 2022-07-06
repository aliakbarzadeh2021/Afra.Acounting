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

namespace Afra.Api.Controllers.CntExtendInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntExtendInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntExtendInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntExtendInfCommand command)
        {
            command.Validate();

            var CntExtendInfs = await _unitOfWork.CntExtendInfRepository.FindAsync(c => c.Id == command.Id);

            if (CntExtendInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntExtendInf = Mapper.Map(command);
            await _unitOfWork.CntExtendInfRepository.AddAsync(newCntExtendInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntExtendInfCommand command)
        {

            command.Validate();

            var CntExtendInf = await _unitOfWork.CntExtendInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntExtendInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExtendInf = Mapper.Map(CntExtendInf, command);
            CntExtendInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntExtendInf = await _unitOfWork.CntExtendInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntExtendInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExtendInf.IsActive = false;
            CntExtendInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntExtendInfs = await _unitOfWork.CntExtendInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntExtendInfsDto = Mapper.Map(CntExtendInfs);

            return OkResult(CustomMessage.DefaultMessage, CntExtendInfsDto.ToPagingAndSorting(query), CntExtendInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntExtendInf = await _unitOfWork.CntExtendInfRepository.GetByIdAsync(id);

            if (CntExtendInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntExtendInfDto = Mapper.Map(CntExtendInf);

            return OkResult( CustomMessage.DefaultMessage , CntExtendInfDto);

        }
    }
}
