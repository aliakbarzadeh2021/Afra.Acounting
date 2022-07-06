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

namespace Afra.Api.Controllers.CntContractsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CntContractsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CntContractsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCntContractsCommand command)
        {
            command.Validate();

            var CntContractss = await _unitOfWork.CntContractsRepository.FindAsync(c => c.Id == command.Id);

            if (CntContractss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCntContracts = Mapper.Map(command);
            await _unitOfWork.CntContractsRepository.AddAsync(newCntContracts);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCntContractsCommand command)
        {

            command.Validate();

            var CntContracts = await _unitOfWork.CntContractsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CntContracts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContracts = Mapper.Map(CntContracts, command);
            CntContracts.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CntContracts = await _unitOfWork.CntContractsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CntContracts == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CntContracts.IsActive = false;
            CntContracts.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CntContractss = await _unitOfWork.CntContractsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CntContractssDto = Mapper.Map(CntContractss);

            return OkResult(CustomMessage.DefaultMessage, CntContractssDto.ToPagingAndSorting(query), CntContractssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CntContracts = await _unitOfWork.CntContractsRepository.GetByIdAsync(id);

            if (CntContracts is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CntContractsDto = Mapper.Map(CntContracts);

            return OkResult( CustomMessage.DefaultMessage , CntContractsDto);

        }
    }
}
