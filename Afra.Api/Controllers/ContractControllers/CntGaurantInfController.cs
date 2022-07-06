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

namespace Afra.Api.Controllers.CntGaurantInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntGaurantInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntGaurantInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntGaurantInfCommand command)
        {
            command.Validate();

            var CntGaurantInfs = await _unitOfWork.CntGaurantInfRepository.FindAsync(c => c.Id == command.Id);

            if (CntGaurantInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntGaurantInf = Mapper.Map(command);
            await _unitOfWork.CntGaurantInfRepository.AddAsync(newCntGaurantInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntGaurantInfCommand command)
        {

            command.Validate();

            var CntGaurantInf = await _unitOfWork.CntGaurantInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntGaurantInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntGaurantInf = Mapper.Map(CntGaurantInf, command);
            CntGaurantInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntGaurantInf = await _unitOfWork.CntGaurantInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntGaurantInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntGaurantInf.IsActive = false;
            CntGaurantInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntGaurantInfs = await _unitOfWork.CntGaurantInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntGaurantInfsDto = Mapper.Map(CntGaurantInfs);

            return OkResult(CustomMessage.DefaultMessage, CntGaurantInfsDto.ToPagingAndSorting(query), CntGaurantInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntGaurantInf = await _unitOfWork.CntGaurantInfRepository.GetByIdAsync(id);

            if (CntGaurantInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntGaurantInfDto = Mapper.Map(CntGaurantInf);

            return OkResult( CustomMessage.DefaultMessage , CntGaurantInfDto);

        }
    }
}
