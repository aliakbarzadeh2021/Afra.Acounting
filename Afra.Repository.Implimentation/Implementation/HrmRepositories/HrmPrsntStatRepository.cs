using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmPrsntStatRepository : Repository<HrmPrsntStat> , IHrmPrsntStatRepository
    {
        public HrmPrsntStatRepository(DataContext context) : base(context)
        {
        }
    }
}
