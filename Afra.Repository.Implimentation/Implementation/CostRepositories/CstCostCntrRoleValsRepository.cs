using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstCostCntrRoleValsRepository : Repository<CstCostCntrRoleVals> , ICstCostCntrRoleValsRepository
    {
        public CstCostCntrRoleValsRepository(DataContext context) : base(context)
        {
        }
    }
}
