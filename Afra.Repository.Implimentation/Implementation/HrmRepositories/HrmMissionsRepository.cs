using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmMissionsRepository : Repository<HrmMissions> , IHrmMissionsRepository
    {
        public HrmMissionsRepository(DataContext context) : base(context)
        {
        }
    }
}
