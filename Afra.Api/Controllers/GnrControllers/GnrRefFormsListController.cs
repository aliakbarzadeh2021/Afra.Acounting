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

namespace Afra.Api.Controllers.GnrRefFormsListControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrRefFormsListController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrRefFormsListController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrRefFormsListCommand command)
        {
            command.Validate();

            var GnrRefFormsLists = await _unitOfWork.GnrRefFormsListRepository.FindAsync(c => c.Id == command.Id);

            if (GnrRefFormsLists.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrRefFormsList = Mapper.Map(command);
            await _unitOfWork.GnrRefFormsListRepository.AddAsync(newGnrRefFormsList);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrRefFormsListCommand command)
        {

            command.Validate();

            var GnrRefFormsList = await _unitOfWork.GnrRefFormsListRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrRefFormsList == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrRefFormsList = Mapper.Map(GnrRefFormsList, command);
            GnrRefFormsList.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrRefFormsList = await _unitOfWork.GnrRefFormsListRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrRefFormsList == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrRefFormsList.IsActive = false;
            GnrRefFormsList.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrRefFormsLists = await _unitOfWork.GnrRefFormsListRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrRefFormsListsDto = Mapper.Map(GnrRefFormsLists);

            return OkResult(CustomMessage.DefaultMessage, GnrRefFormsListsDto.ToPagingAndSorting(query), GnrRefFormsListsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrRefFormsList = await _unitOfWork.GnrRefFormsListRepository.GetByIdAsync(id);

            if (GnrRefFormsList is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrRefFormsListDto = Mapper.Map(GnrRefFormsList);

            return OkResult( CustomMessage.DefaultMessage , GnrRefFormsListDto);

        }
    }
}
