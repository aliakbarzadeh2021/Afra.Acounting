using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmParamStatAmntRepository : Repository<HrmParamStatAmnt> , IHrmParamStatAmntRepository
    {
        public HrmParamStatAmntRepository(DataContext context) : base(context)
        {
        }
    }
}
