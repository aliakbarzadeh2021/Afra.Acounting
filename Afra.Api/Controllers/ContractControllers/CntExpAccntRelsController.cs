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

namespace Afra.Api.Controllers.CntExpAccntRelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntExpAccntRelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntExpAccntRelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntExpAccntRelsCommand command)
        {
            command.Validate();

            var CntExpAccntRelss = await _unitOfWork.CntExpAccntRelsRepository.FindAsync(c => c.Id == command.Id);

            if (CntExpAccntRelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntExpAccntRels = Mapper.Map(command);
            await _unitOfWork.CntExpAccntRelsRepository.AddAsync(newCntExpAccntRels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntExpAccntRelsCommand command)
        {

            command.Validate();

            var CntExpAccntRels = await _unitOfWork.CntExpAccntRelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntExpAccntRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpAccntRels = Mapper.Map(CntExpAccntRels, command);
            CntExpAccntRels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntExpAccntRels = await _unitOfWork.CntExpAccntRelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntExpAccntRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntExpAccntRels.IsActive = false;
            CntExpAccntRels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntExpAccntRelss = await _unitOfWork.CntExpAccntRelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntExpAccntRelssDto = Mapper.Map(CntExpAccntRelss);

            return OkResult(CustomMessage.DefaultMessage, CntExpAccntRelssDto.ToPagingAndSorting(query), CntExpAccntRelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntExpAccntRels = await _unitOfWork.CntExpAccntRelsRepository.GetByIdAsync(id);

            if (CntExpAccntRels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntExpAccntRelsDto = Mapper.Map(CntExpAccntRels);

            return OkResult( CustomMessage.DefaultMessage , CntExpAccntRelsDto);

        }
    }
}
