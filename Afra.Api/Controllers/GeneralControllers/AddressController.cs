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

namespace Afra.Api.Controllers.AddressControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AddressController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAddressCommand command)
        {
            command.Validate();

            var Addresss = await _unitOfWork.AddressRepository.FindAsync(c => c.Id == command.Id);

            if (Addresss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAddress = Mapper.Map(command);
            await _unitOfWork.AddressRepository.AddAsync(newAddress);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAddressCommand command)
        {

            command.Validate();

            var Address = await _unitOfWork.AddressRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Address == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Address = Mapper.Map(Address, command);
            Address.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Address = await _unitOfWork.AddressRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Address == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Address.IsActive = false;
            Address.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Addresss = await _unitOfWork.AddressRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AddresssDto = Mapper.Map(Addresss);

            return OkResult(CustomMessage.DefaultMessage, AddresssDto.ToPagingAndSorting(query), AddresssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Address = await _unitOfWork.AddressRepository.GetByIdAsync(id);

            if (Address is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AddressDto = Mapper.Map(Address);

            return OkResult( CustomMessage.DefaultMessage , AddressDto);

        }
    }
}
