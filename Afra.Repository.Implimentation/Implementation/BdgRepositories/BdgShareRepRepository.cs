using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgShareRepRepository : Repository<BdgShareRep> , IBdgShareRepRepository
    {
        public BdgShareRepRepository(DataContext context) : base(context)
        {
        }
    }
}
