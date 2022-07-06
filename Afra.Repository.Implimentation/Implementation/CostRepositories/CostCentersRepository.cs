using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CostCentersRepository : Repository<CostCenters> , ICostCentersRepository
    {
        public CostCentersRepository(DataContext context) : base(context)
        {
        }
    }
}
