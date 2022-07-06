using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstCostCntrAllocValsRepository : Repository<CstCostCntrAllocVals> , ICstCostCntrAllocValsRepository
    {
        public CstCostCntrAllocValsRepository(DataContext context) : base(context)
        {
        }
    }
}
