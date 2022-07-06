using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmCalenderDetRepository : Repository<HrmCalenderDet> , IHrmCalenderDetRepository
    {
        public HrmCalenderDetRepository(DataContext context) : base(context)
        {
        }
    }
}
