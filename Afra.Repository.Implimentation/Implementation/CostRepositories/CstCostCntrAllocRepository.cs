using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstCostCntrAllocRepository : Repository<CstCostCntrAlloc> , ICstCostCntrAllocRepository
    {
        public CstCostCntrAllocRepository(DataContext context) : base(context)
        {
        }
    }
}
