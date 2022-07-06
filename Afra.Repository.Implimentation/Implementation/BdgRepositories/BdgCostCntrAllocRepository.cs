using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgCostCntrAllocRepository : Repository<BdgCostCntrAlloc> , IBdgCostCntrAllocRepository
    {
        public BdgCostCntrAllocRepository(DataContext context) : base(context)
        {
        }
    }
}
