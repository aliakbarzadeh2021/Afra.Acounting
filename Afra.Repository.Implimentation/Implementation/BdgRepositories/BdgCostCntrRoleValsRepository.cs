using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgCostCntrRoleValsRepository : Repository<BdgCostCntrRoleVals> , IBdgCostCntrRoleValsRepository
    {
        public BdgCostCntrRoleValsRepository(DataContext context) : base(context)
        {
        }
    }
}
