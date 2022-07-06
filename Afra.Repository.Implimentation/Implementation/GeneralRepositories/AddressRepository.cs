using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AddressRepository : Repository<Address> , IAddressRepository
    {
        public AddressRepository(DataContext context) : base(context)
        {
        }
    }
}
