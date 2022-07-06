using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstCostCntrElmntValsRepository : Repository<CstCostCntrElmntVals> , ICstCostCntrElmntValsRepository
    {
        public CstCostCntrElmntValsRepository(DataContext context) : base(context)
        {
        }
    }
}
