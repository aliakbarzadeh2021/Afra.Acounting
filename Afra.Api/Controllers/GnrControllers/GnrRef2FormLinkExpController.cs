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

namespace Afra.Api.Controllers.GnrRef2FormLinkExpControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GnrRef2FormLinkExpController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GnrRef2FormLinkExpController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGnrRef2FormLinkExpCommand command)
        {
            command.Validate();

            var GnrRef2FormLinkExps = await _unitOfWork.GnrRef2FormLinkExpRepository.FindAsync(c => c.Id == command.Id);

            if (GnrRef2FormLinkExps.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGnrRef2FormLinkExp = Mapper.Map(command);
            await _unitOfWork.GnrRef2FormLinkExpRepository.AddAsync(newGnrRef2FormLinkExp);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGnrRef2FormLinkExpCommand command)
        {

            command.Validate();

            var GnrRef2FormLinkExp = await _unitOfWork.GnrRef2FormLinkExpRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GnrRef2FormLinkExp == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrRef2FormLinkExp = Mapper.Map(GnrRef2FormLinkExp, command);
            GnrRef2FormLinkExp.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GnrRef2FormLinkExp = await _unitOfWork.GnrRef2FormLinkExpRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GnrRef2FormLinkExp == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GnrRef2FormLinkExp.IsActive = false;
            GnrRef2FormLinkExp.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GnrRef2FormLinkExps = await _unitOfWork.GnrRef2FormLinkExpRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GnrRef2FormLinkExpsDto = Mapper.Map(GnrRef2FormLinkExps);

            return OkResult(CustomMessage.DefaultMessage, GnrRef2FormLinkExpsDto.ToPagingAndSorting(query), GnrRef2FormLinkExpsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GnrRef2FormLinkExp = await _unitOfWork.GnrRef2FormLinkExpRepository.GetByIdAsync(id);

            if (GnrRef2FormLinkExp is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GnrRef2FormLinkExpDto = Mapper.Map(GnrRef2FormLinkExp);

            return OkResult( CustomMessage.DefaultMessage , GnrRef2FormLinkExpDto);

        }
    }
}
