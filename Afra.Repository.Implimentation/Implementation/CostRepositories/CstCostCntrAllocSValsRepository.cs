using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstCostCntrAllocSValsRepository : Repository<CstCostCntrAllocSVals> , ICstCostCntrAllocSValsRepository
    {
        public CstCostCntrAllocSValsRepository(DataContext context) : base(context)
        {
        }
    }
}
