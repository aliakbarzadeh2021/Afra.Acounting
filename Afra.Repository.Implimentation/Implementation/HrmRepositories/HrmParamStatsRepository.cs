using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmParamStatsRepository : Repository<HrmParamStats> , IHrmParamStatsRepository
    {
        public HrmParamStatsRepository(DataContext context) : base(context)
        {
        }
    }
}
