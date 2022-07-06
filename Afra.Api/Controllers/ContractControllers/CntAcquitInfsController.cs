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

namespace Afra.Api.Controllers.CntAcquitInfsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntAcquitInfsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntAcquitInfsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntAcquitInfsCommand command)
        {
            command.Validate();

            var CntAcquitInfss = await _unitOfWork.CntAcquitInfsRepository.FindAsync(c => c.Id == command.Id);

            if (CntAcquitInfss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntAcquitInfs = Mapper.Map(command);
            await _unitOfWork.CntAcquitInfsRepository.AddAsync(newCntAcquitInfs);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntAcquitInfsCommand command)
        {

            command.Validate();

            var CntAcquitInfs = await _unitOfWork.CntAcquitInfsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntAcquitInfs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntAcquitInfs = Mapper.Map(CntAcquitInfs, command);
            CntAcquitInfs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntAcquitInfs = await _unitOfWork.CntAcquitInfsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntAcquitInfs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntAcquitInfs.IsActive = false;
            CntAcquitInfs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntAcquitInfss = await _unitOfWork.CntAcquitInfsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntAcquitInfssDto = Mapper.Map(CntAcquitInfss);

            return OkResult(CustomMessage.DefaultMessage, CntAcquitInfssDto.ToPagingAndSorting(query), CntAcquitInfssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntAcquitInfs = await _unitOfWork.CntAcquitInfsRepository.GetByIdAsync(id);

            if (CntAcquitInfs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntAcquitInfsDto = Mapper.Map(CntAcquitInfs);

            return OkResult( CustomMessage.DefaultMessage , CntAcquitInfsDto);

        }
    }
}
