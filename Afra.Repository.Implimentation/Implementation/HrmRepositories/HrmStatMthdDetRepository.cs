using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmStatMthdDetRepository : Repository<HrmStatMthdDet> , IHrmStatMthdDetRepository
    {
        public HrmStatMthdDetRepository(DataContext context) : base(context)
        {
        }
    }
}
