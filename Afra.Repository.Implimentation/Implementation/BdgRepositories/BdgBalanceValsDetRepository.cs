using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgBalanceValsDetRepository : Repository<BdgBalanceValsDet> , IBdgBalanceValsDetRepository
    {
        public BdgBalanceValsDetRepository(DataContext context) : base(context)
        {
        }
    }
}
