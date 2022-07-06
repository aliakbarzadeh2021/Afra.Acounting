using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgProjectDetRepository : Repository<BdgProjectDet> , IBdgProjectDetRepository
    {
        public BdgProjectDetRepository(DataContext context) : base(context)
        {
        }
    }
}
