using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgCostAllocDetRepository : Repository<BdgCostAllocDet> , IBdgCostAllocDetRepository
    {
        public BdgCostAllocDetRepository(DataContext context) : base(context)
        {
        }
    }
}
