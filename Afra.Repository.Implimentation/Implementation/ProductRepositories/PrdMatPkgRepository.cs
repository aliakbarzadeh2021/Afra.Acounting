using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdMatPkgRepository : Repository<PrdMatPkg> , IPrdMatPkgRepository
    {
        public PrdMatPkgRepository(DataContext context) : base(context)
        {
        }
    }
}
