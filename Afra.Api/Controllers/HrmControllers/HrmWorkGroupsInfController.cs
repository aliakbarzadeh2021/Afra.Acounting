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

namespace Afra.Api.Controllers.HrmWorkGroupsInfControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmWorkGroupsInfController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmWorkGroupsInfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmWorkGroupsInfCommand command)
        {
            command.Validate();

            var HrmWorkGroupsInfs = await _unitOfWork.HrmWorkGroupsInfRepository.FindAsync(c => c.Id == command.Id);

            if (HrmWorkGroupsInfs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmWorkGroupsInf = Mapper.Map(command);
            await _unitOfWork.HrmWorkGroupsInfRepository.AddAsync(newHrmWorkGroupsInf);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmWorkGroupsInfCommand command)
        {

            command.Validate();

            var HrmWorkGroupsInf = await _unitOfWork.HrmWorkGroupsInfRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmWorkGroupsInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmWorkGroupsInf = Mapper.Map(HrmWorkGroupsInf, command);
            HrmWorkGroupsInf.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmWorkGroupsInf = await _unitOfWork.HrmWorkGroupsInfRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmWorkGroupsInf == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmWorkGroupsInf.IsActive = false;
            HrmWorkGroupsInf.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmWorkGroupsInfs = await _unitOfWork.HrmWorkGroupsInfRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmWorkGroupsInfsDto = Mapper.Map(HrmWorkGroupsInfs);

            return OkResult(CustomMessage.DefaultMessage, HrmWorkGroupsInfsDto.ToPagingAndSorting(query), HrmWorkGroupsInfsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmWorkGroupsInf = await _unitOfWork.HrmWorkGroupsInfRepository.GetByIdAsync(id);

            if (HrmWorkGroupsInf is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmWorkGroupsInfDto = Mapper.Map(HrmWorkGroupsInf);

            return OkResult( CustomMessage.DefaultMessage , HrmWorkGroupsInfDto);

        }
    }
}
