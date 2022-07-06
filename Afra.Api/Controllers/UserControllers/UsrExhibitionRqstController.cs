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

namespace Afra.Api.Controllers.UsrExhibitionRqstControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsrExhibitionRqstController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsrExhibitionRqstController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUsrExhibitionRqstCommand command)
        {
            command.Validate();

            var UsrExhibitionRqsts = await _unitOfWork.UsrExhibitionRqstRepository.FindAsync(c => c.Id == command.Id);

            if (UsrExhibitionRqsts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUsrExhibitionRqst = Mapper.Map(command);
            await _unitOfWork.UsrExhibitionRqstRepository.AddAsync(newUsrExhibitionRqst);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUsrExhibitionRqstCommand command)
        {

            command.Validate();

            var UsrExhibitionRqst = await _unitOfWork.UsrExhibitionRqstRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UsrExhibitionRqst == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrExhibitionRqst = Mapper.Map(UsrExhibitionRqst, command);
            UsrExhibitionRqst.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UsrExhibitionRqst = await _unitOfWork.UsrExhibitionRqstRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UsrExhibitionRqst == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UsrExhibitionRqst.IsActive = false;
            UsrExhibitionRqst.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UsrExhibitionRqsts = await _unitOfWork.UsrExhibitionRqstRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsrExhibitionRqstsDto = Mapper.Map(UsrExhibitionRqsts);

            return OkResult(CustomMessage.DefaultMessage, UsrExhibitionRqstsDto.ToPagingAndSorting(query), UsrExhibitionRqstsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UsrExhibitionRqst = await _unitOfWork.UsrExhibitionRqstRepository.GetByIdAsync(id);

            if (UsrExhibitionRqst is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UsrExhibitionRqstDto = Mapper.Map(UsrExhibitionRqst);

            return OkResult( CustomMessage.DefaultMessage , UsrExhibitionRqstDto);

        }
    }
}
