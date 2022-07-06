using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgTaxDetRepository : Repository<BdgTaxDet> , IBdgTaxDetRepository
    {
        public BdgTaxDetRepository(DataContext context) : base(context)
        {
        }
    }
}
