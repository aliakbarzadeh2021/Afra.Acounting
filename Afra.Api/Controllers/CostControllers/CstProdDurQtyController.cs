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

namespace Afra.Api.Controllers.CstProdDurQtyControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CstProdDurQtyController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CstProdDurQtyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCstProdDurQtyCommand command)
        {
            command.Validate();

            var CstProdDurQtys = await _unitOfWork.CstProdDurQtyRepository.FindAsync(c => c.Id == command.Id);

            if (CstProdDurQtys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCstProdDurQty = Mapper.Map(command);
            await _unitOfWork.CstProdDurQtyRepository.AddAsync(newCstProdDurQty);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCstProdDurQtyCommand command)
        {

            command.Validate();

            var CstProdDurQty = await _unitOfWork.CstProdDurQtyRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CstProdDurQty == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstProdDurQty = Mapper.Map(CstProdDurQty, command);
            CstProdDurQty.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CstProdDurQty = await _unitOfWork.CstProdDurQtyRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CstProdDurQty == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CstProdDurQty.IsActive = false;
            CstProdDurQty.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CstProdDurQtys = await _unitOfWork.CstProdDurQtyRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CstProdDurQtysDto = Mapper.Map(CstProdDurQtys);

            return OkResult(CustomMessage.DefaultMessage, CstProdDurQtysDto.ToPagingAndSorting(query), CstProdDurQtysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CstProdDurQty = await _unitOfWork.CstProdDurQtyRepository.GetByIdAsync(id);

            if (CstProdDurQty is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CstProdDurQtyDto = Mapper.Map(CstProdDurQty);

            return OkResult( CustomMessage.DefaultMessage , CstProdDurQtyDto);

        }
    }
}
