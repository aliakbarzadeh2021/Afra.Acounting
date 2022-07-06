using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgBalanceValRepository : Repository<BdgBalanceVal> , IBdgBalanceValRepository
    {
        public BdgBalanceValRepository(DataContext context) : base(context)
        {
        }
    }
}
