using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgElmntValsDetRepository : Repository<BdgElmntValsDet> , IBdgElmntValsDetRepository
    {
        public BdgElmntValsDetRepository(DataContext context) : base(context)
        {
        }
    }
}
