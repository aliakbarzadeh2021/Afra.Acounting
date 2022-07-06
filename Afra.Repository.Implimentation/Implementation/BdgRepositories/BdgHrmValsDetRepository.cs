using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgHrmValsDetRepository : Repository<BdgHrmValsDet> , IBdgHrmValsDetRepository
    {
        public BdgHrmValsDetRepository(DataContext context) : base(context)
        {
        }
    }
}
