using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstCostCntrFillRepository : Repository<CstCostCntrFill> , ICstCostCntrFillRepository
    {
        public CstCostCntrFillRepository(DataContext context) : base(context)
        {
        }
    }
}
