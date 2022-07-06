using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayBuyBaseRepository : Repository<PayBuyBase> , IPayBuyBaseRepository
    {
        public PayBuyBaseRepository(DataContext context) : base(context)
        {
        }
    }
}
