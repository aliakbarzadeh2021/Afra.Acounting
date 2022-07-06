using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgHrmBaseRepository : Repository<BdgHrmBase> , IBdgHrmBaseRepository
    {
        public BdgHrmBaseRepository(DataContext context) : base(context)
        {
        }
    }
}
