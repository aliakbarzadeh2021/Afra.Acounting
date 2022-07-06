using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstCostAllocDetRepository : Repository<CstCostAllocDet> , ICstCostAllocDetRepository
    {
        public CstCostAllocDetRepository(DataContext context) : base(context)
        {
        }
    }
}
