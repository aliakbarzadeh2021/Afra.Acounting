using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgElmntValRepository : Repository<BdgElmntVal> , IBdgElmntValRepository
    {
        public BdgElmntValRepository(DataContext context) : base(context)
        {
        }
    }
}
