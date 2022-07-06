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

namespace Afra.Api.Controllers.CntDeliveryInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntDeliveryInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntDeliveryInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntDeliveryInfCommand command)
        {
            command.Validate();

            var CntDeliveryInfs = await _unitOfWork.CntDeliveryInfRepository.FindAsync(c => c.Id == command.Id);

            if (CntDeliveryInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntDeliveryInf = Mapper.Map(command);
            await _unitOfWork.CntDeliveryInfRepository.AddAsync(newCntDeliveryInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntDeliveryInfCommand command)
        {

            command.Validate();

            var CntDeliveryInf = await _unitOfWork.CntDeliveryInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntDeliveryInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntDeliveryInf = Mapper.Map(CntDeliveryInf, command);
            CntDeliveryInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntDeliveryInf = await _unitOfWork.CntDeliveryInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntDeliveryInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntDeliveryInf.IsActive = false;
            CntDeliveryInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntDeliveryInfs = await _unitOfWork.CntDeliveryInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntDeliveryInfsDto = Mapper.Map(CntDeliveryInfs);

            return OkResult(CustomMessage.DefaultMessage, CntDeliveryInfsDto.ToPagingAndSorting(query), CntDeliveryInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntDeliveryInf = await _unitOfWork.CntDeliveryInfRepository.GetByIdAsync(id);

            if (CntDeliveryInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntDeliveryInfDto = Mapper.Map(CntDeliveryInf);

            return OkResult( CustomMessage.DefaultMessage , CntDeliveryInfDto);

        }
    }
}
