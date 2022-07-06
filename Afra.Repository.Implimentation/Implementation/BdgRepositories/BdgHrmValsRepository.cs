using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgHrmValsRepository : Repository<BdgHrmVals> , IBdgHrmValsRepository
    {
        public BdgHrmValsRepository(DataContext context) : base(context)
        {
        }
    }
}
