using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class StkPeriodsRepository : Repository<StkPeriods> , IStkPeriodsRepository
    {
        public StkPeriodsRepository(DataContext context) : base(context)
        {
        }
    }
}
