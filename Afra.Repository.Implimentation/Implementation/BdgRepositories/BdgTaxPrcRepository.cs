using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgTaxPrcRepository : Repository<BdgTaxPrc> , IBdgTaxPrcRepository
    {
        public BdgTaxPrcRepository(DataContext context) : base(context)
        {
        }
    }
}
