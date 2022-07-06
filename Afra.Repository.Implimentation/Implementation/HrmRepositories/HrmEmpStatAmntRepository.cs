using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmEmpStatAmntRepository : Repository<HrmEmpStatAmnt> , IHrmEmpStatAmntRepository
    {
        public HrmEmpStatAmntRepository(DataContext context) : base(context)
        {
        }
    }
}
