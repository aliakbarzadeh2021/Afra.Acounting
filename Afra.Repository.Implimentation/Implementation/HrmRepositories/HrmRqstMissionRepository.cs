using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmRqstMissionRepository : Repository<HrmRqstMission> , IHrmRqstMissionRepository
    {
        public HrmRqstMissionRepository(DataContext context) : base(context)
        {
        }
    }
}
