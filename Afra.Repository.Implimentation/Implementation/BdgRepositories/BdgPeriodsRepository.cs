using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgPeriodsRepository : Repository<BdgPeriods> , IBdgPeriodsRepository
    {
        public BdgPeriodsRepository(DataContext context) : base(context)
        {
        }
    }
}
