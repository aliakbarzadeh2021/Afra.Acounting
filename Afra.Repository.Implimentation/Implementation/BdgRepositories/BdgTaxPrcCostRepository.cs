using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgTaxPrcCostRepository : Repository<BdgTaxPrcCost> , IBdgTaxPrcCostRepository
    {
        public BdgTaxPrcCostRepository(DataContext context) : base(context)
        {
        }
    }
}
