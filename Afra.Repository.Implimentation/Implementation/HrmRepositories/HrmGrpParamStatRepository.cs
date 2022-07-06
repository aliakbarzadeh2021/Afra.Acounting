using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmGrpParamStatRepository : Repository<HrmGrpParamStat> , IHrmGrpParamStatRepository
    {
        public HrmGrpParamStatRepository(DataContext context) : base(context)
        {
        }
    }
}
