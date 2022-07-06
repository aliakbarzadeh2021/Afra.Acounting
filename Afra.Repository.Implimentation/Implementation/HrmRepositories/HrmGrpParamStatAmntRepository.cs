using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmGrpParamStatAmntRepository : Repository<HrmGrpParamStatAmnt> , IHrmGrpParamStatAmntRepository
    {
        public HrmGrpParamStatAmntRepository(DataContext context) : base(context)
        {
        }
    }
}
