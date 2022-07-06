using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayValStatsRepository : Repository<PayValStats> , IPayValStatsRepository
    {
        public PayValStatsRepository(DataContext context) : base(context)
        {
        }
    }
}
