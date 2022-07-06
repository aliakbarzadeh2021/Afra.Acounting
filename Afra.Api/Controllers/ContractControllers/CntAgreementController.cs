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

namespace Afra.Api.Controllers.CntAgreementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntAgreementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntAgreementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntAgreementCommand command)
        {
            command.Validate();

            var CntAgreements = await _unitOfWork.CntAgreementRepository.FindAsync(c => c.Id == command.Id);

            if (CntAgreements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntAgreement = Mapper.Map(command);
            await _unitOfWork.CntAgreementRepository.AddAsync(newCntAgreement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntAgreementCommand command)
        {

            command.Validate();

            var CntAgreement = await _unitOfWork.CntAgreementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntAgreement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntAgreement = Mapper.Map(CntAgreement, command);
            CntAgreement.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntAgreement = await _unitOfWork.CntAgreementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntAgreement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntAgreement.IsActive = false;
            CntAgreement.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntAgreements = await _unitOfWork.CntAgreementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntAgreementsDto = Mapper.Map(CntAgreements);

            return OkResult(CustomMessage.DefaultMessage, CntAgreementsDto.ToPagingAndSorting(query), CntAgreementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntAgreement = await _unitOfWork.CntAgreementRepository.GetByIdAsync(id);

            if (CntAgreement is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntAgreementDto = Mapper.Map(CntAgreement);

            return OkResult( CustomMessage.DefaultMessage , CntAgreementDto);

        }
    }
}
