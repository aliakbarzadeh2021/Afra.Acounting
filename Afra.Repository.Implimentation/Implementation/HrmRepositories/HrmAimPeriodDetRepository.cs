using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmAimPeriodDetRepository : Repository<HrmAimPeriodDet> , IHrmAimPeriodDetRepository
    {
        public HrmAimPeriodDetRepository(DataContext context) : base(context)
        {
        }
    }
}
