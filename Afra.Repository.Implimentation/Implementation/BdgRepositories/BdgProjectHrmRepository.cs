using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgProjectHrmRepository : Repository<BdgProjectHrm> , IBdgProjectHrmRepository
    {
        public BdgProjectHrmRepository(DataContext context) : base(context)
        {
        }
    }
}
