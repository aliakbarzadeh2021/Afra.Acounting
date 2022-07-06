using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstCostCntrElmntRoleRepository : Repository<CstCostCntrElmntRole> , ICstCostCntrElmntRoleRepository
    {
        public CstCostCntrElmntRoleRepository(DataContext context) : base(context)
        {
        }
    }
}
