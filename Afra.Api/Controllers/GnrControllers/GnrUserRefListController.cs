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

namespace Afra.Api.Controllers.GnrUserRefListControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrUserRefListController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrUserRefListController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrUserRefListCommand command)
        {
            command.Validate();

            var GnrUserRefLists = await _unitOfWork.GnrUserRefListRepository.FindAsync(c => c.Id == command.Id);

            if (GnrUserRefLists.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrUserRefList = Mapper.Map(command);
            await _unitOfWork.GnrUserRefListRepository.AddAsync(newGnrUserRefList);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrUserRefListCommand command)
        {

            command.Validate();

            var GnrUserRefList = await _unitOfWork.GnrUserRefListRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrUserRefList == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserRefList = Mapper.Map(GnrUserRefList, command);
            GnrUserRefList.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrUserRefList = await _unitOfWork.GnrUserRefListRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrUserRefList == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrUserRefList.IsActive = false;
            GnrUserRefList.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrUserRefLists = await _unitOfWork.GnrUserRefListRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrUserRefListsDto = Mapper.Map(GnrUserRefLists);

            return OkResult(CustomMessage.DefaultMessage, GnrUserRefListsDto.ToPagingAndSorting(query), GnrUserRefListsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrUserRefList = await _unitOfWork.GnrUserRefListRepository.GetByIdAsync(id);

            if (GnrUserRefList is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrUserRefListDto = Mapper.Map(GnrUserRefList);

            return OkResult( CustomMessage.DefaultMessage , GnrUserRefListDto);

        }
    }
}
