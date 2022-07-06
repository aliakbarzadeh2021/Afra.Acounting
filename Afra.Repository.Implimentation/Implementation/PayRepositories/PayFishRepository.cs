using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayFishRepository : Repository<PayFish> , IPayFishRepository
    {
        public PayFishRepository(DataContext context) : base(context)
        {
        }
    }
}
