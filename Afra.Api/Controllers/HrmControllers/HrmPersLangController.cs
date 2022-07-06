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

namespace Afra.Api.Controllers.HrmPersLangControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HrmPersLangController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HrmPersLangController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHrmPersLangCommand command)
        {
            command.Validate();

            var HrmPersLangs = await _unitOfWork.HrmPersLangRepository.FindAsync(c => c.Id == command.Id);

            if (HrmPersLangs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHrmPersLang = Mapper.Map(command);
            await _unitOfWork.HrmPersLangRepository.AddAsync(newHrmPersLang);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHrmPersLangCommand command)
        {

            command.Validate();

            var HrmPersLang = await _unitOfWork.HrmPersLangRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HrmPersLang == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersLang = Mapper.Map(HrmPersLang, command);
            HrmPersLang.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HrmPersLang = await _unitOfWork.HrmPersLangRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HrmPersLang == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HrmPersLang.IsActive = false;
            HrmPersLang.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HrmPersLangs = await _unitOfWork.HrmPersLangRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HrmPersLangsDto = Mapper.Map(HrmPersLangs);

            return OkResult(CustomMessage.DefaultMessage, HrmPersLangsDto.ToPagingAndSorting(query), HrmPersLangsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HrmPersLang = await _unitOfWork.HrmPersLangRepository.GetByIdAsync(id);

            if (HrmPersLang is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HrmPersLangDto = Mapper.Map(HrmPersLang);

            return OkResult( CustomMessage.DefaultMessage , HrmPersLangDto);

        }
    }
}
