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

namespace Afra.Api.Controllers.CstMatQtyControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstMatQtyController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstMatQtyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstMatQtyCommand command)
        {
            command.Validate();

            var CstMatQtys = await _unitOfWork.CstMatQtyRepository.FindAsync(c => c.Id == command.Id);

            if (CstMatQtys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstMatQty = Mapper.Map(command);
            await _unitOfWork.CstMatQtyRepository.AddAsync(newCstMatQty);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstMatQtyCommand command)
        {

            command.Validate();

            var CstMatQty = await _unitOfWork.CstMatQtyRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstMatQty == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstMatQty = Mapper.Map(CstMatQty, command);
            CstMatQty.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstMatQty = await _unitOfWork.CstMatQtyRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstMatQty == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstMatQty.IsActive = false;
            CstMatQty.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstMatQtys = await _unitOfWork.CstMatQtyRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstMatQtysDto = Mapper.Map(CstMatQtys);

            return OkResult(CustomMessage.DefaultMessage, CstMatQtysDto.ToPagingAndSorting(query), CstMatQtysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstMatQty = await _unitOfWork.CstMatQtyRepository.GetByIdAsync(id);

            if (CstMatQty is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstMatQtyDto = Mapper.Map(CstMatQty);

            return OkResult( CustomMessage.DefaultMessage , CstMatQtyDto);

        }
    }
}
