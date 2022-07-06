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

namespace Afra.Api.Controllers.CntSrvItemsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntSrvItemsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntSrvItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntSrvItemsCommand command)
        {
            command.Validate();

            var CntSrvItemss = await _unitOfWork.CntSrvItemsRepository.FindAsync(c => c.Id == command.Id);

            if (CntSrvItemss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntSrvItems = Mapper.Map(command);
            await _unitOfWork.CntSrvItemsRepository.AddAsync(newCntSrvItems);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntSrvItemsCommand command)
        {

            command.Validate();

            var CntSrvItems = await _unitOfWork.CntSrvItemsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntSrvItems == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntSrvItems = Mapper.Map(CntSrvItems, command);
            CntSrvItems.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntSrvItems = await _unitOfWork.CntSrvItemsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntSrvItems == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntSrvItems.IsActive = false;
            CntSrvItems.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntSrvItemss = await _unitOfWork.CntSrvItemsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntSrvItemssDto = Mapper.Map(CntSrvItemss);

            return OkResult(CustomMessage.DefaultMessage, CntSrvItemssDto.ToPagingAndSorting(query), CntSrvItemssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntSrvItems = await _unitOfWork.CntSrvItemsRepository.GetByIdAsync(id);

            if (CntSrvItems is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntSrvItemsDto = Mapper.Map(CntSrvItems);

            return OkResult( CustomMessage.DefaultMessage , CntSrvItemsDto);

        }
    }
}
