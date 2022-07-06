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

namespace Afra.Api.Controllers.CstProduceInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstProduceInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstProduceInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstProduceInfCommand command)
        {
            command.Validate();

            var CstProduceInfs = await _unitOfWork.CstProduceInfRepository.FindAsync(c => c.Id == command.Id);

            if (CstProduceInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstProduceInf = Mapper.Map(command);
            await _unitOfWork.CstProduceInfRepository.AddAsync(newCstProduceInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstProduceInfCommand command)
        {

            command.Validate();

            var CstProduceInf = await _unitOfWork.CstProduceInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstProduceInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstProduceInf = Mapper.Map(CstProduceInf, command);
            CstProduceInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstProduceInf = await _unitOfWork.CstProduceInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstProduceInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstProduceInf.IsActive = false;
            CstProduceInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstProduceInfs = await _unitOfWork.CstProduceInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstProduceInfsDto = Mapper.Map(CstProduceInfs);

            return OkResult(CustomMessage.DefaultMessage, CstProduceInfsDto.ToPagingAndSorting(query), CstProduceInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstProduceInf = await _unitOfWork.CstProduceInfRepository.GetByIdAsync(id);

            if (CstProduceInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstProduceInfDto = Mapper.Map(CstProduceInf);

            return OkResult( CustomMessage.DefaultMessage , CstProduceInfDto);

        }
    }
}
