using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgContsRepository : Repository<BdgConts> , IBdgContsRepository
    {
        public BdgContsRepository(DataContext context) : base(context)
        {
        }
    }
}
