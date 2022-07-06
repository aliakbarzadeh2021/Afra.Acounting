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

namespace Afra.Api.Controllers.CntAccRelsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntAccRelsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntAccRelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntAccRelsCommand command)
        {
            command.Validate();

            var CntAccRelss = await _unitOfWork.CntAccRelsRepository.FindAsync(c => c.Id == command.Id);

            if (CntAccRelss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntAccRels = Mapper.Map(command);
            await _unitOfWork.CntAccRelsRepository.AddAsync(newCntAccRels);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntAccRelsCommand command)
        {

            command.Validate();

            var CntAccRels = await _unitOfWork.CntAccRelsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntAccRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntAccRels = Mapper.Map(CntAccRels, command);
            CntAccRels.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntAccRels = await _unitOfWork.CntAccRelsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntAccRels == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntAccRels.IsActive = false;
            CntAccRels.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntAccRelss = await _unitOfWork.CntAccRelsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntAccRelssDto = Mapper.Map(CntAccRelss);

            return OkResult(CustomMessage.DefaultMessage, CntAccRelssDto.ToPagingAndSorting(query), CntAccRelssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntAccRels = await _unitOfWork.CntAccRelsRepository.GetByIdAsync(id);

            if (CntAccRels is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntAccRelsDto = Mapper.Map(CntAccRels);

            return OkResult( CustomMessage.DefaultMessage , CntAccRelsDto);

        }
    }
}
