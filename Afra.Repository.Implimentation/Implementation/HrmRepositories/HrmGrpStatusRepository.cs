using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmGrpStatusRepository : Repository<HrmGrpStatus> , IHrmGrpStatusRepository
    {
        public HrmGrpStatusRepository(DataContext context) : base(context)
        {
        }
    }
}
