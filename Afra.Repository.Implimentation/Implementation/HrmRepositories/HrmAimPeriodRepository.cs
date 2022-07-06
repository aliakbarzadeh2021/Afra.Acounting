using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmAimPeriodRepository : Repository<HrmAimPeriod> , IHrmAimPeriodRepository
    {
        public HrmAimPeriodRepository(DataContext context) : base(context)
        {
        }
    }
}
