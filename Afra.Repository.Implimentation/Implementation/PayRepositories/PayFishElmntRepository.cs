using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayFishElmntRepository : Repository<PayFishElmnt> , IPayFishElmntRepository
    {
        public PayFishElmntRepository(DataContext context) : base(context)
        {
        }
    }
}
