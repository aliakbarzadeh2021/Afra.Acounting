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

namespace Afra.Api.Controllers.GnrRefFormsListDetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrRefFormsListDetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrRefFormsListDetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrRefFormsListDetCommand command)
        {
            command.Validate();

            var GnrRefFormsListDets = await _unitOfWork.GnrRefFormsListDetRepository.FindAsync(c => c.Id == command.Id);

            if (GnrRefFormsListDets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrRefFormsListDet = Mapper.Map(command);
            await _unitOfWork.GnrRefFormsListDetRepository.AddAsync(newGnrRefFormsListDet);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrRefFormsListDetCommand command)
        {

            command.Validate();

            var GnrRefFormsListDet = await _unitOfWork.GnrRefFormsListDetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrRefFormsListDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrRefFormsListDet = Mapper.Map(GnrRefFormsListDet, command);
            GnrRefFormsListDet.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrRefFormsListDet = await _unitOfWork.GnrRefFormsListDetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrRefFormsListDet == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrRefFormsListDet.IsActive = false;
            GnrRefFormsListDet.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrRefFormsListDets = await _unitOfWork.GnrRefFormsListDetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrRefFormsListDetsDto = Mapper.Map(GnrRefFormsListDets);

            return OkResult(CustomMessage.DefaultMessage, GnrRefFormsListDetsDto.ToPagingAndSorting(query), GnrRefFormsListDetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrRefFormsListDet = await _unitOfWork.GnrRefFormsListDetRepository.GetByIdAsync(id);

            if (GnrRefFormsListDet is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrRefFormsListDetDto = Mapper.Map(GnrRefFormsListDet);

            return OkResult( CustomMessage.DefaultMessage , GnrRefFormsListDetDto);

        }
    }
}
