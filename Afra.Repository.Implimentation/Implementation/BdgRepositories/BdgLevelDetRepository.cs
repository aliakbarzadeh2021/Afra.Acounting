using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgLevelDetRepository : Repository<BdgLevelDet> , IBdgLevelDetRepository
    {
        public BdgLevelDetRepository(DataContext context) : base(context)
        {
        }
    }
}
