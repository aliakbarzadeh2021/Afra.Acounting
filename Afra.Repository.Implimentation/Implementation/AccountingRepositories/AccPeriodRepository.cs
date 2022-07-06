using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccPeriodRepository : Repository<AccPeriod> , IAccPeriodRepository
    {
        public AccPeriodRepository(DataContext context) : base(context)
        {
        }
    }
}
