using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayValStatAmntRepository : Repository<PayValStatAmnt> , IPayValStatAmntRepository
    {
        public PayValStatAmntRepository(DataContext context) : base(context)
        {
        }
    }
}
