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

namespace Afra.Api.Controllers.GnrProcessDetObjControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrProcessDetObjController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrProcessDetObjController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrProcessDetObjCommand command)
        {
            command.Validate();

            var GnrProcessDetObjs = await _unitOfWork.GnrProcessDetObjRepository.FindAsync(c => c.Id == command.Id);

            if (GnrProcessDetObjs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrProcessDetObj = Mapper.Map(command);
            await _unitOfWork.GnrProcessDetObjRepository.AddAsync(newGnrProcessDetObj);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrProcessDetObjCommand command)
        {

            command.Validate();

            var GnrProcessDetObj = await _unitOfWork.GnrProcessDetObjRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrProcessDetObj == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrProcessDetObj = Mapper.Map(GnrProcessDetObj, command);
            GnrProcessDetObj.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrProcessDetObj = await _unitOfWork.GnrProcessDetObjRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrProcessDetObj == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrProcessDetObj.IsActive = false;
            GnrProcessDetObj.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrProcessDetObjs = await _unitOfWork.GnrProcessDetObjRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrProcessDetObjsDto = Mapper.Map(GnrProcessDetObjs);

            return OkResult(CustomMessage.DefaultMessage, GnrProcessDetObjsDto.ToPagingAndSorting(query), GnrProcessDetObjsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrProcessDetObj = await _unitOfWork.GnrProcessDetObjRepository.GetByIdAsync(id);

            if (GnrProcessDetObj is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrProcessDetObjDto = Mapper.Map(GnrProcessDetObj);

            return OkResult( CustomMessage.DefaultMessage , GnrProcessDetObjDto);

        }
    }
}
