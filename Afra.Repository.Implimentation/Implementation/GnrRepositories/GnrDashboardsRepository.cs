using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrDashboardsRepository : Repository<GnrDashboards> , IGnrDashboardsRepository
    {
        public GnrDashboardsRepository(DataContext context) : base(context)
        {
        }
    }
}
