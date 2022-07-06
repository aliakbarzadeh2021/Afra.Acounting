using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayWorkLimitRepository : Repository<PayWorkLimit> , IPayWorkLimitRepository
    {
        public PayWorkLimitRepository(DataContext context) : base(context)
        {
        }
    }
}
